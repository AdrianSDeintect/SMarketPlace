using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.JobMP.JobSucursalesRow>;
using MyRow = SMarketPlace.JobMP.JobSucursalesRow;

namespace SMarketPlace.JobMP;

public interface IJobSucursalesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class JobSucursalesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IJobSucursalesRetrieveHandler
{
    public JobSucursalesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}