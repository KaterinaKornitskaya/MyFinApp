namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrationsum3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Incomes", "Sum", c => c.Int(nullable: false));
            AlterColumn("dbo.Outcomes", "Sum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Outcomes", "Sum", c => c.Double(nullable: false));
            AlterColumn("dbo.Incomes", "Sum", c => c.Double(nullable: false));
        }
    }
}
