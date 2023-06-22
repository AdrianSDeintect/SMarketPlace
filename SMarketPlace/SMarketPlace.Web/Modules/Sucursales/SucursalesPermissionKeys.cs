
using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Sucursales
{
    [NestedPermissionKeys]
    [DisplayName("Sucursales")]
    public class PermissionKeys
    {

        [Description("Sucursales")]
        public const string Sucursales = "Sucursales";

        [Description("Sucursales Didi")]
        public const string Didi = "Sucursales:Didi";

        [Description("Sucursales Rappi")]
        public const string Rappi = "Sucursales:Rappi";

        [Description("Sucursales Uber")]
        public const string Uber = "Sucursales:Uber";

    }
}
