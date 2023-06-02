using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Sucursales.TblSucursalRappiRow>;
using MyRow = SMarketPlace.Sucursales.TblSucursalRappiRow;

namespace SMarketPlace.Sucursales;

public interface ITblSucursalRappiListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TblSucursalRappiListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblSucursalRappiListHandler
{
    public TblSucursalRappiListHandler(IRequestContext context)
            : base(context)
    {
    }
}