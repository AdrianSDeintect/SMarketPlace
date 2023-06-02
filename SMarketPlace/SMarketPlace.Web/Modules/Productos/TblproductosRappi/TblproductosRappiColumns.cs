using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Productos.Columns;

[ColumnsScript("Productos.TblproductosRappi")]
[BasedOnRow(typeof(TblproductosRappiRow), CheckNames = true)]
public class TblproductosRappiColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IntArticuloid { get; set; }
    //[EditLink]
    //public string StrDivision { get; set; }
    //public string StrCategoria { get; set; }
    //public string StrSubCat { get; set; }
    //public string StrGrupo { get; set; }
    //public string StrUpc { get; set; }
    //public string StrMarca { get; set; }
    //public string StrNombre { get; set; }
    //public string StrFormato { get; set; }
    //public string Strimagen { get; set; }
    public string NombreArticulo { get; set; }
}