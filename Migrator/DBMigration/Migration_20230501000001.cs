using FluentMigrator;

namespace Migrator.DBMigration
{
	[Migration(20230501000001)]
	public class Migration_20230501000001: Migration
	{
		public override void Up()
		{
			Execute.EmbeddedScript("Migration_20230501000001.sql");
		}

		public override void Down()
		{
		}
	}
}
