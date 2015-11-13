using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de cass 
/// </summary>
/// 
namespace Carssi.Classes
{
    public class cass
    {

        public SqlConnection conn = new SqlConnection("Data Source=ALTIMEX\\ALTIMEX;Initial Catalog=gasolinera;User ID=sa;Password=123456");
       // public string constr = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        public  void ExecSP(string SPName, string Parameter, object ParameterValue, DbType  DbType)
        {
            try
            {


                SqlCommand cmd = new SqlCommand(SPName, conn);
                cmd.Parameters.Add(Parameter, DbType).Value = ParameterValue;
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ExecSP(string SPName, string[] Parameters, object[] ParametersValues, DbType[] DbTypes)
        {
            if (Parameters.Length != ParametersValues.Length || Parameters.Length != DbTypes.Length || DbTypes.Length != ParametersValues.Length)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(SPName, conn);
                for (int i = 0; i <= Parameters.Length - 1; i++)
                {
                    cmd.Parameters.Add(Parameters[i], DbTypes[i]).Value = ParametersValues[i];
                }
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable getDTfromSP(string SPName, string Parameter, object ParameterValue, DbType DbType)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(SPName, conn);
                cmd.Parameters.Add(Parameter, DbType).Value = ParameterValue;
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sdaIns = new SqlDataAdapter(cmd);
                sdaIns.SelectCommand = cmd;
                sdaIns.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
            return dt;
        }

        public  DataTable getDTfromSQL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
            return dt;
        }

        public DataTable getDTfromSP(string SPName, string[] Parameters, object[] ParametersValues, DbType[] DbTypes)
        {
            if (Parameters.Length != ParametersValues.Length || Parameters.Length != DbTypes.Length || DbTypes.Length != ParametersValues.Length)
                return null;
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(SPName, conn);
                for (int i = 0; i <= Parameters.Length - 1; i++)
                {
                    cmd.Parameters.Add(Parameters[i], DbTypes[i]).Value = ParametersValues[i];
                }
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sdaIns = new SqlDataAdapter(cmd);
                sdaIns.SelectCommand = cmd;
                sdaIns.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
            return dt;
        }  
    }
}