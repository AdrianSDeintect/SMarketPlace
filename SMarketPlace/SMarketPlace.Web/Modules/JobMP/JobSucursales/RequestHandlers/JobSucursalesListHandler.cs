using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.JobMP.JobSucursalesRow>;
using MyRow = SMarketPlace.JobMP.JobSucursalesRow;

namespace SMarketPlace.JobMP;

public interface IJobSucursalesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class JobSucursalesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IJobSucursalesListHandler
{
    public JobSucursalesListHandler(IRequestContext context)
            : base(context)
    {
    }
}