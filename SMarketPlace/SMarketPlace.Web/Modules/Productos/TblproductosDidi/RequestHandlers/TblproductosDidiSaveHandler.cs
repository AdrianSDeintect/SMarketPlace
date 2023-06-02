using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Productos.TblproductosDidiRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Productos.TblproductosDidiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosDidiSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosDidiSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosDidiSaveHandler
{
    public TblproductosDidiSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}