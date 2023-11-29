using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Log
{
    [NestedPermissionKeys]
    [DisplayName("Logs")]
    public class PermissionKeys
    {

        [Description("LogProcesosMP")]
        public const string LogProcesos = "Log:LogProcesosMP";

        [Description("Promos Rappi")]
        public const string PromosRappi = "Log:PromosRappi";

        [Description("Promos Uber")]
        public const string PromosUber = "Log:Promocionesuber";

        [Description("Stock Uber")]
        public const string StockUber = "Log:PreciosStockUber";

        [Description("Stock Rappi")]
        public const string StockRappi = "Log:PreciosStockRappi";


    }
}
