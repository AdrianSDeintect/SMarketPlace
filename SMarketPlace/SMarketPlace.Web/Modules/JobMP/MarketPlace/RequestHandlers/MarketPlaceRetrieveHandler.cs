using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.JobMP.MarketPlaceRow>;
using MyRow = SMarketPlace.JobMP.MarketPlaceRow;

namespace SMarketPlace.JobMP;

public interface IMarketPlaceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MarketPlaceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMarketPlaceRetrieveHandler
{
    public MarketPlaceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}