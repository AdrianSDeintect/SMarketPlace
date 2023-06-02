using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Sucursales.TblSucursalRappiRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalRappiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalRappiRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalRappiRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalRappiRetrieveHandler
{
    public TblSucursalRappiRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}