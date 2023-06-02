using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Sucursales.TblSucursalDidiRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalDidiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalDidiRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalDidiRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalDidiRetrieveHandler
{
    public TblSucursalDidiRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}