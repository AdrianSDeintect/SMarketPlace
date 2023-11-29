using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Log.LogProcesosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Log.LogProcesosRow;

namespace SMarketPlace.Log;

public interface ILogProcesosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class LogProcesosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILogProcesosSaveHandler
{
    public LogProcesosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}