using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.JobMP.Columns;

[ColumnsScript("JobMP.AsignaSucursal")]
[BasedOnRow(typeof(AsignaSucursalRow), CheckNames = true)]
public class AsignaSucursalColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdSucurasalMp { get; set; }
    public int IdMp { get; set; }
    public string IdSucursalLocalSap { get; set; }
}