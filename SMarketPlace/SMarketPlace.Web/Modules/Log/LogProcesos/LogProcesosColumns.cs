using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;

namespace SMarketPlace.Log.Columns;

[ColumnsScript("Log.LogProcesos")]
[BasedOnRow(typeof(LogProcesosRow), CheckNames = true)]
public class LogProcesosColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdLog { get; set; }
    [EditLink]
    public string Integrador { get; set; }
    public string Descripcion { get; set; }
    public string Proceso { get; set; }
    public StringField Activo { get; set; }
    public DateTime FechaInicio { get; set; }
}