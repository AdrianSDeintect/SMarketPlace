using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Log.PreciosStockRappiRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Log.PreciosStockRappiRow;

namespace SMarketPlace.Log;

public interface IPreciosStockRappiSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PreciosStockRappiSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPreciosStockRappiSaveHandler
{
    public PreciosStockRappiSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}