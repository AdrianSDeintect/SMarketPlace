import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblSucursalDidiRow {
    LocalSap?: string;
    NombreSucursal?: string;
}

export abstract class TblSucursalDidiRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Sucursales.TblSucursalDidi';
    static readonly lookupKey = 'Sucursales.TblSucursalDidi';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblSucursalDidiRow>('Sucursales.TblSucursalDidi') }
    static async getLookupAsync() { return getLookupAsync<TblSucursalDidiRow>('Sucursales.TblSucursalDidi') }

    static readonly deletePermission = 'Sucursales:Didi';
    static readonly insertPermission = 'Sucursales:Didi';
    static readonly readPermission = 'Sucursales:Didi';
    static readonly updatePermission = 'Sucursales:Didi';

    static readonly Fields = fieldsProxy<TblSucursalDidiRow>();
}