using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Ecommerce.ActualizarPedidoRow>;
using MyRow = SMarketPlace.Ecommerce.ActualizarPedidoRow;

namespace SMarketPlace.Ecommerce;

public interface IActualizarPedidoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ActualizarPedidoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IActualizarPedidoListHandler
{
    public ActualizarPedidoListHandler(IRequestContext context)
            : base(context)
    {
    }
}