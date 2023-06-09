using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.JobMP.Pages;

[PageAuthorize(typeof(MarketPlaceRow))]
public class MarketPlacePage : Controller
{
    [Route("JobMP/MarketPlace")]
    public ActionResult Index()
    {
        return this.GridPage("@/JobMP/MarketPlace/MarketPlacePage",
            MarketPlaceRow.Fields.PageTitle());
    }
}