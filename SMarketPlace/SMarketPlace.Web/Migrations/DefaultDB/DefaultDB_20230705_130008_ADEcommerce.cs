using FluentMigrator;
using Serenity.Extensions;
using System.IO;

namespace SMarketPlace.Migrations.DefaultDB
{

    //DefaultDB_20230601_130007_Ecommerce
    [Migration(20230705_130008)]
    public class DefaultDB_20230705_130008_ADEcommerce : AutoReversingMigration
    {
        private string GetScript(string name)
        {
            using var sr = new StreamReader(GetType().Assembly.GetManifestResourceStream(name));
            return sr.ReadToEnd();
        }
        public override void Up()
        {

            IfDatabase("SqlServer", "SqlServer2000", "SqlServerCe")
          .Execute.Sql(GetScript("SMarketPlace.Web.Migrations.AdicionEcommerce.sql"));



        }
    }
}