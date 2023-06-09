﻿using System;
using System.Collections.Generic;
using System.Data;
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

		/// <summary>
		/// Ejecuta query, regresa dataset, si dataset no tiene tablas se regresa null
		/// </summary>
		public static DataSet ExecuteDataSet(string strQuery, string StrConnection, int? iTimeOut = null)
		{
			DataSet ds;
		
			ds = SMPSQLServer.ExecuteDataSet(strQuery, StrConnection, iTimeOut);

			return ds;
		}
	}
}
