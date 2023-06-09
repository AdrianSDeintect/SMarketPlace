using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.JobMP.MarketPlaceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.JobMP.MarketPlaceRow;

namespace SMarketPlace.JobMP;

public interface IMarketPlaceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MarketPlaceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMarketPlaceSaveHandler
{
    public MarketPlaceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}