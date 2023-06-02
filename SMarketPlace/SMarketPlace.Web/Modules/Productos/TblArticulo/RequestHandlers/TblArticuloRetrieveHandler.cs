using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Productos.TblArticuloRow>;
using MyRow = SMarketPlace.Productos.TblArticuloRow;

namespace SMarketPlace.Productos;

public interface ITblArticuloRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TblArticuloRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblArticuloRetrieveHandler
{
    public TblArticuloRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}