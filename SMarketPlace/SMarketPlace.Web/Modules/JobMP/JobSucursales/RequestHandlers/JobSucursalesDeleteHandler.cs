using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.JobMP.JobSucursalesRow;

namespace SMarketPlace.JobMP;

public interface IJobSucursalesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class JobSucursalesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IJobSucursalesDeleteHandler
{
    public JobSucursalesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}