using FluentMigrator;
using Serenity.Extensions;
using System.IO;

namespace SMarketPlace.Migrations.DefaultDB
{
    [Migration(20230525130007)]
    public class DefaultDB_20230525_130007_LogArtElim : AutoReversingMigration
    {
        private string GetScript(string name)
        {
            using var sr = new StreamReader(GetType().Assembly.GetManifestResourceStream(name));
            return sr.ReadToEnd();
        }
        public override void Up()
        {

            IfDatabase("SqlServer", "SqlServer2000", "SqlServerCe")
          .Execute.Sql(GetScript("SMarketPlace.Web.Migrations.scriptLogArticulosEliminacion.sql"));



        }
    }
}