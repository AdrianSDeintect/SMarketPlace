using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Productos.Pages;

[PageAuthorize(typeof(TblproductosRappiRow))]
public class TblproductosRappiPage : Controller
{
    [Route("Productos/TblproductosRappi")]
    public ActionResult Index()
    {
        return this.GridPage("@/Productos/TblproductosRappi/TblproductosRappiPage",
            TblproductosRappiRow.Fields.PageTitle());
    }
}