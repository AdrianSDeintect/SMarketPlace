using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Ecommerce.PromocionesalertaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Ecommerce.PromocionesalertaRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesalertaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesalertaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesalertaSaveHandler
{
    public PromocionesalertaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}