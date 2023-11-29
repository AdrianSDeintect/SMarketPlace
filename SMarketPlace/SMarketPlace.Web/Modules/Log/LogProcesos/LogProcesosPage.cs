using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Log.Pages;

[PageAuthorize(typeof(LogProcesosRow))]
public class LogProcesosPage : Controller
{
    [Route("Log/LogProcesos")]
    public ActionResult Index()
    {
        return this.GridPage("@/Log/LogProcesos/LogProcesosPage",
            LogProcesosRow.Fields.PageTitle());
    }
}