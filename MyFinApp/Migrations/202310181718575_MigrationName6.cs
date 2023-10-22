namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Outcomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Outcomes", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Outcomes", "Time");
            DropColumn("dbo.Outcomes", "Date");
            DropColumn("dbo.Incomes", "Time");
            DropColumn("dbo.Incomes", "Date");
        }
    }
}
