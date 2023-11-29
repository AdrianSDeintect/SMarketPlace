import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, ServiceResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TblSucursalDidiRow } from "./TblSucursalDidiRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { DeleteMultiRequest } from "./DeleteMultiRequest";

export namespace TblSucursalDidiService {
    export const baseUrl = 'Sucursales/TblSucursalDidi';

    export declare function Create(request: SaveRequest<TblSucursalDidiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TblSucursalDidiRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TblSucursalDidiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TblSucursalDidiRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteMulti(request: DeleteMultiRequest, onSuccess?: (response: ServiceResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Sucursales/TblSucursalDidi/Create",
        Update: "Sucursales/TblSucursalDidi/Update",
        Delete: "Sucursales/TblSucursalDidi/Delete",
        Retrieve: "Sucursales/TblSucursalDidi/Retrieve",
        List: "Sucursales/TblSucursalDidi/List",
        ExcelImport: "Sucursales/TblSucursalDidi/ExcelImport",
        DeleteMulti: "Sucursales/TblSucursalDidi/DeleteMulti"
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
        (<any>TblSucursalDidiService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}