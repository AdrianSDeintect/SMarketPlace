using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Sucursales.Pages;

[PageAuthorize(typeof(TblSucursalDidiRow))]
public class TblSucursalDidiPage : Controller
{
    [Route("Sucursales/TblSucursalDidi")]
    public ActionResult Index()
    {
        return this.GridPage("@/Sucursales/TblSucursalDidi/TblSucursalDidiPage",
            TblSucursalDidiRow.Fields.PageTitle());
    }
}