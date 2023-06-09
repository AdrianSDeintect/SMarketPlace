using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.JobMP.JobSucursalesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.JobMP.JobSucursalesRow;

namespace SMarketPlace.JobMP;

public interface IJobSucursalesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class JobSucursalesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IJobSucursalesSaveHandler
{
    public JobSucursalesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}