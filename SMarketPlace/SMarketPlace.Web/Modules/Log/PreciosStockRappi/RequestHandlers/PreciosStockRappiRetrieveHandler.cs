using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Log.PreciosStockRappiRow>;
using MyRow = SMarketPlace.Log.PreciosStockRappiRow;

namespace SMarketPlace.Log;

public interface IPreciosStockRappiRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockRappiRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockRappiRetrieveHandler
{
    public PreciosStockRappiRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}