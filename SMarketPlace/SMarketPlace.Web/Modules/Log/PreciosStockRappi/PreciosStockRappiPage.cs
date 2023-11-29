using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Log.Pages;

[PageAuthorize(typeof(PreciosStockRappiRow))]
public class PreciosStockRappiPage : Controller
{
    [Route("Log/PreciosStockRappi")]
    public ActionResult Index()
    {
        return this.GridPage("@/Log/PreciosStockRappi/PreciosStockRappiPage",
            PreciosStockRappiRow.Fields.PageTitle());
    }
}