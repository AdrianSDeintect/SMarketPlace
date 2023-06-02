using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Productos.TblproductosDidiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosDidiDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosDidiDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosDidiDeleteHandler
{
    public TblproductosDidiDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}