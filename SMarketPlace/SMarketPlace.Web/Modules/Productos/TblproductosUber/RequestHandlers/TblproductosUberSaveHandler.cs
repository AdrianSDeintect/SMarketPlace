using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Productos.TblproductosUberRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Productos.TblproductosUberRow;

namespace SMarketPlace.Productos;

public interface ITblproductosUberSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosUberSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosUberSaveHandler
{
    public TblproductosUberSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}