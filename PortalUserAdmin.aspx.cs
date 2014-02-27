using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ReportingPortal.Class;

namespace ReportingPortal
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
        }
             protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["PortalReporting_CS"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("select FirstName,LastName from [dbo].[User] where (FirstName like '%" + TxtSearchFName.Text + "%'OR FirstName = '') AND (LastName like '%" + TxtSearchLName.Text + "%'OR LastName = '')AND (Login like '%" + TxtSearchEmail.Text + "%'OR Login = '') AND (FirstName <> '')AND (LastName <> '')", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "demo1");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click1(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams;
            {
                sqlParams = new SqlParameter[5];
                sqlParams[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 40);
                sqlParams[0].Value = TxtAddFName.Text.Trim();
                sqlParams[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 40);
                sqlParams[1].Value = TxtAddLName.Text.Trim();
                sqlParams[2] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                sqlParams[2].Value = TxtAddEmail.Text.Trim();
                sqlParams[3] = new SqlParameter("@Password", SqlDbType.VarChar, 40);
                sqlParams[3].Value = TxtAddPassword.Text.Trim();
                sqlParams[4] = new SqlParameter("@IsActive", SqlDbType.Bit, 1);
                sqlParams[4].Value = CheckBox1.Checked;
            }

            DataConnections.RunSPReturnNone_PortalAdmin("spS_InsertUser", sqlParams);
        }

        protected void BtnDelete_Click1(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams;
            {
                sqlParams = new SqlParameter[3];
                sqlParams[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 40);
                sqlParams[0].Value = TxtAddFName.Text.Trim();
                sqlParams[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 40);
                sqlParams[1].Value = TxtAddLName.Text.Trim();
                sqlParams[2] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                sqlParams[2].Value = TxtAddEmail.Text.Trim();
            }
            DataConnections.RunSPReturnNone_PortalAdmin("spS_DeleteUser", sqlParams);
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams;
            {
                sqlParams = new SqlParameter[4];
                sqlParams[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 40);
                sqlParams[0].Value = TxtAddFName.Text.Trim();
                sqlParams[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 40);
                sqlParams[1].Value = TxtAddLName.Text.Trim();
                sqlParams[2] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                sqlParams[2].Value = TxtAddEmail.Text.Trim();
                sqlParams[3] = new SqlParameter("@Password", SqlDbType.VarChar, 40);
                sqlParams[3].Value = TxtAddPassword.Text.Trim();
            }

            DataConnections.RunSPReturnNone_PortalAdmin("spS_UpdateUser", sqlParams);
        }

        protected void TxtAddEmail_TextChanged(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["PortalAdmin_CS"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select count(*) from dbo.Users Where Email = '" + TxtAddEmail.Text + "'", cn);
                cn.Open();
                int n = int.Parse(cmd.ExecuteScalar().ToString());
                if (n > 0)
                {
                    Label4.Text = "Emial is already in use";
                    Label4.Visible = true;
                    BtnAdd.Enabled = false;
                }
                else
                {
                    Label4.Visible = false;
                    BtnAdd.Enabled = true;
                }

            }

        }
       
    }
}
