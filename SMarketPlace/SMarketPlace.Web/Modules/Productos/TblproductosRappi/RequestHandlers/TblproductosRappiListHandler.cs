using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Productos.TblproductosRappiRow>;
using MyRow = SMarketPlace.Productos.TblproductosRappiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosRappiListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosRappiListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosRappiListHandler
{
    public TblproductosRappiListHandler(IRequestContext context)
            : base(context)
    {
    }
}