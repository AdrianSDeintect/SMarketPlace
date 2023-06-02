using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Productos.TblArticuloRow>;
using MyRow = SMarketPlace.Productos.TblArticuloRow;

namespace SMarketPlace.Productos;

public interface ITblArticuloListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblArticuloListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblArticuloListHandler
{
    public TblArticuloListHandler(IRequestContext context)
            : base(context)
    {
    }
}