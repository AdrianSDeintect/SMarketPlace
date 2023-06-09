using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.JobMP.AsignaSucursalRow;

namespace SMarketPlace.JobMP;

public interface IAsignaSucursalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AsignaSucursalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAsignaSucursalDeleteHandler
{
    public AsignaSucursalDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}