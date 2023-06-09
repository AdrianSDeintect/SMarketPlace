using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.JobMP.Pages;

[PageAuthorize(typeof(JobSucursalesRow))]
public class JobSucursalesPage : Controller
{
    [Route("JobMP/JobSucursales")]
    public ActionResult Index()
    {
        return this.GridPage("@/JobMP/JobSucursales/JobSucursalesPage",
            JobSucursalesRow.Fields.PageTitle());
    }
}