using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SMarketPlace.DAO
{
    public abstract class BaseDAO
    {

        private ConnectionStringSettings m_consstr;
        private DbProviderFactory m_dataProvider;
        private DbConnection m_dbConn;

        public BaseDAO(ConnectionStringSettings ConnStr)
        {
            m_consstr = ConnStr;
            m_dataProvider = DbProviderFactories.GetFactory(ConnStr.ProviderName);
        }


        public DbCommand CreateCommand()
        {
            return m_dataProvider.CreateCommand();
        }

        private DbConnection CreateConnection()
        {
            if (m_dbConn != null)
            {}
            else
            {
                m_dbConn = m_dataProvider.CreateConnection();
            }

            m_dbConn.ConnectionString = m_consstr.ConnectionString;
            return m_dbConn;
        }

        public DataSet GetDataset(string query)
        {
            DbConnection DbConn = CreateConnection();
        
            DbDataAdapter dbAdapter = GetDataAdapter(query, DbConn);
            DataSet result = new DataSet();
            dbAdapter.Fill(result);
            DbConn.Close();
            return result;
        }

        public DataSet GetDataSetSP(DbCommand cmd)
        {
            DbConnection dbConn = CreateConnection();
            cmd.CommandTimeout = 180000;
            DbDataAdapter dAdapter = GetDataAdapter(cmd);
            DataSet result = new DataSet();
            cmd.Connection = dbConn;
            cmd.CommandType = CommandType.StoredProcedure;
            dAdapter.Fill(result);
            dbConn.Close();
            return result;
        }


        private DbDataAdapter GetDataAdapter( string query, DbConnection DbConn )
        {
            DbDataAdapter dBDataAdapter = m_dataProvider.CreateDataAdapter();
            DbCommand dbComm = DbConn.CreateCommand();
            dbComm.CommandTimeout = 60000000;
            dbComm.CommandText = query;
            dBDataAdapter.SelectCommand = dbComm;
            return dBDataAdapter;
        }

        private DbDataAdapter GetDataAdapter(DbCommand cmd)
        {
            DbDataAdapter dAdapter = m_dataProvider.CreateDataAdapter();
            dAdapter.SelectCommand = cmd;
            return dAdapter;
        }


        protected int ExecuteNonQuery(string query)
        {
            DbConnection dbConn = CreateConnection();
            int result;
            DbCommand cmd = CreateCommand();
            cmd.CommandText = query;
            cmd.Connection = dbConn;
            cmd.CommandTimeout = 30000;
            dbConn.Open();
            result = cmd.ExecuteNonQuery();
            dbConn.Close();
            return result;
        }

        protected int ExecuteNonQuery(DbCommand cmd )
        {
            DbConnection dbConn = CreateConnection();
            int result;
            cmd.Connection = dbConn;
            dbConn.Open();
            result = cmd.ExecuteNonQuery();
            dbConn.Close();
            return result;
        }

    }


    public class Productos
    {

        public Productos(string strNombre, string strCodigo, string strDivision, string strUrl)
        {
            Nombre = strNombre;
            Url = strUrl;
            Codigo = strCodigo;
            Division = strDivision;
        }
        public string Codigo { get;  set; }
        public string Nombre { get;  set; }
        public string Division { get;  set; }
        public string Url { get;  set; }

    }
}


