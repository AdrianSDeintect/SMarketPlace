using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Productos.TblproductosUberRow>;
using MyRow = SMarketPlace.Productos.TblproductosUberRow;

namespace SMarketPlace.Productos;

public interface ITblproductosUberRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblproductosUberRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblproductosUberRetrieveHandler
{
    public TblproductosUberRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}