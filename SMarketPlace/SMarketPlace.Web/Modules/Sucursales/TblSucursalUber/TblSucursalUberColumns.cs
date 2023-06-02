using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Sucursales.Columns;

[ColumnsScript("Sucursales.TblSucursalUber")]
[BasedOnRow(typeof(TblSucursalUberRow), CheckNames = true)]
public class TblSucursalUberColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string NombreSucursal { get; set; }
}