using System;
using System.Collections.Generic;
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
	}
}
