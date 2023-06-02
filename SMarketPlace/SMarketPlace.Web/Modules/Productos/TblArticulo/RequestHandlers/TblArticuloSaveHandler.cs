using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Productos.TblArticuloRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Productos.TblArticuloRow;

namespace SMarketPlace.Productos;

public interface ITblArticuloSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TblArticuloSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblArticuloSaveHandler
{
    public TblArticuloSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}