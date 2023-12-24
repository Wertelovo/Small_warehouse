using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using System.IO;
using OfficeOpenXml;

namespace TraidApp
{
    public partial class Order : System.Web.UI.Page
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wertelovo\Desktop\TraidApp\App_Data\DB1.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleId"] != null)
            {
                string roleIdString = Session["RoleId"].ToString();

                int roleId;
                if (int.TryParse(roleIdString, out roleId))
                {
                    if (roleId == 1)
                    {
                        Response.Write("У вас нет доступа к этой странице.");
                        Response.Redirect("/UserPage.aspx");
                    }
                }
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }
        }

        protected void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkSelect = (CheckBox)sender;
            GridViewRow row = (GridViewRow)chkSelect.NamingContainer;
            int productId = Convert.ToInt32(GridView1.DataKeys[row.RowIndex].Value);
            TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity"); // Получить TextBox из текущей строки

            if (chkSelect.Checked)
            {
                int quantity;
                if (int.TryParse(txtQuantity.Text, out quantity))
                {
                    // Продукт выбран - добавляем его в заказ

                    using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                    {
                        var product = db.Products.SingleOrDefault(p => p.Id == productId);
                        var user = db.Users.FirstOrDefault(u => u.Id == (int)Session["UserId"]); // Получаем данные пользователя из таблицы "Users"

                        if (product != null && user != null)
                        {
                            decimal totalPrice = quantity * product.Price;

                            // Создать новый заказ и заполнить его данными пользователя
                            Orders newOrder = new Orders()
                            {
                                CustomerName = user.FirstName + " " + user.LastName,
                                CustomerEmail = user.UserLogin,
                                ShopName = user.ShopName,
                                Address = user.Adress,
                                OrderDate = DateTime.Now,
                                TotalPrice = totalPrice
                            };

                            // Добавить заказ в таблицу Orders
                            db.Orders.InsertOnSubmit(newOrder);
                            db.SubmitChanges();

                            // Получить идентификатор созданного заказа
                            int orderId = newOrder.Id;

                            // Добавить продукт в таблицу OrderProducts
                            OrderProducts orderProduct = new OrderProducts
                            {
                                OrderId = orderId,
                                ProductId = productId,
                                Quantity = quantity
                            };
                            db.OrderProducts.InsertOnSubmit(orderProduct);
                            db.SubmitChanges();
                        }
                    }
                }
                else
                {
                    // Обработка ошибки неверного формата ввода в текстовое поле
                    string errorMessage = "Неверный формат ввода для количества товара";
                    ClientScript.RegisterStartupScript(this.GetType(), "showError", $"alert('{errorMessage}');", true);
                }
            }
        }

        protected void btnGenerateTable_Click(object sender, EventArgs e)
        {
            DataTable selectedProducts = GetSelectedProductsFromGridView();

            if (selectedProducts.Rows.Count > 0)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Заказ");

                    // Задаем заголовки столбцов
                    worksheet.Cells[1, 1].Value = "Наименование";
                    worksheet.Cells[1, 2].Value = "Количество";
                    worksheet.Cells[1, 3].Value = "Цена";
                    worksheet.Cells[1, 4].Value = "Сумма";

                    // Заполняем таблицу данными
                    int row = 2; // Начальная строка для данных
                    decimal totalPrice = 0;

                    foreach (DataRow productRow in selectedProducts.Rows)
                    {
                        string productName = productRow["Name"].ToString();
                        int quantity = Convert.ToInt32(productRow["Quantity"]);
                        decimal price = Convert.ToDecimal(productRow["Price"]);
                        decimal total = quantity * price;
                        totalPrice += total;

                        worksheet.Cells[row, 1].Value = productName;
                        worksheet.Cells[row, 2].Value = quantity;
                        worksheet.Cells[row, 3].Value = price;
                        worksheet.Cells[row, 4].Value = total;

                        row++;
                    }

                    // Добавляем общую сумму в конец таблицы
                    int totalRow = row + 1;
                    worksheet.Cells[totalRow, 3].Value = "Общая сумма:";
                    worksheet.Cells[totalRow, 4].Value = totalPrice;

                    // Получаем данные о клиенте из базы данных
                    int userId = (int)Session["UserId"];
                    using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                    {
                        var user = db.Users.FirstOrDefault(u => u.Id == userId);
                        if (user != null)
                        {
                            // Добавляем данные о клиенте в таблицу
                            int userInfoRow = totalRow + 2;
                            worksheet.Cells[userInfoRow, 1].Value = "Имя клиента:";
                            worksheet.Cells[userInfoRow, 2].Value = user.FirstName + " " + user.LastName;
                            int emailRow = userInfoRow + 1;
                            worksheet.Cells[emailRow, 1].Value = "Email клиента:";
                            worksheet.Cells[emailRow, 2].Value = user.UserLogin;
                            int shopNameRow = emailRow + 1;
                            worksheet.Cells[shopNameRow, 1].Value = "Название магазина:";
                            worksheet.Cells[shopNameRow, 2].Value = user.ShopName;
                            int addressRow = shopNameRow + 1;
                            worksheet.Cells[addressRow, 1].Value = "Адрес доставки:";
                            worksheet.Cells[addressRow, 2].Value = user.Adress;
                        }
                    }

                    // Генерируем уникальное имя файла для сохранения на сервере
                    string fileName = "Заказ_" + Guid.NewGuid().ToString() + ".xlsx";
                    string filePath = Server.MapPath("~/Orders/" + fileName);

                    // Сохраняем файл Excel на сервере
                    byte[] fileBytes = excelPackage.GetAsByteArray();
                    File.WriteAllBytes(filePath, fileBytes);

                    // Выводим сообщение пользователю с ссылкой на скачивание файла
                    string downloadLink = "<a href='" + ResolveUrl("~/Orders/" + fileName) + "'>Скачать заказ</a>";
                    lblSuccess.Text = "Заказ успешно сформирован. " + downloadLink;
                    lblSuccess.Visible = true;
                }
            }
        }

        private DataTable GetSelectedProductsFromGridView()
        {
            DataTable selectedProducts = new DataTable();
            selectedProducts.Columns.Add("Name", typeof(string));
            selectedProducts.Columns.Add("Quantity", typeof(int));
            selectedProducts.Columns.Add("Price", typeof(decimal));

            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox chkSelect = (CheckBox)row.FindControl("chkSelect");
                TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");
                int productId = Convert.ToInt32(GridView1.DataKeys[row.RowIndex].Value);

                if (chkSelect.Checked)
                {
                    int quantity;
                    if (int.TryParse(txtQuantity.Text, out quantity))
                    {
                        using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                        {
                            var product = db.Products.SingleOrDefault(p => p.Id == productId);

                            if (product != null)
                            {
                                DataRow newRow = selectedProducts.NewRow();
                                newRow["Name"] = product.Name;
                                newRow["Quantity"] = quantity;
                                newRow["Price"] = product.Price;
                                selectedProducts.Rows.Add(newRow);
                            }
                        }
                    }
                    else
                    {
                        string errorMessage = "Неверный формат ввода для количества товара";
                        ClientScript.RegisterStartupScript(this.GetType(), "showError", $"alert('{errorMessage}');", true);
                    }
                }
            }

            return selectedProducts;
        }

        private int GetOrderId()
        {
            int orderId = 0;

            using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
            {
                var lastOrderProduct = db.OrderProducts.OrderByDescending(op => op.Id).FirstOrDefault();
                if (lastOrderProduct != null)
                {
                    orderId = lastOrderProduct.OrderId;
                }
            }

            return orderId;
        }
    }
}
