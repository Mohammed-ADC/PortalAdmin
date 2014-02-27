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
    public partial class UserAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                      
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //GridView1.Visible = false;
            //SqlConnection cn = new SqlConnection("trusted_connection=yes;database=Reporting");
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("select FirstName,LastName from [dbo].[User] where (FirstName like '%" + SearchFName.Text + "%'OR FirstName = '') AND (LastName like '%" + SearchLName.Text + "%'OR LastName = '')AND (Login like '%" + SearchEmail.Text + "%'OR Login = '') AND (FirstName <> '')AND (LastName <> '')", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "demo1");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             //string CS = ConfigurationManager.ConnectionStrings["DBCS1"].ConnectionString;
             //using (SqlConnection cn = new SqlConnection(CS))
             //{
             //    //SqlCommand cmd = new SqlCommand("Update Users set Password='" + AddPassword.Text + "',LastName'" + AddLName.Text + "',Email'" + AddEmail.Text + "'FirstName='" + AddFName.Text + "',isActive'"+ CheckBox1"'", cn);
             //    SqlCommand cmd = new SqlCommand("insert into Users(FirstName,LastName,Email,Password,isActive) Values ('" + AddFName.Text + "','" + AddLName.Text + "','" + AddEmail.Text + "','" + AddPassword.Text + "','" + CheckBox1.Checked + "')", cn);
            
             //    cn.Open();
             //    cmd.ExecuteNonQuery();
             //    //if (i > 0)
             //    //    Response.Write("User created");
             //    //else
             //    //    Response.Write("User is not registered");
             //}
        }
       
    }
}