import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblproductosUberRow {
    IntArticuloid?: number;
    NombreArticulo?: string;
}

export abstract class TblproductosUberRow {
    static readonly idProperty = 'IntArticuloid';
    static readonly nameProperty = 'IntArticuloid';
    static readonly localTextPrefix = 'Productos.TblproductosUber';
    static readonly lookupKey = 'Productos.TblproductosUber';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblproductosUberRow>('Productos.TblproductosUber') }
    static async getLookupAsync() { return getLookupAsync<TblproductosUberRow>('Productos.TblproductosUber') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TblproductosUberRow>();
}