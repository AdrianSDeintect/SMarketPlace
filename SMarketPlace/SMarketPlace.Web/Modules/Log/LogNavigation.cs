using Serenity.Navigation;
using MyPages = SMarketPlace.Log.Pages;

[assembly: NavigationLink(int.MaxValue, "Log/Log Procesos", typeof(MyPages.LogProcesosPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Log/Promos Rappi", typeof(MyPages.PromosRappiPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Log/Precios Stock Rappi", typeof(MyPages.PreciosStockRappiPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Log/Precios Stock Uber", typeof(MyPages.PreciosStockUberPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Log/Promocionesuber", typeof(MyPages.PromocionesuberPage), icon: null)]