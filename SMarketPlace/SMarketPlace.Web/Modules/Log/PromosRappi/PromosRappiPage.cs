using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Log.Pages;

[PageAuthorize(typeof(PromosRappiRow))]
public class PromosRappiPage : Controller
{
    [Route("Log/PromosRappi")]
    public ActionResult Index()
    {
        return this.GridPage("@/Log/PromosRappi/PromosRappiPage",
            PromosRappiRow.Fields.PageTitle());
    }
}