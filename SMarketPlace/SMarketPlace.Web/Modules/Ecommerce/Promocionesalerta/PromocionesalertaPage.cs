using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Ecommerce.Pages;

[PageAuthorize(typeof(PromocionesalertaRow))]
public class PromocionesalertaPage : Controller
{
    [Route("Ecommerce/Promocionesalerta")]
    public ActionResult Index()
    {
        return this.GridPage("@/Ecommerce/Promocionesalerta/PromocionesalertaPage",
            PromocionesalertaRow.Fields.PageTitle());
    }
}