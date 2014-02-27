using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ReportingPortal.Class
{
    public static class DataConnections
    {
        public static DataSet RunQuery_PortalAdmin(string query)
        {
            SqlConnection PortalAdminConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PortalAdmin_CS"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand sc = new SqlCommand(query, PortalAdminConnection);

            DataSet ds = new DataSet();

            da.SelectCommand = sc;

            try
            {
                PortalAdminConnection.Open();
                da.Fill(ds);
                PortalAdminConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public static void RunSPReturnNone_PortalAdmin(string spName, SqlParameter[] sqlParams)
        {
            SqlConnection PortalAdminConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PortalAdmin_CS"].ConnectionString);
            SqlCommand cmd = new SqlCommand(spName, PortalAdminConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter p in sqlParams)
                cmd.Parameters.Add(p);

            DataSet ds = new DataSet();

            try
            {
                PortalAdminConnection.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                PortalAdminConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static DataSet RunSPReturnData_PortalAdmin(string spName, SqlParameter[] sqlParams)
        {
            SqlConnection PortalAdminConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PortalAdmin_CS"].ConnectionString);
            SqlCommand cmd = new SqlCommand(spName, PortalAdminConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter p in sqlParams)
                cmd.Parameters.Add(p);

            DataSet ds = new DataSet();
            da.SelectCommand = cmd;

            try
            {
                PortalAdminConnection.Open();
                da.Fill(ds);
                PortalAdminConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ds;
        }
    }
}