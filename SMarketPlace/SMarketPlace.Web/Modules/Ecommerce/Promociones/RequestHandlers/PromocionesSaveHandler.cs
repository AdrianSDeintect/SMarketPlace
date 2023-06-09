using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Ecommerce.PromocionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Ecommerce.PromocionesRow;

namespace SMarketPlace.Ecommerce;

public interface IPromocionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PromocionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPromocionesSaveHandler
{
    public PromocionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}