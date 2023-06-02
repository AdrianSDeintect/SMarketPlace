using Serenity.ComponentModel;

namespace SMarketPlace.Sucursales.Forms;

[FormScript("Sucursales.TblSucursal")]
[BasedOnRow(typeof(TblSucursalRow), CheckNames = true)]
public class TblSucursalForm
{
    public string LocalSap { get; set; }
    public string NombreSuc { get; set; }
    public string Direccion { get; set; }
    public string Codigopostal { get; set; }
    public int Pais { get; set; }
    public int Ciudad { get; set; }
    public int Estado { get; set; }
    public int Region { get; set; }
    public int Zona { get; set; }
}