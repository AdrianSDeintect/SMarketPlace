using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Ecommerce.AlertaPromocionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Ecommerce.AlertaPromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IAlertaPromocionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AlertaPromocionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAlertaPromocionesSaveHandler
{
    public AlertaPromocionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}