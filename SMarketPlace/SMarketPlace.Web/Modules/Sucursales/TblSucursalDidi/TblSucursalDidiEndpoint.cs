using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using SMarketPlace.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = SMarketPlace.Sucursales.TblSucursalDidiRow;
using SMarketPlaceUtils;

namespace SMarketPlace.Sucursales.Endpoints;

[Route("Services/Sucursales/TblSucursalDidi/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class TblSucursalDidiEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ITblSucursalDidiSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ITblSucursalDidiSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] ITblSucursalDidiDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] ITblSucursalDidiRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] ITblSucursalDidiListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] ITblSucursalDidiListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.TblSucursalDidiColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "TblSucursalDidiList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request, [FromServices] IUploadStorage uploadStorage, [FromServices] TblSucursalDidiSaveHandler handler)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.FileName)) throw new ArgumentNullException(nameof(request.FileName));
        if (uploadStorage is null) throw new ArgumentNullException(nameof(uploadStorage));
        UploadPathHelper.CheckFileNameSecurity(request.FileName);

        if (!request.FileName.StartsWith("temporary/"))
            throw new ArgumentOutOfRangeException("filename");

        ExcelPackage ep = new ExcelPackage();
        using (var fs = uploadStorage.OpenFile(request.FileName))
            ep.Load(fs);

        var p = MyRow.Fields;

        var response = new ExcelImportResponse();
        response.ErrorList = new List<string>();

        var worksheet = ep.Workbook.Worksheets[0];
        var tblHeaders = getCurrentTableHeaders();//Headers of current Table. 


        List<string> wsHeaders = new List<string>();
        foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
        {
            wsHeaders.Add(cell.Value.ToString());
        }
        List<int> columnNameCol = new List<int>();

        columnNameCol.Add(1);
        if (worksheet.Dimension.End.Row >= 2)
        {

            ProcesosDB.ProcesoBarridoYLogSucursales("TBLSucursalDidi", "Didi");
        }
        for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
        {
            try
            {
                var Exits = true;
                var lineIDCol = columnNameCol[0];
                var LocalSap = Convert.ToString(worksheet.Cells[row, lineIDCol].Value ?? "");
                var pName = Convert.ToString(LocalSap);

                if (pName.IsTrimmedEmpty())
                    continue;

                var product = uow.Connection.TryFirst<MyRow>(q => q.Select(p.LocalSap).Where(p.LocalSap == LocalSap ));

                if (product == null)
                {
                    Exits = false;
                    product = new MyRow
                    {
                        LocalSap = LocalSap.ToString()
                    };

                }
                else
                {
                    Exits = true;
                    // avoid assignment errors
                    product.TrackWithChecks = false;
                }

                var cCol = columnNameCol[0]; //row on Excel Sheet with joined field;                    
                var cID = TblSucursalDidiRow.Fields.LocalSap; //id on secondary table
                                                                    //var cName = SupplierRow.Fields.CompanyName; //field being checked on secondary table
                var catName = Convert.ToString(worksheet.Cells[row, cCol].Value ?? "");//value from Excel in specific column  where second table joins.
                var mainID = product.LocalSap; //int designation on current row

                if (Exits == false)
                {

                    handler.Create(uow, new SaveWithLocalizationRequest<MyRow>
                    {
                        Entity = product,
                    });

                    response.Inserted = response.Inserted + 1;
                }
                else
                {
                    handler.Update(uow, new SaveWithLocalizationRequest<MyRow>
                    {
                        Entity = product,
                        EntityId = product.LocalSap.Trim()
                    });

                    response.Updated = response.Updated + 1;
                }
                cCol = 0;
                cID = null;
                catName = null;
                mainID = null;


            }
            catch (Exception ex)
            {
                response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
            }
        }

        return response;
    }
    public static List<ReportColumn> getCurrentTableHeaders()
    {
        var column = new ReportColumn();
        column.Name = "ID";
        column.Title = "ID";
        List<ReportColumn> lst = new List<ReportColumn>();
        lst.Add(column);
        //add logic


        return lst;
    }

    public class DeleteMultiRequest : ServiceRequest
    {
        public List<string> Ids { get; set; }
    }

    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public ServiceResponse DeleteMulti(IUnitOfWork uow, DeleteMultiRequest request, [FromServices] ITblSucursalDidiDeleteHandler handler)
    {
        request.Ids.ForEach(v =>
        {
            handler.Delete(uow, new DeleteRequest() { EntityId = v });

            //return handler.Delete(uow, request);
        });

        return new ServiceResponse();
    }
}