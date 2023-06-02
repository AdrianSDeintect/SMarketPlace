using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Productos.TblproductosDidiRow>;
using MyRow = SMarketPlace.Productos.TblproductosDidiRow;

namespace SMarketPlace.Productos;

public interface ITblproductosDidiRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosDidiRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosDidiRetrieveHandler
{
    public TblproductosDidiRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}