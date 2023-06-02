using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SMarketPlace.Productos.Pages;

[PageAuthorize(typeof(TblproductosDidiRow))]
public class TblproductosDidiPage : Controller
{
    [Route("Productos/TblproductosDidi")]
    public ActionResult Index()
    {
        return this.GridPage("@/Productos/TblproductosDidi/TblproductosDidiPage",
            TblproductosDidiRow.Fields.PageTitle());
    }
}