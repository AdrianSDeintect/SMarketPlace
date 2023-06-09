using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.JobMP.AsignaSucursalRow>;
using MyRow = SMarketPlace.JobMP.AsignaSucursalRow;

namespace SMarketPlace.JobMP;

public interface IAsignaSucursalListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AsignaSucursalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAsignaSucursalListHandler
{
    public AsignaSucursalListHandler(IRequestContext context)
            : base(context)
    {
    }
}