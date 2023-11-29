using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Log.LogProcesosRow;

namespace SMarketPlace.Log;

public interface ILogProcesosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class LogProcesosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILogProcesosDeleteHandler
{
    public LogProcesosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}