using Serenity.Navigation;
using MyPages = SMarketPlace.Productos.Pages;

[assembly: NavigationLink(int.MaxValue, "Productos/Articulos", typeof(MyPages.TblArticuloPage), icon: "fa-barcode")]
[assembly: NavigationLink(int.MaxValue, "Productos/Productos Didi", typeof(MyPages.TblproductosDidiPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Productos/Productos Rappi", typeof(MyPages.TblproductosRappiPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Productos/Productos Uber", typeof(MyPages.TblproductosUberPage), icon: null)]