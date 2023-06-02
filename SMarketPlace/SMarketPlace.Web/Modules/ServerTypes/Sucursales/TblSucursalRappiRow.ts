import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblSucursalRappiRow {
    LocalSap?: string;
    NombreSucursal?: string;
}

export abstract class TblSucursalRappiRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Sucursales.TblSucursalRappi';
    static readonly lookupKey = 'Sucursales.TblSucursalRappi';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblSucursalRappiRow>('Sucursales.TblSucursalRappi') }
    static async getLookupAsync() { return getLookupAsync<TblSucursalRappiRow>('Sucursales.TblSucursalRappi') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TblSucursalRappiRow>();
}