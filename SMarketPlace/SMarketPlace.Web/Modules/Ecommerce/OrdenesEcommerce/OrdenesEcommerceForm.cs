using Serenity.ComponentModel;

namespace SMarketPlace.Ecommerce.Forms;

[FormScript("Ecommerce.OrdenesEcommerce")]
[BasedOnRow(typeof(OrdenesEcommerceRow), CheckNames = true)]
public class OrdenesEcommerceForm
{
    public string IdPedidoEcommerce { get; set; }
    public string EstadoPedidoInternet { get; set; }
}