using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMarketPlaceUtils.SQL
{
	public class SMPSQL
	{
		public const string SQLTimeOutConfig = "SQLTimeout";

		/// <summary>
		/// Ejecuta query, no regresa resultados
		/// </summary>
		public static void ExecuteNonQuery(string strQuery, string StrConnection, int? iTimeOut = null)
		{
			SMPSQLServer.ExecuteNonQuery(strQuery, StrConnection, iTimeOut);
		}
	}
}
