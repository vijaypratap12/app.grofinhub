using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SportsBattle.Models
{
    public class DBHelper
    {
        private readonly IConfiguration _configuration;
        string consString = null;
        SqlConnection con = null;
       public string AuthorizationKey = "";
        public  string JWT = "";

        //public DBHelper()
        //{
        //    consString = _configuration.GetConnectionString("ConnectionStrings");
        //    con = new SqlConnection(consString);
        //}

        public DBHelper()
        {
            var configuation = GetConfiguration();
            con = new SqlConnection(configuation.GetSection("ConnectionStrings").GetSection("ConnectionStrings").Value);
            AuthorizationKey = configuation.GetSection("Paysprint").GetSection("AuthorizationKey").Value;
            JWT = configuation.GetSection("Paysprint").GetSection("JWT").Value;
        }
        public int ExeCUD(string proc, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in para)
            {
                if (parameter != null)
                    cmd.Parameters.Add(parameter);
            }
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        public int ExecuteNonQueryProc(string cmdText, SqlParameter[] prms)
        {
            int r = 0;
            try
            {
                //string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ToString();
                //using (SqlConnection conn = new SqlConnection(consString))
                //{
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        if (prms != null)
                        {
                            foreach (var p in prms)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        con.Open();
                        try
                        {
                            r = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            r = 0;
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                //}
            }
            catch (Exception ex)
            {

            }
            return r;
        }
        public int InsertErrorDatabase(string message)
        {
            SqlConnection con = new SqlConnection(consString);
            SqlCommand cmd = new SqlCommand();
 

                //if (obj.BlockchainTransactionStatus != 2) 
                //{
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "InsertError";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@BatchId", System.Data.SqlDbType.VarChar, 225).Value = obj.BatchId;
                cmd.Parameters.Add("@message", System.Data.SqlDbType.NVarChar, 500).Value = message;
                //cmd.Parameters.Add("@BlockchainStatus", System.Data.SqlDbType.Int).Value = obj.BlockchainTransactionStatus;
                 return cmd.ExecuteNonQuery();             
        }
        public DataTable ExecProcDataTable(string ProName, SqlParameter[] Param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(ProName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (Param != null)
                {
                    foreach (SqlParameter prm in Param)
                    {
                        cmd.Parameters.Add(prm);
                    }
                }
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataSet ExecProcDataSet(string ProName, SqlParameter[] Param)
        {
            DataSet dt = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(ProName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter prm in Param)
                {
                    cmd.Parameters.Add(prm);
                }
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return dt;
        }


        public DataTable ExecAdaptorDataTable(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            return dt;
        }


        public int ExecuteNonQuery(string Query)
        {
            int r = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(consString))
                {
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        try
                        {
                            r = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            r = 0;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return r;
        }




        public object ExecuteExecuteScalar(string Query)
        {
            object r = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(consString))
                {
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        try
                        {
                            r = cmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            r = 0;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return r;
        }


    }
}
