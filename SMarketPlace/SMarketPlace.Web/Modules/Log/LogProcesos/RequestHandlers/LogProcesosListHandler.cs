using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Log.LogProcesosRow>;
using MyRow = SMarketPlace.Log.LogProcesosRow;

namespace SMarketPlace.Log;

public interface ILogProcesosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class LogProcesosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILogProcesosListHandler
{
    public LogProcesosListHandler(IRequestContext context)
            : base(context)
    {
    }
}