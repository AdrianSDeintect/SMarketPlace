import { fieldsProxy } from "@serenity-is/corelib/q";

export interface JobSucursalesRow {
    IdMp?: number;
    Idintegrador?: number;
    NombreMp?: string;
    Descripcion?: string;
    Dias?: string;
    Hora?: string;
    Activo?: number;
    FechaInicio?: string;
    Diario?: number;
    IdMpNombreMp?: string;
    IdintegradorNombre?: string;
}

export abstract class JobSucursalesRow {
    static readonly idProperty = 'IdMp';
    static readonly nameProperty = 'NombreMp';
    static readonly localTextPrefix = 'JobMP.JobSucursales';
    static readonly deletePermission = 'MP:JobSucursales';
    static readonly insertPermission = 'MP:JobSucursales';
    static readonly readPermission = 'MP:JobSucursales';
    static readonly updatePermission = 'MP:JobSucursales';

    static readonly Fields = fieldsProxy<JobSucursalesRow>();
}