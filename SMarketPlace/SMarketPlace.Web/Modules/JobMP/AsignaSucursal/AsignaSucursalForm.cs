using Serenity.ComponentModel;

namespace SMarketPlace.JobMP.Forms;

[FormScript("JobMP.AsignaSucursal")]
[BasedOnRow(typeof(AsignaSucursalRow), CheckNames = true)]
public class AsignaSucursalForm
{
    public int IdMp { get; set; }
    public int IdSucursal { get; set; }
}