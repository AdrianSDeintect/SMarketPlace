using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMarketPlaceUtils;
using SMarketPlaceUtils.SQL;

namespace SMarketPlaceUtils
{
	public class ProcesosDB
	{
		public static void ProcesoBarridoYLogProductos(string tblName, string module, string StrConnection)
		{
			try
			{
				string strQueryDeleteTbl = "delete from " + tblName;
				string strQuery;
				if (!string.IsNullOrEmpty(tblName) && !string.IsNullOrEmpty(module))
				{

					if (module == "Didi")
					{
						strQuery = @" 
							INSERT INTO [dbo].[LogProductosMP] (intArticuloid, tipoMP)
							SELECT intArticuloid, 'Didi' 
							FROM [dbo].[tblproductosDidi] ";
						SMPSQL.ExecuteNonQuery(strQuery, StrConnection);						
					}
					else if (module == "Rappi")
					{
						strQuery = @" 
							INSERT INTO [dbo].[LogProductosMP] (intArticuloid, tipoMP)
							SELECT intArticuloid, 'Rappi' 
							FROM [dbo].[tblproductosRappi] ";
						SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
					}
					else if (module == "Uber")
					{
						strQuery = @" 
							INSERT INTO [dbo].[LogProductosMP] (intArticuloid, tipoMP)
							SELECT intArticuloid, 'Uber' 
							FROM [dbo].[tblproductosUber] ";
						SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
					}

					//Borrado de la tabla Articulos
					try
					{
						SMPSQL.ExecuteNonQuery(strQueryDeleteTbl, StrConnection);
					}
					catch (Exception e)
					{
						Log.Write("Error al limpiar tabla " + tblName + Environment.NewLine + e.StackTrace);
						return;
					}

				}
			}
			catch (Exception e)
			{
				Log.Write(e.Message + Environment.NewLine + e.StackTrace);
				return;
			}

		}

		public static void ProcesoBarridoYLogSucursales(string tblName, string module, string StrConnection)
		{
			try
			{
				string strQueryDeleteTbl = "delete from " + tblName;
				string strQuery;
				if (!string.IsNullOrEmpty(tblName) && !string.IsNullOrEmpty(module))
				{

					if (module == "Didi")
					{
						strQuery = @" 
							INSERT INTO [dbo].[LogSucursalesMP] (LocalSAP, tipoMP)
							SELECT LocalSAP, 'Didi' 
							FROM [dbo].[TBLSucursalDidi] ";

						SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
					}
					else if (module == "Rappi")
					{
						strQuery = @" 
							INSERT INTO [dbo].[LogSucursalesMP] (LocalSAP, tipoMP)
							SELECT LocalSAP, 'Rappi' 
							FROM [dbo].[TBLSucursalRappi] ";
						SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
					}
					else if (module == "Uber")
					{
						strQuery = @" 
							INSERT INTO [dbo].[LogSucursalesMP] (LocalSAP, tipoMP)
							SELECT LocalSAP, 'Uber' 
							FROM [dbo].[TBLSucursalUber] ";
						SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
					}

					//Borrado de la tabla Articulos
					try
					{
						SMPSQL.ExecuteNonQuery(strQueryDeleteTbl, StrConnection);
					}
					catch (Exception e)
					{
						Log.Write("Error al limpiar tabla " + tblName + Environment.NewLine + e.StackTrace);
						return;
					}

				}
			}
			catch (Exception e)
			{
				Log.Write(e.Message + Environment.NewLine + e.StackTrace);
				return;
			}

		}

		public static void LogBorradoArticulos(int intArticuloid, string module, string StrConnection)
		{
			string strQuery;
			if (!string.IsNullOrEmpty(module))
			{
				if (module == "Didi")
				{
					strQuery = @" 
							INSERT INTO [dbo].[LogProductosEliminado] (intArticuloid, tipoMP, iEliminado) 
							SELECT ";
					strQuery += intArticuloid.ToString() + ", 'Didi' , 0";
					SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
				}
				else if (module == "Rappi")
				{
					strQuery = @" 
							INSERT INTO [dbo].[LogProductosEliminado] (intArticuloid, tipoMP, iEliminado) 
							SELECT ";
					strQuery += intArticuloid.ToString() + ", 'Rappi' , 0";
					SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
				}
				else if (module == "Uber")
				{
					strQuery = @" 
							INSERT INTO [dbo].[LogProductosEliminado] (intArticuloid, tipoMP, iEliminado) 
							SELECT ";
					strQuery += intArticuloid.ToString() + ", 'Uber' , 0";
					SMPSQL.ExecuteNonQuery(strQuery, StrConnection);
				}

			}
		}

		public static DataSet GetArticulosEliminados(string module, string StrConnection)
		{
			DataSet ds = new DataSet();
			string strQuery;
			if (!string.IsNullOrEmpty(module))
			{
				strQuery = @" 
							select intArticuloid 
							from [dbo].[LogProductosMP] 
							where tipoMP = '";
				strQuery += module.ToString() + "'";
				strQuery += "and dtRegistro = (select max(dtRegistro) from [dbo].[LogProductosMP] where tipoMP = '";
				strQuery += module.ToString() + "') ";
				strQuery += "order by intArticuloid asc ";
				ds = SMPSQL.ExecuteDataSet(strQuery, StrConnection);
			}
			else
			{
				ds = null;
			}
			return ds;
		}
	}
}
