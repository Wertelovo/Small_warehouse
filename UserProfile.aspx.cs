using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraidApp
{
    public partial class UserProfile : System.Web.UI.Page
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wertelovo\Desktop\TraidApp\App_Data\DB1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    // Если пользователь не аутентифицирован, перенаправляем его на страницу логина
                    Response.Redirect("/Login.aspx");
                }

                int userId = (int)Session["UserId"];
               using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == userId);

                    if (user != null)
                    {

                        userLoginTextBox.Text = user.UserLogin;
                        passwordTextBox.Text = user.UserPassword;
                        firstNameTextBox.Text = user.FirstName;
                        lastNameTextBox.Text = user.LastName;
                        shopNameTextBox.Text = user.ShopName;
                        addressTextBox.Text = user.Adress;
                    }
                }
                 
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}