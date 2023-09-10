using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Ecommerce.OrdenesEcommerceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Ecommerce.OrdenesEcommerceRow;

namespace SMarketPlace.Ecommerce;

public interface IOrdenesEcommerceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class OrdenesEcommerceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdenesEcommerceSaveHandler
{
    public OrdenesEcommerceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}