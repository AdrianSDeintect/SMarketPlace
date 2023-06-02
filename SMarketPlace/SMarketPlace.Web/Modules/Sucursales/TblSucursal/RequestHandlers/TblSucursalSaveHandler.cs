using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Sucursales.TblSucursalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalSaveHandler
{
    public TblSucursalSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}