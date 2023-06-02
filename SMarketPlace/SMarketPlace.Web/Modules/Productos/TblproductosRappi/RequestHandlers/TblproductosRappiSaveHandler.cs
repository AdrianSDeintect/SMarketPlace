using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Productos.TblproductosRappiRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Productos.TblproductosRappiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosRappiSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosRappiSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosRappiSaveHandler
{
    public TblproductosRappiSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}