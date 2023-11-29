using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Log.Pages;

[PageAuthorize(typeof(PreciosStockUberRow))]
public class PreciosStockUberPage : Controller
{
    [Route("Log/PreciosStockUber")]
    public ActionResult Index()
    {
        return this.GridPage("@/Log/PreciosStockUber/PreciosStockUberPage",
            PreciosStockUberRow.Fields.PageTitle());
    }
}