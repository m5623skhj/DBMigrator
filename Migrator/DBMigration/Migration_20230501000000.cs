using FluentMigrator;

namespace Migrator.DBMigration
{
    [Migration(20230501000000)]
    public class Migration_20230501000000 : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("Migration_20230501000000.sql");
        }

        public override void Down()
        {
        }
    }
}