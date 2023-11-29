using Serenity.ComponentModel;
using System;

namespace SMarketPlace.Log.Forms;

[FormScript("Log.LogProcesos")]
[BasedOnRow(typeof(LogProcesosRow), CheckNames = true)]
public class LogProcesosForm
{
    [Updatable(false)]
    public string Integrador { get; set; }
    [Updatable(false)]
    public string Descripcion { get; set; }
    [Updatable(false)]
    public string Proceso { get; set; }
    [Updatable(false)]
    public int Activo { get; set; }
    [Updatable(false)]
    public DateTime FechaInicio { get; set; }
}