using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Ecommerce.AlertaPromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IAlertaPromocionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AlertaPromocionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAlertaPromocionesDeleteHandler
{
    public AlertaPromocionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}