using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace SMarketPlace.JobMP;

[ConnectionKey("Default"), Module("JobMP"), TableName("FABEMP")]
[DisplayName("Job Sucursales"), InstanceName("Job Sucursales")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class JobSucursalesRow : Row<JobSucursalesRow.RowFields>, IIdRow, INameRow
{
    const string jIdMp = nameof(jIdMp);
    const string jIdintegrador = nameof(jIdintegrador);

    [DisplayName("Id Mp"), Column("idMP"), Identity, ForeignKey("FABEMP", "idMP"), LeftJoin(jIdMp), IdProperty, TextualField(nameof(IdMpNombreMp))]
    public int? IdMp
    {
        get => fields.IdMp[this];
        set => fields.IdMp[this] = value;
    }

    [DisplayName("Idintegrador"), Column("idintegrador"), NotNull, ForeignKey("tblIntegrador", "idintegrador"), LeftJoin(jIdintegrador), TextualField(nameof(IdintegradorNombre))]
    public int? Idintegrador
    {
        get => fields.Idintegrador[this];
        set => fields.Idintegrador[this] = value;
    }

    [DisplayName("Nombre Mp"), Column("NombreMP"), Size(200), QuickSearch, NameProperty]
    public string NombreMp
    {
        get => fields.NombreMp[this];
        set => fields.NombreMp[this] = value;
    }

    [DisplayName("Descripcion"), Column("descripcion"), Size(300)]
    public string Descripcion
    {
        get => fields.Descripcion[this];
        set => fields.Descripcion[this] = value;
    }

    [DisplayName("Dias"), Size(300)]
    public string Dias
    {
        get => fields.Dias[this];
        set => fields.Dias[this] = value;
    }

    [DisplayName("Hora"), Size(200)]
    public string Hora
    {
        get => fields.Hora[this];
        set => fields.Hora[this] = value;
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

    [DisplayName("Diario")]
    public int? Diario
    {
        get => fields.Diario[this];
        set => fields.Diario[this] = value;
    }

    [DisplayName("Id Mp Nombre Mp"), Expression($"{jIdMp}.[NombreMP]")]
    public string IdMpNombreMp
    {
        get => fields.IdMpNombreMp[this];
        set => fields.IdMpNombreMp[this] = value;
    }

    [DisplayName("Idintegrador Nombre"), Expression($"{jIdintegrador}.[Nombre]")]
    public string IdintegradorNombre
    {
        get => fields.IdintegradorNombre[this];
        set => fields.IdintegradorNombre[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdMp;
        public Int32Field Idintegrador;
        public StringField NombreMp;
        public StringField Descripcion;
        public StringField Dias;
        public StringField Hora;
        public Int32Field Activo;
        public DateTimeField FechaInicio;
        public Int32Field Diario;

        public StringField IdMpNombreMp;
        public StringField IdintegradorNombre;
    }
}