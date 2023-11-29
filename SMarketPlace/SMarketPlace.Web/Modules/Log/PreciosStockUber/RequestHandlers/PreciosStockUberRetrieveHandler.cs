using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Log.PreciosStockUberRow>;
using MyRow = SMarketPlace.Log.PreciosStockUberRow;

namespace SMarketPlace.Log;

public interface IPreciosStockUberRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockUberRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockUberRetrieveHandler
{
    public PreciosStockUberRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}