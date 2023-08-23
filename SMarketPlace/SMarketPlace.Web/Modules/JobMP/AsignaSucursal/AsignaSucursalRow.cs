using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.JobMP;

[ConnectionKey("Default"), Module("JobMP"), TableName("FABEMPSUCURSAL")]
[DisplayName("Asigna Sucursal"), InstanceName("Asigna Sucursal")]
[ReadPermission(PermissionKeys.AsignaSucursal)]
[ModifyPermission(PermissionKeys.AsignaSucursal)]
public sealed class AsignaSucursalRow : Row<AsignaSucursalRow.RowFields>, IIdRow
{
    const string jIdSucursal = nameof(jIdSucursal);

    [DisplayName("Id Sucurasal Mp"), Column("idSucurasalMP"), Identity, IdProperty]
    public int? IdSucurasalMp
    {
        get => fields.IdSucurasalMp[this];
        set => fields.IdSucurasalMp[this] = value;
    }

    [DisplayName("Id Mp"), Column("idMP"), NotNull]
    public int? IdMp
    {
        get => fields.IdMp[this];
        set => fields.IdMp[this] = value;
    }

    [DisplayName("Id Sucursal"), Column("IDSucursal"), ForeignKey("tblSucursal", "IDSucursal"), LeftJoin(jIdSucursal), TextualField(nameof(IdSucursalLocalSap))]
    public int? IdSucursal
    {
        get => fields.IdSucursal[this];
        set => fields.IdSucursal[this] = value;
    }

    [DisplayName("Id Sucursal Local Sap"), Expression($"{jIdSucursal}.[LocalSap]")]
    public string IdSucursalLocalSap
    {
        get => fields.IdSucursalLocalSap[this];
        set => fields.IdSucursalLocalSap[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdSucurasalMp;
        public Int32Field IdMp;
        public Int32Field IdSucursal;

        public StringField IdSucursalLocalSap;
    }
}