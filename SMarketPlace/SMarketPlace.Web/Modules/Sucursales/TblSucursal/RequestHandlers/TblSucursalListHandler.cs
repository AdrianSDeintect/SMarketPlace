using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Sucursales.TblSucursalRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalListHandler
{
    public TblSucursalListHandler(IRequestContext context)
            : base(context)
    {
    }
}