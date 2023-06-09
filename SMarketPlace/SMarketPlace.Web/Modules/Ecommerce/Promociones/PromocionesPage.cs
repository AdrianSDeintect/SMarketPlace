using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Ecommerce.Pages;

[PageAuthorize(typeof(PromocionesRow))]
public class PromocionesPage : Controller
{
    [Route("Ecommerce/Promociones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Ecommerce/Promociones/PromocionesPage",
            PromocionesRow.Fields.PageTitle());
    }
}