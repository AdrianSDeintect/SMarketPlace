using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.JobMP.MarketPlaceRow>;
using MyRow = SMarketPlace.JobMP.MarketPlaceRow;

namespace SMarketPlace.JobMP;

public interface IMarketPlaceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MarketPlaceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMarketPlaceListHandler
{
    public MarketPlaceListHandler(IRequestContext context)
            : base(context)
    {
    }
}