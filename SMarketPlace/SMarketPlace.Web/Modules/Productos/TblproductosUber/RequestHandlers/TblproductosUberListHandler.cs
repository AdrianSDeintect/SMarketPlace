using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Productos.TblproductosUberRow>;
using MyRow = SMarketPlace.Productos.TblproductosUberRow;

namespace SMarketPlace.Productos;

public interface ITblproductosUberListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosUberListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosUberListHandler
{
    public TblproductosUberListHandler(IRequestContext context)
            : base(context)
    {
    }
}