using Serenity.ComponentModel;
using System;

namespace SMarketPlace.JobMP.Forms;

[FormScript("JobMP.MarketPlace")]
[BasedOnRow(typeof(MarketPlaceRow), CheckNames = true)]
public class MarketPlaceForm
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Activo { get; set; }
    public DateTime FechaInicio { get; set; }
    public string Clase { get; set; }
}