using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Productos.Pages;

[PageAuthorize(typeof(TblArticuloRow))]
public class TblArticuloPage : Controller
{
    [Route("Productos/TblArticulo")]
    public ActionResult Index()
    {
        return this.GridPage("@/Productos/TblArticulo/TblArticuloPage",
            TblArticuloRow.Fields.PageTitle());
    }
}