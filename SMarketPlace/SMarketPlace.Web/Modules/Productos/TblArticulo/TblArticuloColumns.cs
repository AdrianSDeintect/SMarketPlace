using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Productos.Columns;

[ColumnsScript("Productos.TblArticulo")]
[BasedOnRow(typeof(TblArticuloRow), CheckNames = true)]
public class TblArticuloColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Sku { get; set; }
    [EditLink]
    public string Nombrearticulo { get; set; }
    public int Categorialealtad { get; set; }
    public string Division { get; set; }
    public string Categoria { get; set; }
    public string Subcategoria { get; set; }
    public string Grupo { get; set; }
    public string Proveedor { get; set; }
    public decimal Iva { get; set; }
    public string Codbar { get; set; }
    public string ParametroProducto { get; set; }
    public string MapMod { get; set; }
    public decimal Precio { get; set; }
}