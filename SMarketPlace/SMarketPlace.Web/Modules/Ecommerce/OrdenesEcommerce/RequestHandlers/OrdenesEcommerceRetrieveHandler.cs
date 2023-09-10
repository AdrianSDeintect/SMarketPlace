using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SMarketPlace.Ecommerce.OrdenesEcommerceRow>;
using MyRow = SMarketPlace.Ecommerce.OrdenesEcommerceRow;

namespace SMarketPlace.Ecommerce;

public interface IOrdenesEcommerceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class OrdenesEcommerceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdenesEcommerceRetrieveHandler
{
    public OrdenesEcommerceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}