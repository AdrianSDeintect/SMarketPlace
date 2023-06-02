using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Productos.TblproductosDidiRow>;
using MyRow = SMarketPlace.Productos.TblproductosDidiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosDidiListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosDidiListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosDidiListHandler
{
    public TblproductosDidiListHandler(IRequestContext context)
            : base(context)
    {
    }
}