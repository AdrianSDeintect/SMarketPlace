using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Ecommerce.OrdenesEcommerceRow>;
using MyRow = SMarketPlace.Ecommerce.OrdenesEcommerceRow;

namespace SMarketPlace.Ecommerce;

public interface IOrdenesEcommerceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class OrdenesEcommerceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrdenesEcommerceListHandler
{
    public OrdenesEcommerceListHandler(IRequestContext context)
            : base(context)
    {
    }
}