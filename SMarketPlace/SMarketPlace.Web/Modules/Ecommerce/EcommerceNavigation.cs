using Serenity.Navigation;
using MyPages = SMarketPlace.Ecommerce.Pages;

[assembly: NavigationLink(int.MaxValue, "Ecommerce/Promociones", typeof(MyPages.PromocionesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ecommerce/Actualizar Pedido", typeof(MyPages.ActualizarPedidoPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ecommerce/Alerta Promociones", typeof(MyPages.AlertaPromocionesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ecommerce/Ordenes Ecommerce", typeof(MyPages.OrdenesEcommercePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ecommerce/Promocionesalerta", typeof(MyPages.PromocionesalertaPage), icon: null)]
