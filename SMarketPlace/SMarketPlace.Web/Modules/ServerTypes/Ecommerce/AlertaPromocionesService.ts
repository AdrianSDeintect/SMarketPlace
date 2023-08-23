import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { AlertaPromocionesRow } from "./AlertaPromocionesRow";

export namespace AlertaPromocionesService {
    export const baseUrl = 'Ecommerce/AlertaPromociones';

    export declare function Create(request: SaveRequest<AlertaPromocionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<AlertaPromocionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AlertaPromocionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AlertaPromocionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Ecommerce/AlertaPromociones/Create",
        Update: "Ecommerce/AlertaPromociones/Update",
        Delete: "Ecommerce/AlertaPromociones/Delete",
        Retrieve: "Ecommerce/AlertaPromociones/Retrieve",
        List: "Ecommerce/AlertaPromociones/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AlertaPromocionesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}