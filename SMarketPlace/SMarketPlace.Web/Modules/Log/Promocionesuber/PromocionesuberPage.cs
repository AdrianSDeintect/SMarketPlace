using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Log.Pages;

[PageAuthorize(typeof(PromocionesuberRow))]
public class PromocionesuberPage : Controller
{
    [Route("Log/Promocionesuber")]
    public ActionResult Index()
    {
        return this.GridPage("@/Log/Promocionesuber/PromocionesuberPage",
            PromocionesuberRow.Fields.PageTitle());
    }
}