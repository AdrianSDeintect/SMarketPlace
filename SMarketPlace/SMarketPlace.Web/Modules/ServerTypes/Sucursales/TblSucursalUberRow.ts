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

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TblSucursalUberRow>();
}