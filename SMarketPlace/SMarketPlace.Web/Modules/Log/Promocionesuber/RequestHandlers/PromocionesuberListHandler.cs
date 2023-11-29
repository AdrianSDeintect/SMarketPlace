using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Log.PromocionesuberRow>;
using MyRow = SMarketPlace.Log.PromocionesuberRow;

namespace SMarketPlace.Log;

public interface IPromocionesuberListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesuberListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesuberListHandler
{
    public PromocionesuberListHandler(IRequestContext context)
            : base(context)
    {
    }
}