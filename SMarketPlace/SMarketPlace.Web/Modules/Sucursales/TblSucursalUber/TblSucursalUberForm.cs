using Serenity.ComponentModel;

namespace SMarketPlace.Sucursales.Forms;

[FormScript("Sucursales.TblSucursalUber")]
[BasedOnRow(typeof(TblSucursalUberRow), CheckNames = true)]
public class TblSucursalUberForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
}