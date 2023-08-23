using FluentMigrator;
using Serenity.Extensions;
using System.IO;

namespace SMarketPlace.Migrations.DefaultDB
{

    //DefaultDB_20230601_130007_Ecommerce
    [Migration(20230711_130009)]
    public class DefaultDB_20230711_130009_ADEcommerce2 : AutoReversingMigration
    {
        private string GetScript(string name)
        {
            using var sr = new StreamReader(GetType().Assembly.GetManifestResourceStream(name));
            return sr.ReadToEnd();
        }
        public override void Up()
        {

            IfDatabase("SqlServer", "SqlServer2000", "SqlServerCe")
          .Execute.Sql(GetScript("SMarketPlace.Web.Migrations.AdicionEcommerce2.sql"));



        }
    }
}