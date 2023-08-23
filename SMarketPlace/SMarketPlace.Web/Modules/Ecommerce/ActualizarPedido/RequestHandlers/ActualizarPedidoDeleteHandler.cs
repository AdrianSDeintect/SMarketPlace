using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Ecommerce.ActualizarPedidoRow;

namespace SMarketPlace.Ecommerce;

public interface IActualizarPedidoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ActualizarPedidoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IActualizarPedidoDeleteHandler
{
    public ActualizarPedidoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}