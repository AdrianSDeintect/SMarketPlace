using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SMarketPlace.Ecommerce.OrdenesEcommerceRow;

namespace SMarketPlace.Ecommerce;

public interface IOrdenesEcommerceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class OrdenesEcommerceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrdenesEcommerceDeleteHandler
{
    public OrdenesEcommerceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}