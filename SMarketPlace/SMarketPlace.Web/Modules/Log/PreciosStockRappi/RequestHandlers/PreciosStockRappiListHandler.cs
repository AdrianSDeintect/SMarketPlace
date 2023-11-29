using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Log.PreciosStockRappiRow>;
using MyRow = SMarketPlace.Log.PreciosStockRappiRow;

namespace SMarketPlace.Log;

public interface IPreciosStockRappiListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockRappiListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockRappiListHandler
{
    public PreciosStockRappiListHandler(IRequestContext context)
            : base(context)
    {
    }
}