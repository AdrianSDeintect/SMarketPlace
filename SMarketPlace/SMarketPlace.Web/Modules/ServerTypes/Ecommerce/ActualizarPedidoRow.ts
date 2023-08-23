import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ActualizarPedidoRow {
    Intid?: number;
    IdPedidoEcommerce?: string;
    EstadoPedidoInternet?: string;
    Estado?: string;
    DtRegistroUsr?: string;
    DtCambio?: string;
}

export abstract class ActualizarPedidoRow {
    static readonly idProperty = 'Intid';
    static readonly nameProperty = 'IdPedidoEcommerce';
    static readonly localTextPrefix = 'Ecommerce.ActualizarPedido';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ActualizarPedidoRow>();
}