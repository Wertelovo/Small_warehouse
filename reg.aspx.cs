using System;

namespace TraidApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text) || string.IsNullOrEmpty(TextBox5.Text) || string.IsNullOrEmpty(TextBox6.Text))
            {
                errors.Text = "Пожалуйста, заполните все поля.";
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wertelovo\Desktop\TraidApp\App_Data\DB1.mdf;Integrated Security=True";

            try
            {
                using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                {
                    Users newUser = new Users();
                    newUser.UserLogin = TextBox1.Text;
                    newUser.UserPassword = TextBox2.Text;
                    newUser.FirstName = TextBox3.Text;
                    newUser.LastName = TextBox4.Text;
                    newUser.ShopName = TextBox5.Text;
                    newUser.Adress = TextBox6.Text;

                    // Добавление нового пользователя в таблицу Users
                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();

                    // Присвоение роли "пользователь" новому пользователю
                    var userRoles = new UserRoles();
                    userRoles.UserId = newUser.Id;
                    userRoles.RoleId = 1; // Идентификатор роли "пользователь"
                    db.UserRoles.InsertOnSubmit(userRoles);
                    db.SubmitChanges();

                    // Аутентификация пользователя после успешной регистрации
                    Session["UserId"] = newUser.Id;

                    // Перенаправление на другую страницу после успешной регистрации
                    Response.Redirect("/UserPage.aspx");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки регистрации
                errors.Text = "Ошибка регистрации: " + ex.Message;
            }
        }
    }
}