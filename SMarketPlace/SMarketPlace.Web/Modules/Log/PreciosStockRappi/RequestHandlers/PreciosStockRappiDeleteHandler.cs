using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Log.PreciosStockRappiRow;

namespace SMarketPlace.Log;

public interface IPreciosStockRappiDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockRappiDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockRappiDeleteHandler
{
    public PreciosStockRappiDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}