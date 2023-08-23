import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AsignaSucursalRow {
    IdSucurasalMp?: number;
    IdMp?: number;
    IdSucursal?: number;
    IdSucursalLocalSap?: string;
}

export abstract class AsignaSucursalRow {
    static readonly idProperty = 'IdSucurasalMp';
    static readonly localTextPrefix = 'JobMP.AsignaSucursal';
    static readonly deletePermission = 'MP.AsignaSucursal';
    static readonly insertPermission = 'MP.AsignaSucursal';
    static readonly readPermission = 'MP.AsignaSucursal';
    static readonly updatePermission = 'MP.AsignaSucursal';

    static readonly Fields = fieldsProxy<AsignaSucursalRow>();
}