using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Ecommerce.PromocionesRow>;
using MyRow = SMarketPlace.Ecommerce.PromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesRetrieveHandler
{
    public PromocionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}