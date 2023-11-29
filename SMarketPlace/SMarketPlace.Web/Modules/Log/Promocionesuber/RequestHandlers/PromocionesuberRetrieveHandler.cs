using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Log.PromocionesuberRow>;
using MyRow = SMarketPlace.Log.PromocionesuberRow;

namespace SMarketPlace.Log;

public interface IPromocionesuberRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesuberRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesuberRetrieveHandler
{
    public PromocionesuberRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}