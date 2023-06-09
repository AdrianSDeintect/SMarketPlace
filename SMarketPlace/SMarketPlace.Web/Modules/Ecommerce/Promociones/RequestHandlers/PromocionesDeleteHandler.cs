using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Ecommerce.PromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesDeleteHandler
{
    public PromocionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}