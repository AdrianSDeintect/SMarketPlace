using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Log.Columns;

[ColumnsScript("Log.PromosRappi")]
[BasedOnRow(typeof(PromosRappiRow), CheckNames = true)]
public class PromosRappiColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Consecutivo { get; set; }
    [EditLink]
    public string LocalSap { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string FormatDescription { get; set; }
    public string FormatDescriptionShort { get; set; }
        public string Name { get; set; }
    [QuickFilter]
    public int ProductId { get; set; }
}