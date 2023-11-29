import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, ServiceResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TblproductosDidiRow } from "./TblproductosDidiRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { DeleteMultiRequest } from "./DeleteMultiRequest";

export namespace TblproductosDidiService {
    export const baseUrl = 'Productos/TblproductosDidi';

    export declare function Create(request: SaveRequest<TblproductosDidiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TblproductosDidiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TblproductosDidiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TblproductosDidiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteMulti(request: DeleteMultiRequest, onSuccess?: (response: ServiceResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Productos/TblproductosDidi/Create",
        Update: "Productos/TblproductosDidi/Update",
        Delete: "Productos/TblproductosDidi/Delete",
        Retrieve: "Productos/TblproductosDidi/Retrieve",
        List: "Productos/TblproductosDidi/List",
        ExcelImport: "Productos/TblproductosDidi/ExcelImport",
        DeleteMulti: "Productos/TblproductosDidi/DeleteMulti"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport', 
        'DeleteMulti'
    ].forEach(x => {
        (<any>TblproductosDidiService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}