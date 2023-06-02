using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Productos.TblArticuloRow;

namespace SMarketPlace.Productos;

public interface ITblArticuloDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TblArticuloDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblArticuloDeleteHandler
{
    public TblArticuloDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}