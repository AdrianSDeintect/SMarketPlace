using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Log.PreciosStockUberRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Log.PreciosStockUberRow;

namespace SMarketPlace.Log;

public interface IPreciosStockUberSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockUberSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockUberSaveHandler
{
    public PreciosStockUberSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}