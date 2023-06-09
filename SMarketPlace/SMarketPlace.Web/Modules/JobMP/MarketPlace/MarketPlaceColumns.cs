using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SMarketPlace.JobMP.Columns;

[ColumnsScript("JobMP.MarketPlace")]
[BasedOnRow(typeof(MarketPlaceRow), CheckNames = true)]
public class MarketPlaceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Idintegrador { get; set; }
    [EditLink]
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Activo { get; set; }
    public DateTime FechaInicio { get; set; }
    public string Clase { get; set; }
}