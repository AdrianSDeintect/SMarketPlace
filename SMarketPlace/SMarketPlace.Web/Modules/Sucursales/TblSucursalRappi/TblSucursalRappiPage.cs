using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Sucursales.Pages;

[PageAuthorize(typeof(TblSucursalRappiRow))]
public class TblSucursalRappiPage : Controller
{
    [Route("Sucursales/TblSucursalRappi")]
    public ActionResult Index()
    {
        return this.GridPage("@/Sucursales/TblSucursalRappi/TblSucursalRappiPage",
            TblSucursalRappiRow.Fields.PageTitle());
    }
}