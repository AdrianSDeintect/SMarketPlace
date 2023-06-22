
using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Productos
{
    [NestedPermissionKeys]
    [DisplayName("Productos")]
    public class PermissionKeys
    {

        [Description("Productos")]
        public const string Productos = "Productos";

        [Description("Productos Didi")]
        public const string Didi = "Productos:Didi";

        [Description("Productos Rappi")]
        public const string Rappi = "Productos:Rappi";

        [Description("Productos Uber")]
        public const string Uber = "Productos:Uber";

    }
}
