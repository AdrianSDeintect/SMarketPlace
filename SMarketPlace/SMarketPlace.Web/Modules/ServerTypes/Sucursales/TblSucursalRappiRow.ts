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

    static readonly deletePermission = 'Sucursales:Rappi';
    static readonly insertPermission = 'Sucursales:Rappi';
    static readonly readPermission = 'Sucursales:Rappi';
    static readonly updatePermission = 'Sucursales:Rappi';

    static readonly Fields = fieldsProxy<TblSucursalRappiRow>();
}