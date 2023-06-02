import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, ServiceResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TblSucursalRappiRow } from "./TblSucursalRappiRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { DeleteMultiRequest } from "./DeleteMultiRequest";

export namespace TblSucursalRappiService {
    export const baseUrl = 'Sucursales/TblSucursalRappi';

    export declare function Create(request: SaveRequest<TblSucursalRappiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TblSucursalRappiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TblSucursalRappiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TblSucursalRappiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteMulti(request: DeleteMultiRequest, onSuccess?: (response: ServiceResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Sucursales/TblSucursalRappi/Create",
        Update: "Sucursales/TblSucursalRappi/Update",
        Delete: "Sucursales/TblSucursalRappi/Delete",
        Retrieve: "Sucursales/TblSucursalRappi/Retrieve",
        List: "Sucursales/TblSucursalRappi/List",
        ExcelImport: "Sucursales/TblSucursalRappi/ExcelImport",
        DeleteMulti: "Sucursales/TblSucursalRappi/DeleteMulti"
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
        (<any>TblSucursalRappiService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}