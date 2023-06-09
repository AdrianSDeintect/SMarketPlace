import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblSucursalUberRow {
    LocalSap?: string;
    NombreSucursal?: string;
}

export abstract class TblSucursalUberRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Sucursales.TblSucursalUber';
    static readonly lookupKey = 'Sucursales.TblSucursalUber';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblSucursalUberRow>('Sucursales.TblSucursalUber') }
    static async getLookupAsync() { return getLookupAsync<TblSucursalUberRow>('Sucursales.TblSucursalUber') }

    static readonly deletePermission = 'Sucursales:Uber';
    static readonly insertPermission = 'Sucursales:Uber';
    static readonly readPermission = 'Sucursales:Uber';
    static readonly updatePermission = 'Sucursales:Uber';

    static readonly Fields = fieldsProxy<TblSucursalUberRow>();
}