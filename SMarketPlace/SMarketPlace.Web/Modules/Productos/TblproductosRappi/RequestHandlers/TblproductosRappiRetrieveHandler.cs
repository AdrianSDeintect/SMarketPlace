using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Productos.TblproductosRappiRow>;
using MyRow = SMarketPlace.Productos.TblproductosRappiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosRappiRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosRappiRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosRappiRetrieveHandler
{
    public TblproductosRappiRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}