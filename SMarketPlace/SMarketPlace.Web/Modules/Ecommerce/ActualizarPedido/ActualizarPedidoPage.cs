using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Ecommerce.Pages;

[PageAuthorize(typeof(ActualizarPedidoRow))]
public class ActualizarPedidoPage : Controller
{
    [Route("Ecommerce/ActualizarPedido")]
    public ActionResult Index()
    {
        return this.GridPage("@/Ecommerce/ActualizarPedido/ActualizarPedidoPage",
            ActualizarPedidoRow.Fields.PageTitle());
    }
}