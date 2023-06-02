import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, ServiceResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TblproductosRappiRow } from "./TblproductosRappiRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { DeleteMultiRequest } from "./DeleteMultiRequest";

export namespace TblproductosRappiService {
    export const baseUrl = 'Productos/TblproductosRappi';

    export declare function Create(request: SaveRequest<TblproductosRappiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TblproductosRappiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TblproductosRappiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TblproductosRappiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteMulti(request: DeleteMultiRequest, onSuccess?: (response: ServiceResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Productos/TblproductosRappi/Create",
        Update: "Productos/TblproductosRappi/Update",
        Delete: "Productos/TblproductosRappi/Delete",
        Retrieve: "Productos/TblproductosRappi/Retrieve",
        List: "Productos/TblproductosRappi/List",
        ExcelImport: "Productos/TblproductosRappi/ExcelImport",
        DeleteMulti: "Productos/TblproductosRappi/DeleteMulti"
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
        (<any>TblproductosRappiService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}