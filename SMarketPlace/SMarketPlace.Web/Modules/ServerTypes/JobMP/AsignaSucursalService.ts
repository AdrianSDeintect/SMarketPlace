import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { AsignaSucursalRow } from "./AsignaSucursalRow";

export namespace AsignaSucursalService {
    export const baseUrl = 'JobMP/AsignaSucursal';

    export declare function Create(request: SaveRequest<AsignaSucursalRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<AsignaSucursalRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AsignaSucursalRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AsignaSucursalRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "JobMP/AsignaSucursal/Create",
        Update: "JobMP/AsignaSucursal/Update",
        Delete: "JobMP/AsignaSucursal/Delete",
        Retrieve: "JobMP/AsignaSucursal/Retrieve",
        List: "JobMP/AsignaSucursal/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AsignaSucursalService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}