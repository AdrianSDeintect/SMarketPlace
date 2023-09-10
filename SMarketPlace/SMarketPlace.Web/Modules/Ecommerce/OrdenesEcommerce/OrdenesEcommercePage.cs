using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Ecommerce.Pages;

[PageAuthorize(typeof(OrdenesEcommerceRow))]
public class OrdenesEcommercePage : Controller
{
    [Route("Ecommerce/OrdenesEcommerce")]
    public ActionResult Index()
    {
        return this.GridPage("@/Ecommerce/OrdenesEcommerce/OrdenesEcommercePage",
            OrdenesEcommerceRow.Fields.PageTitle());
    }
}