using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Ecommerce.ActualizarPedidoRow>;
using MyRow = SMarketPlace.Ecommerce.ActualizarPedidoRow;

namespace SMarketPlace.Ecommerce;

public interface IActualizarPedidoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ActualizarPedidoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IActualizarPedidoRetrieveHandler
{
    public ActualizarPedidoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}