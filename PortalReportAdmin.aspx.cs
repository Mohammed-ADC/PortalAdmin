using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ReportingPortal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //GridView1.Visible = false;
            //SqlConnection cn = new SqlConnection("trusted_connection=yes;database=Reporting");
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("select Name from [dbo].[ReportCategory] where (Name like '%" + SearchReport.Text + "%')", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "demo1");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Upload_Click(object sender, EventArgs e)
        {

        }

        protected void Browse_Click(object sender, EventArgs e)
        {

        }
    }
}