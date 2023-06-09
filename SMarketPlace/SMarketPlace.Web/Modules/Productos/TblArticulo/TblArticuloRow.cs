using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.Productos;

[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Productos"), TableName("tblArticulo")]
[DisplayName("Tbl Articulo"), InstanceName("Tbl Articulo")]
[ReadPermission(PermissionKeys.Productos)]
[ModifyPermission(PermissionKeys.Productos)]
public sealed class TblArticuloRow : Row<TblArticuloRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Sku"), Column("SKU"), PrimaryKey, NotNull, IdProperty]
    public int? Sku
    {
        get => fields.Sku[this];
        set => fields.Sku[this] = value;
    }

    [DisplayName("Nombrearticulo"), Column("NOMBREARTICULO"), Size(200), QuickSearch, NameProperty]
    public string Nombrearticulo
    {
        get => fields.Nombrearticulo[this];
        set => fields.Nombrearticulo[this] = value;
    }

    [DisplayName("Categorialealtad"), Column("CATEGORIALEALTAD")]
    public int? Categorialealtad
    {
        get => fields.Categorialealtad[this];
        set => fields.Categorialealtad[this] = value;
    }

    [DisplayName("Division"), Column("DIVISION"), Size(20)]
    public string Division
    {
        get => fields.Division[this];
        set => fields.Division[this] = value;
    }

    [DisplayName("Categoria"), Column("CATEGORIA"), Size(20)]
    public string Categoria
    {
        get => fields.Categoria[this];
        set => fields.Categoria[this] = value;
    }

    [DisplayName("Subcategoria"), Column("SUBCATEGORIA"), Size(20)]
    public string Subcategoria
    {
        get => fields.Subcategoria[this];
        set => fields.Subcategoria[this] = value;
    }

    [DisplayName("Grupo"), Column("GRUPO"), Size(20)]
    public string Grupo
    {
        get => fields.Grupo[this];
        set => fields.Grupo[this] = value;
    }

    [DisplayName("Proveedor"), Column("PROVEEDOR"), Size(20)]
    public string Proveedor
    {
        get => fields.Proveedor[this];
        set => fields.Proveedor[this] = value;
    }

    [DisplayName("Iva"), Column("IVA"), Size(18)]
    public decimal? Iva
    {
        get => fields.Iva[this];
        set => fields.Iva[this] = value;
    }

    [DisplayName("Codbar"), Column("CODBAR"), Size(30)]
    public string Codbar
    {
        get => fields.Codbar[this];
        set => fields.Codbar[this] = value;
    }

    [DisplayName("Parametro Producto"), Column("parametro_producto"), Size(30)]
    public string ParametroProducto
    {
        get => fields.ParametroProducto[this];
        set => fields.ParametroProducto[this] = value;
    }

    [DisplayName("Map Mod"), Column("map_mod"), Size(30)]
    public string MapMod
    {
        get => fields.MapMod[this];
        set => fields.MapMod[this] = value;
    }

    [DisplayName("Precio"), Column("precio"), Size(18)]
    public decimal? Precio
    {
        get => fields.Precio[this];
        set => fields.Precio[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Sku;
        public StringField Nombrearticulo;
        public Int32Field Categorialealtad;
        public StringField Division;
        public StringField Categoria;
        public StringField Subcategoria;
        public StringField Grupo;
        public StringField Proveedor;
        public DecimalField Iva;
        public StringField Codbar;
        public StringField ParametroProducto;
        public StringField MapMod;
        public DecimalField Precio;

    }
}