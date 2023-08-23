using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Ecommerce.Pages;

[PageAuthorize(typeof(AlertaPromocionesRow))]
public class AlertaPromocionesPage : Controller
{
    [Route("Ecommerce/AlertaPromociones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Ecommerce/AlertaPromociones/AlertaPromocionesPage",
            AlertaPromocionesRow.Fields.PageTitle());
    }
}