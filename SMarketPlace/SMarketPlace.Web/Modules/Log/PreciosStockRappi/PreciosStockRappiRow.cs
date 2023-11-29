using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace SMarketPlace.Log;

[ConnectionKey("Default"), Module("Log"), TableName("PreciosStockRappi")]
[DisplayName("Precios Stock Rappi"), InstanceName("Precios Stock Rappi")]
[ReadPermission(PermissionKeys.LogProcesos)]
[ModifyPermission(PermissionKeys.LogProcesos)]
public sealed class PreciosStockRappiRow : Row<PreciosStockRappiRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Intid"), Column("intid"), Identity, IdProperty]
    public int? Intid
    {
        get => fields.Intid[this];
        set => fields.Intid[this] = value;
    }

    [DisplayName("Id"), Column("id"), Size(10), NotNull, QuickSearch, NameProperty]
    public string Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Store Id"), Column("store_id"), Size(10), NotNull]
    public string StoreId
    {
        get => fields.StoreId[this];
        set => fields.StoreId[this] = value;
    }

    [DisplayName("Gtin"), Column("gtin"), Size(50)]
    public string Gtin
    {
        get => fields.Gtin[this];
        set => fields.Gtin[this] = value;
    }

    [DisplayName("Name"), Column("name"), Size(50)]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Price"), Column("price"), Size(10), Scale(4)]
    public decimal? Price
    {
        get => fields.Price[this];
        set => fields.Price[this] = value;
    }

    [DisplayName("Discount Price"), Column("discount_price"), Size(10), Scale(2)]
    public decimal? DiscountPrice
    {
        get => fields.DiscountPrice[this];
        set => fields.DiscountPrice[this] = value;
    }

    [DisplayName("Discount"), Column("discount"), Size(10), Scale(2)]
    public decimal? Discount
    {
        get => fields.Discount[this];
        set => fields.Discount[this] = value;
    }

    [DisplayName("Stock"), Column("stock")]
    public int? Stock
    {
        get => fields.Stock[this];
        set => fields.Stock[this] = value;
    }

    [DisplayName("Is Available"), Column("is_available"), Size(50)]
    public string IsAvailable
    {
        get => fields.IsAvailable[this];
        set => fields.IsAvailable[this] = value;
    }

    [DisplayName("Is Discontinued"), Column("is_discontinued"), Size(50)]
    public string IsDiscontinued
    {
        get => fields.IsDiscontinued[this];
        set => fields.IsDiscontinued[this] = value;
    }

    [DisplayName("Sale Type"), Column("sale_type"), Size(50)]
    public string SaleType
    {
        get => fields.SaleType[this];
        set => fields.SaleType[this] = value;
    }

    [DisplayName("Dt Registro"), Column("dtRegistro")]
    public DateTime? DtRegistro
    {
        get => fields.DtRegistro[this];
        set => fields.DtRegistro[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Intid;
        public StringField Id;
        public StringField StoreId;
        public StringField Gtin;
        public StringField Name;
        public DecimalField Price;
        public DecimalField DiscountPrice;
        public DecimalField Discount;
        public Int32Field Stock;
        public StringField IsAvailable;
        public StringField IsDiscontinued;
        public StringField SaleType;
        public DateTimeField DtRegistro;

    }
}