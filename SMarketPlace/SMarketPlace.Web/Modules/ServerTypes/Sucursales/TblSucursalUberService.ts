import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, ServiceResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TblSucursalUberRow } from "./TblSucursalUberRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";
import { DeleteMultiRequest } from "./DeleteMultiRequest";

export namespace TblSucursalUberService {
    export const baseUrl = 'Sucursales/TblSucursalUber';

    export declare function Create(request: SaveRequest<TblSucursalUberRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TblSucursalUberRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TblSucursalUberRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TblSucursalUberRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteMulti(request: DeleteMultiRequest, onSuccess?: (response: ServiceResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Sucursales/TblSucursalUber/Create",
        Update: "Sucursales/TblSucursalUber/Update",
        Delete: "Sucursales/TblSucursalUber/Delete",
        Retrieve: "Sucursales/TblSucursalUber/Retrieve",
        List: "Sucursales/TblSucursalUber/List",
        ExcelImport: "Sucursales/TblSucursalUber/ExcelImport",
        DeleteMulti: "Sucursales/TblSucursalUber/DeleteMulti"
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
        (<any>TblSucursalUberService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}