import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface OrdenesEcommerceRow {
    Consecutivo?: number;
    IdPedidoEcommerce?: string;
    EstadoPedidoInternet?: string;
}

export abstract class OrdenesEcommerceRow {
    static readonly idProperty = 'Consecutivo';
    static readonly nameProperty = 'IdPedidoEcommerce';
    static readonly localTextPrefix = 'Ecommerce.OrdenesEcommerce';
    static readonly lookupKey = 'Ecommerce.OrdenesEcommerce';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<OrdenesEcommerceRow>('Ecommerce.OrdenesEcommerce') }
    static async getLookupAsync() { return getLookupAsync<OrdenesEcommerceRow>('Ecommerce.OrdenesEcommerce') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<OrdenesEcommerceRow>();
}