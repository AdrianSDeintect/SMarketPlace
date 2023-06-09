using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.JobMP.Pages;

[PageAuthorize(typeof(AsignaSucursalRow))]
public class AsignaSucursalPage : Controller
{
    [Route("JobMP/AsignaSucursal")]
    public ActionResult Index()
    {
        return this.GridPage("@/JobMP/AsignaSucursal/AsignaSucursalPage",
            AsignaSucursalRow.Fields.PageTitle());
    }
}