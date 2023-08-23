using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Ecommerce.AlertaPromocionesRow>;
using MyRow = SMarketPlace.Ecommerce.AlertaPromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IAlertaPromocionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AlertaPromocionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAlertaPromocionesRetrieveHandler
{
    public AlertaPromocionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}