namespace MyFinApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrArchive : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Archives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Incomes", "Archive_Id", c => c.Int());
            AddColumn("dbo.Outcomes", "Archive_Id", c => c.Int());
            CreateIndex("dbo.Incomes", "Archive_Id");
            CreateIndex("dbo.Outcomes", "Archive_Id");
            AddForeignKey("dbo.Incomes", "Archive_Id", "dbo.Archives", "Id");
            AddForeignKey("dbo.Outcomes", "Archive_Id", "dbo.Archives", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Outcomes", "Archive_Id", "dbo.Archives");
            DropForeignKey("dbo.Incomes", "Archive_Id", "dbo.Archives");
            DropIndex("dbo.Outcomes", new[] { "Archive_Id" });
            DropIndex("dbo.Incomes", new[] { "Archive_Id" });
            DropColumn("dbo.Outcomes", "Archive_Id");
            DropColumn("dbo.Incomes", "Archive_Id");
            DropTable("dbo.Archives");
        }
    }
}
