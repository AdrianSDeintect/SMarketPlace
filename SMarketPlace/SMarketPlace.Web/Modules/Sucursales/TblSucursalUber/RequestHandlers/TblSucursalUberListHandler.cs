using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Sucursales.TblSucursalUberRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalUberRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalUberListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalUberListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalUberListHandler
{
    public TblSucursalUberListHandler(IRequestContext context)
            : base(context)
    {
    }
}