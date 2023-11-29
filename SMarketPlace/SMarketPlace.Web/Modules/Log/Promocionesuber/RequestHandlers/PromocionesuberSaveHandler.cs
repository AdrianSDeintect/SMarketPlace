using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Log.PromocionesuberRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Log.PromocionesuberRow;

namespace SMarketPlace.Log;

public interface IPromocionesuberSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesuberSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesuberSaveHandler
{
    public PromocionesuberSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}