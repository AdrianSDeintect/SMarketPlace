using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Log.PromosRappiRow;

namespace SMarketPlace.Log;

public interface IPromosRappiDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PromosRappiDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPromosRappiDeleteHandler
{
    public PromosRappiDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}