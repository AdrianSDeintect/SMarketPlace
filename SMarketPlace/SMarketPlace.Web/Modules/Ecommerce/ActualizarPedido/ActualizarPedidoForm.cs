using Serenity.ComponentModel;
using System;

namespace SMarketPlace.Ecommerce.Forms;

[FormScript("Ecommerce.ActualizarPedido")]
[BasedOnRow(typeof(ActualizarPedidoRow), CheckNames = true)]
public class ActualizarPedidoForm
{
    public string IdPedidoEcommerce { get; set; }
    public string EstadoPedidoInternet { get; set; }
    public string Estado { get; set; }
    public DateTime DtRegistroUsr { get; set; }
    public DateTime DtCambio { get; set; }
}