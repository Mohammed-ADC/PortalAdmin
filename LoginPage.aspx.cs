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
    public partial class LoginPage: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();//.StoredProcedure.("CheckUser_Portal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CheckUser_Portal";
                cmd.Connection = cn;
                cn.Open();

                SqlParameter p1, p2, p3;
                p1 = cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                p1.Direction = ParameterDirection.Input;
                p1.Value = LName.Text;

                p2 = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
                p2.Direction = ParameterDirection.Input;
                p2.Value = LPassword.Text;

                p3 = cmd.Parameters.Add("@F", SqlDbType.Int);
                p3.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int n = int.Parse(p3.Value.ToString());
                if (n == 0)
                    Response.Write("User Name does not exits");
                //Response.Redirect("register.aspx");
                else

                    Response.Write("Hi");
                    Response.Redirect("UserAdmin.aspx");
            }
        }
    }
}