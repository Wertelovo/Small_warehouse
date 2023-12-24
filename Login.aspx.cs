using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;

namespace TraidApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login1.UserName) || string.IsNullOrEmpty(Login1.Password))
            {
                errors.Text = "Пожалуйста, заполните все поля.";
                return;
            }

            // Получение данных всех пользователей из базы данных
            List<User> users = GetUsersData();

            // Поиск пользователя с введенными данными
            User user = users.Find(u => u.UserLogin == Login1.UserName && u.UserPassword == Login1.Password);

            if (user != null)
            {
                // Пользователь найден
                int roleId = user.RoleId;

                switch (roleId)
                {
                    case 1:
                        Session["UserId"] = user.UserId;
                        Session["RoleId"] = "1";
                        Response.Redirect("/UserPage.aspx");
                        break;
                    case 2:
                        Session["UserId"] = user.UserId;
                        Session["RoleId"] = "2";
                        Response.Redirect("/Order.aspx");
                        break;
                    case 3:
                        Session["UserId"] = user.UserId;
                        Session["RoleId"] = "3";
                        Response.Redirect("/AdmPg.aspx");
                        break;
                    default:
                        errors.Text = "Неизвестная роль пользователя!";
                        break;
                }
            }
            else
            {
                // Пользователь с указанными данными не найден
                errors.Text = "Ошибка авторизации. Проверьте правильность введенных данных.";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/reg.aspx");
        }

        // Метод для получения данных всех пользователей из базы данных
        private List<User> GetUsersData()
        {
            List<User> users = new List<User>();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wertelovo\Desktop\TraidApp\App_Data\DB1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT u.UserLogin, u.UserPassword, ur.RoleId, u.Id FROM Users u JOIN UserRoles ur ON u.Id = ur.UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userLogin = reader.GetString(0);
                            string userPassword = reader.GetString(1);
                            int roleId = reader.GetInt32(2);
                            int userId = reader.GetInt32(3);

                            users.Add(new User { UserLogin = userLogin, UserPassword = userPassword, RoleId = roleId, UserId = userId });
                        }
                    }
                }
            }

            return users;
        }
    }

    public class User
    {
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}