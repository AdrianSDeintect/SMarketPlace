using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Sucursales.TblSucursalRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalRetrieveHandler
{
    public TblSucursalRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}