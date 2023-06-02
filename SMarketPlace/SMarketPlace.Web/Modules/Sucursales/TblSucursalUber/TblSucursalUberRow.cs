using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.Sucursales;

[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Sucursales"), TableName("TBLSucursalUber")]
[DisplayName("Tbl Sucursal Uber"), InstanceName("Tbl Sucursal Uber")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class TblSucursalUberRow : Row<TblSucursalUberRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Column("LocalSAP"), Size(4), IdProperty, QuickSearch, NameProperty, ForeignKey("[dbo].[tblSucursal]", "LocalSap"), LeftJoin("jSucursales"), TextualField("NombreSuc")]
    [LookupEditor(typeof(TblSucursalRow))]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }
    [DisplayName("Nombre de Sucursal"), Expression("jSucursales.[NombreSuc]"), QuickSearch]
    [LookupEditor(typeof(TblSucursalRow))]
    public string NombreSucursal
    {
        get => fields.NombreSucursal[this];
        set => fields.NombreSucursal[this] = value;
    }
    public class RowFields : RowFieldsBase
    {
        public StringField LocalSap;
        public StringField NombreSucursal;

    }
    public bool TrackWithChecks { get; internal set; }
}