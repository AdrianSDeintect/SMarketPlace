﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblSucursalRow {
    LocalSap?: string;
    NombreSuc?: string;
    IdSucursal?: number;
    Direccion?: string;
    Codigopostal?: string;
    Pais?: number;
    Ciudad?: number;
    Estado?: number;
    Region?: number;
    Zona?: number;
}

export abstract class TblSucursalRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Sucursales.TblSucursal';
    static readonly lookupKey = 'Sucursales.TblSucursal';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblSucursalRow>('Sucursales.TblSucursal') }
    static async getLookupAsync() { return getLookupAsync<TblSucursalRow>('Sucursales.TblSucursal') }

    static readonly deletePermission = 'Sucursales';
    static readonly insertPermission = 'Sucursales';
    static readonly readPermission = 'Sucursales';
    static readonly updatePermission = 'Sucursales';

    static readonly Fields = fieldsProxy<TblSucursalRow>();
}