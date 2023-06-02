using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Sucursales.TblSucursalDidiRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalDidiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalDidiListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalDidiListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalDidiListHandler
{
    public TblSucursalDidiListHandler(IRequestContext context)
            : base(context)
    {
    }
}