using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Log.PreciosStockUberRow;

namespace SMarketPlace.Log;

public interface IPreciosStockUberDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockUberDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockUberDeleteHandler
{
    public PreciosStockUberDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}