import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { OrdenesEcommerceRow } from "./OrdenesEcommerceRow";

export namespace OrdenesEcommerceService {
    export const baseUrl = 'Ecommerce/OrdenesEcommerce';

    export declare function Create(request: SaveRequest<OrdenesEcommerceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<OrdenesEcommerceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OrdenesEcommerceRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OrdenesEcommerceRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Ecommerce/OrdenesEcommerce/Create",
        Update: "Ecommerce/OrdenesEcommerce/Update",
        Delete: "Ecommerce/OrdenesEcommerce/Delete",
        Retrieve: "Ecommerce/OrdenesEcommerce/Retrieve",
        List: "Ecommerce/OrdenesEcommerce/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OrdenesEcommerceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}