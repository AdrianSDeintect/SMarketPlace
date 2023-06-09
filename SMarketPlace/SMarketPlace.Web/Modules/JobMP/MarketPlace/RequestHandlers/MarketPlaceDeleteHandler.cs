using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.JobMP.MarketPlaceRow;

namespace SMarketPlace.JobMP;

public interface IMarketPlaceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class MarketPlaceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMarketPlaceDeleteHandler
{
    public MarketPlaceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}