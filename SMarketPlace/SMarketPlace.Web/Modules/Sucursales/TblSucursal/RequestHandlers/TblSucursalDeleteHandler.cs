using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalDeleteHandler
{
    public TblSucursalDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}