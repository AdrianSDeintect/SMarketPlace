using Serenity.Navigation;
using MyPages = SMarketPlace.Sucursales.Pages;

[assembly: NavigationLink(int.MaxValue, "Sucursales/Sucursales", typeof(MyPages.TblSucursalPage), icon: "fa-map-marker")]
[assembly: NavigationLink(int.MaxValue, "Sucursales/Sucursales Didi", typeof(MyPages.TblSucursalDidiPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Sucursales/Sucursales Rappi", typeof(MyPages.TblSucursalRappiPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Sucursales/Sucursales Uber", typeof(MyPages.TblSucursalUberPage), icon: null)]