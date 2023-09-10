using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Ecommerce.PromocionesalertaRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesalertaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesalertaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesalertaDeleteHandler
{
    public PromocionesalertaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}