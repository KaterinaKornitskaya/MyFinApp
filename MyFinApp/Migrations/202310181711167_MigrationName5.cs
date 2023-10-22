namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName5 : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
