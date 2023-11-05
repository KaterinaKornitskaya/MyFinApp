namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Incomes", "Sum", c => c.Double(nullable: false));
            AddColumn("dbo.Outcomes", "Sum", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Outcomes", "Sum");
            DropColumn("dbo.Incomes", "Sum");
        }
    }
}
