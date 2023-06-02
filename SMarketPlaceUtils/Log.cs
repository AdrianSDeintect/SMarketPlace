using log4net;
using System;
using System.Diagnostics;

namespace SMarketPlaceUtils
{
	public class Log
	{

		public enum LogType
		{
			Error = 0,
			Warning,
			Info
		}

		/// <summary>
		/// Escribe en Log el mensaje que se envie, por default el tipo de mensaje es Error
		/// Se requiere configurar el nodo log4net en la aplicacion final
		/// </summary>
		public static void Write(string strMessage, LogType ltType = 0, Exception e = null)
		{
			StackTrace stackTrace = new StackTrace();
			ILog log = LogManager.GetLogger(stackTrace.GetFrame(1).GetMethod().DeclaringType.Name);

			string strSeparador = new string('=', 100);
			switch (ltType)
			{
				case LogType.Error:
					log.Error(strSeparador.Insert(10, "Init Error").Substring(0, 100));
					log.Error("\t" + strMessage);
					if (e != null)
					{
						log.Error(e.Message);
						log.Error(e.StackTrace);
					}
					log.Error(strSeparador.Insert(10, "End Error").Substring(0, 100));
					break;
				case LogType.Warning:
					log.Warn(strSeparador.Insert(10, "Init Warning").Substring(0, 100));
					log.Warn("\t" + strMessage);
					if (e != null)
					{
						log.Warn(e.Message);
						log.Warn(e.StackTrace);
					}
					log.Warn(strSeparador.Insert(10, "End Warning").Substring(0, 100));
					break;
				case LogType.Info:
					log.Info(strSeparador.Insert(10, "Init Info").Substring(0, 100));
					log.Info("\t" + strMessage);
					if (e != null)
					{
						log.Info(e.Message);
						log.Info(e.StackTrace);
					}
					log.Info(strSeparador.Insert(10, "End Info").Substring(0, 100));
					break;
				default:
					break;
			}
		}

		public static void WriteLine(string strMessage, LogType LogType = 0)
		{
			StackTrace stackTrace = new StackTrace();
			ILog log = LogManager.GetLogger(stackTrace.GetFrame(1).GetMethod().DeclaringType.Name);

			switch (LogType)
			{
				case LogType.Error:
					log.Error("Error: " + strMessage);
					break;
				case LogType.Warning:
					log.Warn("Warning: " + strMessage);
					break;
				case LogType.Info:
					log.Info("Info: " + strMessage);
					break;
				default:
					break;
			}
		}
	}
}
