using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.JobMP
{
    [NestedPermissionKeys]
    [DisplayName("MP")]
    public class PermissionKeys
    {


        [Description("AsignaSucursal")]
        public const string AsignaSucursal = "MP.AsignaSucursal";

        [Description("JobSucursales")]
        public const string JobSucursales = "MP:JobSucursales";


        [Description("MarketPlace")]
        public const string MarketPlace = "MP:MarketPlace";


    }
}


   