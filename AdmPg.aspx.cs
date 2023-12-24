using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraidApp
{
    public partial class AdmPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleId"] != null)
            {
                string roleIdString = Session["RoleId"].ToString();

                int roleId;
                if (int.TryParse(roleIdString, out roleId))
                {
                    if (roleId == 1 || roleId == 2)
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wertelovo\Desktop\TraidApp\App_Data\DB1.mdf;Integrated Security=True";

            try
            {
                using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                {
                    // Создаем новый экземпляр класса Product
                    Products newProduct = new Products();

                    // Заполняем свойства товара из текстовых полей
                    newProduct.Name = TextBox1.Text;
                    newProduct.Price = Convert.ToDecimal(TextBox2.Text);
                    newProduct.Quantity = Convert.ToInt32(TextBox3);
                    newProduct.Description = TextBox4.Text;

                    // Добавляем новый товар в таблицу Product
                    db.Products.InsertOnSubmit(newProduct);
                    db.SubmitChanges();

                    // Очищаем текстовые поля после добавления товара
                    TextBox1.Text = string.Empty;
                    TextBox2.Text = string.Empty;
                    TextBox3.Text = string.Empty;
                    TextBox4.Text = string.Empty;

                    // Выводим сообщение об успешном добавлении товара
                    errors.Text = "Товар успешно добавлен.";
                }
            }
            catch (Exception ex)
            {
                errors.Text = "Ошибка при добавлении товара: " + ex.Message;
            }
        }
    }
}