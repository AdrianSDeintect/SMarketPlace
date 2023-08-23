using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Ecommerce.AlertaPromocionesRow>;
using MyRow = SMarketPlace.Ecommerce.AlertaPromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IAlertaPromocionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AlertaPromocionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAlertaPromocionesListHandler
{
    public AlertaPromocionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}