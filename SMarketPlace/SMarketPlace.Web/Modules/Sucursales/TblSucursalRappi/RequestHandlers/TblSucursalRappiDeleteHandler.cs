using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalRappiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalRappiDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalRappiDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalRappiDeleteHandler
{
    public TblSucursalRappiDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}