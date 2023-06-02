using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Sucursales.TblSucursalRappiRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalRappiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalRappiSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalRappiSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalRappiSaveHandler
{
    public TblSucursalRappiSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}