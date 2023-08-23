import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { ActualizarPedidoRow } from "./ActualizarPedidoRow";

export namespace ActualizarPedidoService {
    export const baseUrl = 'Ecommerce/ActualizarPedido';

    export declare function Create(request: SaveRequest<ActualizarPedidoRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ActualizarPedidoRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ActualizarPedidoRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ActualizarPedidoRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Ecommerce/ActualizarPedido/Create",
        Update: "Ecommerce/ActualizarPedido/Update",
        Delete: "Ecommerce/ActualizarPedido/Delete",
        Retrieve: "Ecommerce/ActualizarPedido/Retrieve",
        List: "Ecommerce/ActualizarPedido/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ActualizarPedidoService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}