using FluentMigrator;
using Serenity.Extensions;
using System.IO;

namespace SMarketPlace.Migrations.DefaultDB
{

    //DefaultDB_20230905_130009_ADMP
    [Migration(20230905_130009)]
    public class DefaultDB_20230905_130009_ADMP : AutoReversingMigration
    {
        private string GetScript(string name)
        {
            using var sr = new StreamReader(GetType().Assembly.GetManifestResourceStream(name));
            return sr.ReadToEnd();
        }
        public override void Up()
        {

            IfDatabase("SqlServer", "SqlServer2000", "SqlServerCe")
          .Execute.Sql(GetScript("SMarketPlace.Web.Migrations.AdicionMP.sql"));



        }
    }
}