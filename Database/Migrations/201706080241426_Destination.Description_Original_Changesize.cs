namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DestinationDescription_Original_Changesize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Destinations", "Description", c => c.String(maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Destinations", "Description", c => c.String(maxLength: 500));
        }
    }
}
