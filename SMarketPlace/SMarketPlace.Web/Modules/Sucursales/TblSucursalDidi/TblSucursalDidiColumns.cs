using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Sucursales.Columns;

[ColumnsScript("Sucursales.TblSucursalDidi")]
[BasedOnRow(typeof(TblSucursalDidiRow), CheckNames = true)]
public class TblSucursalDidiColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string NombreSucursal { get; set; }
}