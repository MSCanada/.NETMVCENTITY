namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DestinationDescription_Original_size : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Country = c.String(),
                        Description = c.String(maxLength: 500),
                        Photo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Lodgings",
                c => new
                    {
                        LodgingId = c.Int(nullable: false, identity: true),
                        DestinationId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        Owner = c.String(),
                        IsResort = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LodgingId)
                .ForeignKey("dbo.Destinations", t => t.DestinationId, cascadeDelete: true)
                .Index(t => t.DestinationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lodgings", "DestinationId", "dbo.Destinations");
            DropIndex("dbo.Lodgings", new[] { "DestinationId" });
            DropTable("dbo.Lodgings");
            DropTable("dbo.Destinations");
        }
    }
}
