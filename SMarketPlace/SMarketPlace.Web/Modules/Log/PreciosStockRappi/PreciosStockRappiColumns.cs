using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SMarketPlace.Log.Columns;

[ColumnsScript("Log.PreciosStockRappi")]
[BasedOnRow(typeof(PreciosStockRappiRow), CheckNames = true)]
public class PreciosStockRappiColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Intid { get; set; }
    [EditLink]
    public string Id { get; set; }
    public string StoreId { get; set; }
    public string Gtin { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public decimal Discount { get; set; }
    public int Stock { get; set; }
    public string IsAvailable { get; set; }
    public string IsDiscontinued { get; set; }
    public string SaleType { get; set; }
    public DateTime DtRegistro { get; set; }
}