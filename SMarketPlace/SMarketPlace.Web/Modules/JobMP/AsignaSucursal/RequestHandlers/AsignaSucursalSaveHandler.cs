using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.JobMP.AsignaSucursalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.JobMP.AsignaSucursalRow;

namespace SMarketPlace.JobMP;

public interface IAsignaSucursalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AsignaSucursalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAsignaSucursalSaveHandler
{
    public AsignaSucursalSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}