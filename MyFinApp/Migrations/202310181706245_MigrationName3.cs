namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Outcomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Outcomes", "Time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Incomes", "dateTime");
            DropColumn("dbo.Outcomes", "dateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Outcomes", "dateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "dateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Outcomes", "Time");
            DropColumn("dbo.Outcomes", "Date");
            DropColumn("dbo.Incomes", "Time");
            DropColumn("dbo.Incomes", "Date");
        }
    }
}
