using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMarketPlace.DAO;
using System.Configuration;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.Common;

namespace SMarketPlace.DAO
{
    public class CatalogoDAO : BaseDAO
    {
     
        public CatalogoDAO(ConnectionStringSettings ConnStr) : base(ConnStr)
        {}


  
        public List<Productos> getArticulos()
        {
            try
            {

                string Query = " SELECT  Codigo as SKU,NOMBREARTICULO, DIVISION, CATEGORIA FROM TblArticulo ";
                var Listado = new List<Productos>();
                DataSet ds = GetDataset(Query);
                if (ds != null && ds.Tables.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        //var Nombre = dr[""];
                        Listado.Add(new Productos(dr["NOMBREARTICULO"].ToString(), dr["SKU"].ToString(), dr["DIVISION"].ToString(), ""));
                    }



                    return Listado;
                }
                return null;
            }
            catch {
                return null;
            }
        }


        public DataTable  GetAllAquery(string Query)
        {
            DataSet ds = GetDataset(Query);
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                return dt;
            }
            return null;

        }


        public int EjecutarCommand(string Query)
        {
            DbCommand cmd  = CreateCommand();
            cmd.CommandText = Query;

            return ExecuteNonQuery(cmd);

        }

        public DataSet ExecSP(string Query)
        {

            DbCommand cmd = CreateCommand();
            cmd.CommandText = Query;

            DataSet ds = GetDataSetSP(cmd);
            if (ds != null && ds.Tables.Count > 0)
            {

                return ds;
            }
            return null;

        }



    }
}