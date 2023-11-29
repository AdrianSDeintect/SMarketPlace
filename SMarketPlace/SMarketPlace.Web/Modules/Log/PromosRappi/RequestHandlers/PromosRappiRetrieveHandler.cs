using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Log.PromosRappiRow>;
using MyRow = SMarketPlace.Log.PromosRappiRow;

namespace SMarketPlace.Log;

public interface IPromosRappiRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PromosRappiRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPromosRappiRetrieveHandler
{
    public PromosRappiRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}