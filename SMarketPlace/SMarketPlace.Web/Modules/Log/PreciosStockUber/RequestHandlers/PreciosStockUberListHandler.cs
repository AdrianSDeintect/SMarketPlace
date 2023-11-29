using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Log.PreciosStockUberRow>;
using MyRow = SMarketPlace.Log.PreciosStockUberRow;

namespace SMarketPlace.Log;

public interface IPreciosStockUberListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockUberListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockUberListHandler
{
    public PreciosStockUberListHandler(IRequestContext context)
            : base(context)
    {
    }
}