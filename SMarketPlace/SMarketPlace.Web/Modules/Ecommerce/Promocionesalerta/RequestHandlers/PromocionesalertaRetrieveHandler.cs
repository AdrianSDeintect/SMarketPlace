using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Ecommerce.PromocionesalertaRow>;
using MyRow = SMarketPlace.Ecommerce.PromocionesalertaRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesalertaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesalertaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesalertaRetrieveHandler
{
    public PromocionesalertaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}