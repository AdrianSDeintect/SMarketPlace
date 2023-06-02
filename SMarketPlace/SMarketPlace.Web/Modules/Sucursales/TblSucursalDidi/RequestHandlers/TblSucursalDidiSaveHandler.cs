using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Sucursales.TblSucursalDidiRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalDidiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalDidiSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalDidiSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalDidiSaveHandler
{
    public TblSucursalDidiSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}