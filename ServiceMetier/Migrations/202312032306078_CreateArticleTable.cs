namespace ServiceMetier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateArticleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        IdArticle = c.Int(nullable: false, identity: true),
                        CodeArticle = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        Quantite = c.Int(nullable: false),
                        QuantiteMin = c.Int(),
                        PrixUnit = c.Double(nullable: false),
                        DatePeremption = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdArticle);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
