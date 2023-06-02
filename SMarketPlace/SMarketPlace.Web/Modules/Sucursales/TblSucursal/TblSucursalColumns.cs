using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Sucursales.Columns;

[ColumnsScript("Sucursales.TblSucursal")]
[BasedOnRow(typeof(TblSucursalRow), CheckNames = true)]
public class TblSucursalColumns
{
    [EditLink]
    public string LocalSap { get; set; }
    public string NombreSuc { get; set; }
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdSucursal { get; set; }
    public string Direccion { get; set; }
    public string Codigopostal { get; set; }
    public int Pais { get; set; }
    public int Ciudad { get; set; }
    public int Estado { get; set; }
    public int Region { get; set; }
    public int Zona { get; set; }
}