namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Incomes", "Archive_Id", "dbo.Archives");
            DropForeignKey("dbo.Outcomes", "Archive_Id", "dbo.Archives");
            DropIndex("dbo.Incomes", new[] { "Archive_Id" });
            DropIndex("dbo.Outcomes", new[] { "Archive_Id" });
            DropColumn("dbo.Incomes", "Archive_Id");
            DropColumn("dbo.Outcomes", "Archive_Id");
            DropTable("dbo.Archives");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Archives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Outcomes", "Archive_Id", c => c.Int());
            AddColumn("dbo.Incomes", "Archive_Id", c => c.Int());
            CreateIndex("dbo.Outcomes", "Archive_Id");
            CreateIndex("dbo.Incomes", "Archive_Id");
            AddForeignKey("dbo.Outcomes", "Archive_Id", "dbo.Archives", "Id");
            AddForeignKey("dbo.Incomes", "Archive_Id", "dbo.Archives", "Id");
        }
    }
}
