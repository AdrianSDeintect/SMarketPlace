using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Ecommerce.PromocionesRow>;
using MyRow = SMarketPlace.Ecommerce.PromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesListHandler
{
    public PromocionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}