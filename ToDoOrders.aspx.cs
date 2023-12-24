using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraidApp
{
    public partial class ToDoOrders : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                string folderPath = "~/Orders";
                DirectoryInfo directoryInfo = new DirectoryInfo(Server.MapPath(folderPath));
                FileInfo[] files = directoryInfo.GetFiles();

                DataTable dataTable = new DataTable();
                dataTable.Columns.AddRange(new DataColumn[3] { new DataColumn("FileName"), new DataColumn("CreationTime"), new DataColumn("FilePath") });

                foreach (FileInfo file in files)
                {
                    dataTable.Rows.Add(file.Name, file.CreationTime, file.FullName);
                }

                fileGridView.DataSource = dataTable;
                fileGridView.DataBind();
            }
        }
        protected void DownloadFile(object sender, EventArgs e)
        {
            LinkButton downloadLink = (LinkButton)sender;
            string virtualPath = downloadLink.CommandArgument;
            string fileName = Path.GetFileName(virtualPath);

            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.TransmitFile(virtualPath);
            Response.End();
        }
    }
}