using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.Sucursales;

[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Sucursales"), TableName("tblSucursal")]
[DisplayName("Tbl Sucursal"), InstanceName("Tbl Sucursal")]
[ReadPermission(PermissionKeys.Sucursales)]
[ModifyPermission(PermissionKeys.Sucursales)]
public sealed class TblSucursalRow : Row<TblSucursalRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(50), NotNull, QuickSearch, NameProperty, IdProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Nombre Suc"), Size(80)]
    public string NombreSuc
    {
        get => fields.NombreSuc[this];
        set => fields.NombreSuc[this] = value;
    }

    [DisplayName("Id Sucursal"), Column("IDSucursal"), PrimaryKey, NotNull]
    public int? IdSucursal
    {
        get => fields.IdSucursal[this];
        set => fields.IdSucursal[this] = value;
    }

    [DisplayName("Direccion"), Column("DIRECCION"), Size(120)]
    public string Direccion
    {
        get => fields.Direccion[this];
        set => fields.Direccion[this] = value;
    }

    [DisplayName("Codigopostal"), Column("CODIGOPOSTAL"), Size(10)]
    public string Codigopostal
    {
        get => fields.Codigopostal[this];
        set => fields.Codigopostal[this] = value;
    }

    [DisplayName("Pais"), Column("PAIS")]
    public int? Pais
    {
        get => fields.Pais[this];
        set => fields.Pais[this] = value;
    }

    [DisplayName("Ciudad"), Column("CIUDAD")]
    public int? Ciudad
    {
        get => fields.Ciudad[this];
        set => fields.Ciudad[this] = value;
    }

    [DisplayName("Estado"), Column("ESTADO")]
    public int? Estado
    {
        get => fields.Estado[this];
        set => fields.Estado[this] = value;
    }

    [DisplayName("Region"), Column("REGION")]
    public int? Region
    {
        get => fields.Region[this];
        set => fields.Region[this] = value;
    }

    [DisplayName("Zona"), Column("ZONA")]
    public int? Zona
    {
        get => fields.Zona[this];
        set => fields.Zona[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public StringField LocalSap;
        public StringField NombreSuc;
        public Int32Field IdSucursal;
        public StringField Direccion;
        public StringField Codigopostal;
        public Int32Field Pais;
        public Int32Field Ciudad;
        public Int32Field Estado;
        public Int32Field Region;
        public Int32Field Zona;

    }
}