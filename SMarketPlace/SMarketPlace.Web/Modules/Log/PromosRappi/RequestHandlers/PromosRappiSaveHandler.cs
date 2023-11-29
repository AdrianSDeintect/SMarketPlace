using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Log.PromosRappiRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Log.PromosRappiRow;

namespace SMarketPlace.Log;

public interface IPromosRappiSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PromosRappiSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPromosRappiSaveHandler
{
    public PromosRappiSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}