using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SMarketPlace.Productos;
using System;
using System.ComponentModel;

namespace SMarketPlace.Ecommerce;

[ConnectionKey("Default"), Module("Ecommerce"), TableName("PedidosEcommerce")]
[DisplayName("Actualizar Pedido"), InstanceName("Actualizar Pedido")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ActualizarPedidoRow : Row<ActualizarPedidoRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Intid"), Column("intid"), Identity, IdProperty]
    public int? Intid
    {
        get => fields.Intid[this];
        set => fields.Intid[this] = value;
    }

    [EditLink]
    [LookupEditor(typeof(OrdenesEcommerceRow))]
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

    [DisplayName("Estado"), Size(50)]
    public string Estado
    {
        get => fields.Estado[this];
        set => fields.Estado[this] = value;
    }

    [DisplayName("Dt Registro Usr"), Column("dtRegistroUsr")]
    public DateTime? DtRegistroUsr
    {
        get => fields.DtRegistroUsr[this];
        set => fields.DtRegistroUsr[this] = value;
    }

    [DisplayName("Dt Cambio"), Column("dtCambio")]
    public DateTime? DtCambio
    {
        get => fields.DtCambio[this];
        set => fields.DtCambio[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Intid;
        public StringField IdPedidoEcommerce;
        public StringField EstadoPedidoInternet;
        public StringField Estado;
        public DateTimeField DtRegistroUsr;
        public DateTimeField DtCambio;

    }
}