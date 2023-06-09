using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.JobMP.AsignaSucursalRow>;
using MyRow = SMarketPlace.JobMP.AsignaSucursalRow;

namespace SMarketPlace.JobMP;

public interface IAsignaSucursalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AsignaSucursalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAsignaSucursalRetrieveHandler
{
    public AsignaSucursalRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}