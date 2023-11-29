using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Log.PromocionesuberRow;

namespace SMarketPlace.Log;

public interface IPromocionesuberDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesuberDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesuberDeleteHandler
{
    public PromocionesuberDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}