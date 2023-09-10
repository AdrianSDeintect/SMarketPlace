using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.Ecommerce;

[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Ecommerce"), TableName("OrdenesEcommerce")]
[DisplayName("Ordenes Ecommerce"), InstanceName("Ordenes Ecommerce")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class OrdenesEcommerceRow : Row<OrdenesEcommerceRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Consecutivo"), Identity, IdProperty]
    public int? Consecutivo
    {
        get => fields.Consecutivo[this];
        set => fields.Consecutivo[this] = value;
    }

    [DisplayName("Id Pedido Ecommerce"), Column("idPedidoEcommerce"), Size(10), NotNull, QuickSearch, NameProperty]
    public string IdPedidoEcommerce
    {
        get => fields.IdPedidoEcommerce[this];
        set => fields.IdPedidoEcommerce[this] = value;
    }

    [DisplayName("Estado Pedido Internet"), Column("estado_pedido_internet"), Size(10), NotNull]
    public string EstadoPedidoInternet
    {
        get => fields.EstadoPedidoInternet[this];
        set => fields.EstadoPedidoInternet[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Consecutivo;
        public StringField IdPedidoEcommerce;
        public StringField EstadoPedidoInternet;

    }
}