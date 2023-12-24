using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraidApp
{
    public partial class SiteMaster : MasterPage
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wertelovo\Desktop\TraidApp\App_Data\DB1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    
                    int userId = Convert.ToInt32(Session["UserId"]);
                    // Получаем имя пользователя из базы данных
                    using (AllClassesDataContext db = new AllClassesDataContext(connectionString))
                    {
                        var user = db.Users.FirstOrDefault(u => u.Id == (int)Session["UserId"]);
                        
                       
                            string username ="Здравствуйте " + user.FirstName + " " + user.LastName;
                            Label1.Text = username;
                        
                    }
     
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

            Session.Clear();
            Response.Redirect("/Login.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}