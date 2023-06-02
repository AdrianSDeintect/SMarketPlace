import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TblArticuloRow {
    Sku?: number;
    Nombrearticulo?: string;
    Categorialealtad?: number;
    Division?: string;
    Categoria?: string;
    Subcategoria?: string;
    Grupo?: string;
    Proveedor?: string;
    Iva?: number;
    Codbar?: string;
    ParametroProducto?: string;
    MapMod?: string;
    Precio?: number;
}

export abstract class TblArticuloRow {
    static readonly idProperty = 'Sku';
    static readonly nameProperty = 'Nombrearticulo';
    static readonly localTextPrefix = 'Productos.TblArticulo';
    static readonly lookupKey = 'Productos.TblArticulo';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TblArticuloRow>('Productos.TblArticulo') }
    static async getLookupAsync() { return getLookupAsync<TblArticuloRow>('Productos.TblArticulo') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TblArticuloRow>();
}