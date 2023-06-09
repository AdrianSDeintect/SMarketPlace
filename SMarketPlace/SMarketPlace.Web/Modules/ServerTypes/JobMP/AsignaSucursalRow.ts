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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AsignaSucursalRow>();
}