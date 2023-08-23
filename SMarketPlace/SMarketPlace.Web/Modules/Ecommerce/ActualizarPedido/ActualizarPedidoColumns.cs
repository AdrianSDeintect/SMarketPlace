using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SMarketPlace.Ecommerce.Columns;

[ColumnsScript("Ecommerce.ActualizarPedido")]
[BasedOnRow(typeof(ActualizarPedidoRow), CheckNames = true)]
public class ActualizarPedidoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Intid { get; set; }
    [EditLink]
    public string IdPedidoEcommerce { get; set; }
    public string EstadoPedidoInternet { get; set; }
    public string Estado { get; set; }
    public DateTime DtRegistroUsr { get; set; }
    public DateTime DtCambio { get; set; }
}