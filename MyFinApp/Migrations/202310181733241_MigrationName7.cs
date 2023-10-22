namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Incomes", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Outcomes", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Incomes", "Date");
            DropColumn("dbo.Incomes", "Time");
            DropColumn("dbo.Outcomes", "Date");
            DropColumn("dbo.Outcomes", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Outcomes", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Outcomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Outcomes", "DateTime");
            DropColumn("dbo.Incomes", "DateTime");
        }
    }
}
