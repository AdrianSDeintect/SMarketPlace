using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;


namespace SMarketPlace.Log;

[ConnectionKey("Default"), Module("Log"), TableName("LogProcesos")]
[DisplayName("Log Procesos"), InstanceName("Log Procesos")]
//[ReadPermission("Administration:General")]
//[ModifyPermission("Administration:General")]
[ReadPermission(PermissionKeys.LogProcesos)]
[ModifyPermission(PermissionKeys.LogProcesos)]
public sealed class LogProcesosRow : Row<LogProcesosRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Log"), Column("idLog"), Identity, IdProperty]
    public int? IdLog
    {
        get => fields.IdLog[this];
        set => fields.IdLog[this] = value;
    }

    [DisplayName("Integrador"), Size(200), QuickSearch, NameProperty]
    public string Integrador
    {
        get => fields.Integrador[this];
        set => fields.Integrador[this] = value;
    }

    [DisplayName("Descripcion"), Column("descripcion"), Size(300)]
    public string Descripcion
    {
        get => fields.Descripcion[this];
        set => fields.Descripcion[this] = value;
    }

    [DisplayName("Proceso") ]
    [TextAreaEditor(Rows = 8)]
    public string Proceso
    {
        get => fields.Proceso[this];
        set => fields.Proceso[this] = value;
    }

    [DisplayName("Activo")]
    public string Activo
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

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdLog;
        public StringField Integrador;
        public StringField Descripcion;
        public StringField Proceso;
        public StringField Activo;
        public DateTimeField FechaInicio;

    }
}