using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Log.PromosRappiRow>;
using MyRow = SMarketPlace.Log.PromosRappiRow;

namespace SMarketPlace.Log;

public interface IPromosRappiListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PromosRappiListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPromosRappiListHandler
{
    public PromosRappiListHandler(IRequestContext context)
            : base(context)
    {
    }
}