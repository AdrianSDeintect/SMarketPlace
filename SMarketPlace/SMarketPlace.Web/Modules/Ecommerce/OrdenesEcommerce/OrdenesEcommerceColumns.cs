using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Ecommerce.Columns;

[ColumnsScript("Ecommerce.OrdenesEcommerce")]
[BasedOnRow(typeof(OrdenesEcommerceRow), CheckNames = true)]
public class OrdenesEcommerceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Consecutivo { get; set; }
    [EditLink]
    public string IdPedidoEcommerce { get; set; }
    public string EstadoPedidoInternet { get; set; }
}