using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Productos.TblproductosUberRow;

namespace SMarketPlace.Productos;

public interface ITblproductosUberDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosUberDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosUberDeleteHandler
{
    public TblproductosUberDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}