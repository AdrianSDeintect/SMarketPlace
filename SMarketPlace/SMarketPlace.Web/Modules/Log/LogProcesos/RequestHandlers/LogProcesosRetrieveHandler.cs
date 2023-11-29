using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Log.LogProcesosRow>;
using MyRow = SMarketPlace.Log.LogProcesosRow;

namespace SMarketPlace.Log;

public interface ILogProcesosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class LogProcesosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILogProcesosRetrieveHandler
{
    public LogProcesosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}