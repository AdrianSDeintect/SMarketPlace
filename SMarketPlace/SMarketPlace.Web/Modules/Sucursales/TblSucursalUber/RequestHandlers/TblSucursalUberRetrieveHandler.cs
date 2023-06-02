using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Sucursales.TblSucursalUberRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalUberRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalUberRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalUberRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalUberRetrieveHandler
{
    public TblSucursalUberRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}