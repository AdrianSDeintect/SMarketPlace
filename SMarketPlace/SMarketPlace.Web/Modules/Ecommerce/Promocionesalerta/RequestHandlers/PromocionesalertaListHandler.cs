using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Ecommerce.PromocionesalertaRow>;
using MyRow = SMarketPlace.Ecommerce.PromocionesalertaRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesalertaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesalertaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesalertaListHandler
{
    public PromocionesalertaListHandler(IRequestContext context)
            : base(context)
    {
    }
}