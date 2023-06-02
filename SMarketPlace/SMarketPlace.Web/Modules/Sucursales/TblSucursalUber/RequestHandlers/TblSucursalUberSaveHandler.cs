using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Sucursales.TblSucursalUberRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Sucursales.TblSucursalUberRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalUberSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalUberSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalUberSaveHandler
{
    public TblSucursalUberSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}