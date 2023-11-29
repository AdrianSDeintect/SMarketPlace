using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketPlaceUtils.SQL
{
	public class SMPSQLServer
	{
		/// <summary>
		/// Ejecuta query, no regresa resultados
		/// </summary>
		public static void ExecuteNonQuery(string strQuery,  int? iTimeOut = null)
		{
			string strConnectionString;

			try
			{
                //SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SMD"].ConnectionString);
                //StrConnection = ConfigurationManager.ConnectionStrings["SMD"].ConnectionString;

                //strConnectionString = "Server=sqlbmty8new;Database=SMP;Trusted_Connection=True;Integrated Security=False; User Id=consultas_qlik; Password=con*2023;Encrypt=false;TrustServerCertificate=true";
                strConnectionString = "Server = fb_adriansoto\\SQLSERVER; Database = SMP; Trusted_Connection = True; Integrated Security = true; Encrypt = false; TrustServerCertificate = true";
                //strConnectionString = "Server = CDDMTYW8KDESSC; Database = SMP5; Trusted_Connection = True; Integrated Security = true; Encrypt = false; TrustServerCertificate = true";

                iTimeOut = iTimeOut == null ? 1200 : iTimeOut;
			}
			catch
			{
				throw;
			}

			try
			{
				SqlConnection conn = new SqlConnection(strConnectionString);
				SqlCommand cmd = new SqlCommand(strQuery, conn);
				cmd.CommandTimeout = (int)iTimeOut;
				conn.Open();
				cmd.ExecuteNonQuery();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				conn.Close();
				da.Dispose();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message + Environment.NewLine + "Query: " + Environment.NewLine + strQuery, e);
			}
		}

		/// <summary>
		/// Ejecuta query, regresa dataset con las tablas que regrese la consulta
		/// </summary>
		public static DataSet ExecuteDataSet(string strQuery, int? iTimeOut = null)
		{
			DataSet ds = new DataSet();

			string strConnectionString;
			try
			{
                //StrConnection = "Server=sqlbmty8new;Database=SMP;Trusted_Connection=True;Integrated Security=False; User Id=consultas_qlik; Password=con*2023;Encrypt=false;TrustServerCertificate=true";
                strConnectionString = "Server = fb_adriansoto\\SQLSERVER; Database = SMP; Trusted_Connection = True; Integrated Security = true; Encrypt = false; TrustServerCertificate = true";
                //strConnectionString = "Server = CDDMTYW8KDESSC; Database = SMP5; Trusted_Connection = True; Integrated Security = true; Encrypt = false; TrustServerCertificate = true";
                //strConnectionString = StrConnection;
                iTimeOut = iTimeOut == null ? 1200 : iTimeOut;
			}
			catch
			{
				throw;
			}

			try
			{
				SqlConnection conn = new SqlConnection(strConnectionString);
				SqlCommand cmd = new SqlCommand(strQuery, conn);
				cmd.CommandTimeout = (int)iTimeOut;
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(ds);
				conn.Close();
				da.Dispose();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message + Environment.NewLine + "Query: " + Environment.NewLine + strQuery, e);
			}

			if (ds != null && ds.Tables.Count > 0)
			{
				return ds;
			}

			return null;
		}
	}
}
