import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblproductosRappiRow {
    IntArticuloid?: number;
    NombreArticulo?: string;
}

export abstract class TblproductosRappiRow {
    static readonly idProperty = 'IntArticuloid';
    static readonly nameProperty = 'IntArticuloid';
    static readonly localTextPrefix = 'Productos.TblproductosRappi';
    static readonly lookupKey = 'Productos.TblproductosRappi';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblproductosRappiRow>('Productos.TblproductosRappi') }
    static async getLookupAsync() { return getLookupAsync<TblproductosRappiRow>('Productos.TblproductosRappi') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TblproductosRappiRow>();
}