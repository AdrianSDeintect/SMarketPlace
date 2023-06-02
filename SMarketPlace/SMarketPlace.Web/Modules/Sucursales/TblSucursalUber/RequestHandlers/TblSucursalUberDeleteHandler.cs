using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalUberRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalUberDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalUberDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalUberDeleteHandler
{
    public TblSucursalUberDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}