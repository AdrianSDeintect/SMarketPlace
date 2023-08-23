using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace SMarketPlace.JobMP;

[ConnectionKey("Default"), Module("JobMP"), TableName("tblIntegrador")]
[DisplayName("Market Place"), InstanceName("Market Place")]
[ReadPermission(PermissionKeys.MarketPlace)]
[ModifyPermission(PermissionKeys.MarketPlace)]
public sealed class MarketPlaceRow : Row<MarketPlaceRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Idintegrador"), Column("idintegrador"), Identity, IdProperty]
    public int? Idintegrador
    {
        get => fields.Idintegrador[this];
        set => fields.Idintegrador[this] = value;
    }

    [DisplayName("Nombre"), Size(200), QuickSearch, NameProperty]
    public string Nombre
    {
        get => fields.Nombre[this];
        set => fields.Nombre[this] = value;
    }

    [DisplayName("Descripcion"), Column("descripcion"), Size(300)]
    public string Descripcion
    {
        get => fields.Descripcion[this];
        set => fields.Descripcion[this] = value;
    }

    [DisplayName("Activo")]
    public int? Activo
    {
        get => fields.Activo[this];
        set => fields.Activo[this] = value;
    }

    [DisplayName("Fecha Inicio")]
    public DateTime? FechaInicio
    {
        get => fields.FechaInicio[this];
        set => fields.FechaInicio[this] = value;
    }

    [DisplayName("Clase"), Size(200)]
    public string Clase
    {
        get => fields.Clase[this];
        set => fields.Clase[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Idintegrador;
        public StringField Nombre;
        public StringField Descripcion;
        public Int32Field Activo;
        public DateTimeField FechaInicio;
        public StringField Clase;

    }
}