using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Ecommerce.ActualizarPedidoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Ecommerce.ActualizarPedidoRow;

namespace SMarketPlace.Ecommerce;

public interface IActualizarPedidoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ActualizarPedidoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActualizarPedidoSaveHandler
{
    public ActualizarPedidoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}