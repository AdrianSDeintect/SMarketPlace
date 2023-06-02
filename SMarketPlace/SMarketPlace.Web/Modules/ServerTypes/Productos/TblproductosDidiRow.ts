import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblproductosDidiRow {
    IntArticuloid?: number;
    NombreArticulo?: string;
}

export abstract class TblproductosDidiRow {
    static readonly idProperty = 'IntArticuloid';
    static readonly nameProperty = 'IntArticuloid';
    static readonly localTextPrefix = 'Productos.TblproductosDidi';
    static readonly lookupKey = 'Productos.TblproductosDidi';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblproductosDidiRow>('Productos.TblproductosDidi') }
    static async getLookupAsync() { return getLookupAsync<TblproductosDidiRow>('Productos.TblproductosDidi') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TblproductosDidiRow>();
}