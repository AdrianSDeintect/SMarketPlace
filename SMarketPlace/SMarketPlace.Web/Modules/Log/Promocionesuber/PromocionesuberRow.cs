using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.Log;

[ConnectionKey("Default"), Module("Log"), TableName("PROMOCIONESUBER")]
[DisplayName("Promocionesuber"), InstanceName("Promocionesuber")]
[ReadPermission(PermissionKeys.LogProcesos)]
[ModifyPermission(PermissionKeys.LogProcesos)]
public sealed class PromocionesuberRow : Row<PromocionesuberRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Consecutivo"), Identity, IdProperty]
    public int? Consecutivo
    {
        get => fields.Consecutivo[this];
        set => fields.Consecutivo[this] = value;
    }

    [DisplayName("Local Sap"), Column("localSAP"), Size(20), QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Start Date"), Column("start_date"), Size(30)]
    public string StartDate
    {
        get => fields.StartDate[this];
        set => fields.StartDate[this] = value;
    }

    [DisplayName("End Date"), Column("end_date"), Size(30)]
    public string EndDate
    {
        get => fields.EndDate[this];
        set => fields.EndDate[this] = value;
    }

    [DisplayName("Format Description"), Column("format_description")]
    public string FormatDescription
    {
        get => fields.FormatDescription[this];
        set => fields.FormatDescription[this] = value;
    }

    [DisplayName("Format Description Short"), Column("format_description_short")]
    public string FormatDescriptionShort
    {
        get => fields.FormatDescriptionShort[this];
        set => fields.FormatDescriptionShort[this] = value;
    }

    [DisplayName("Name"), Column("name")]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Product Id"), Column("product_id")]
    public int? ProductId
    {
        get => fields.ProductId[this];
        set => fields.ProductId[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Consecutivo;
        public StringField LocalSap;
        public StringField StartDate;
        public StringField EndDate;
        public StringField FormatDescription;
        public StringField FormatDescriptionShort;
        public StringField Name;
        public Int32Field ProductId;

    }
}