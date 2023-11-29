using Serenity.ComponentModel;
using System;

namespace SMarketPlace.Log.Forms;

[FormScript("Log.PreciosStockUber")]
[BasedOnRow(typeof(PreciosStockUberRow), CheckNames = true)]
public class PreciosStockUberForm
{
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