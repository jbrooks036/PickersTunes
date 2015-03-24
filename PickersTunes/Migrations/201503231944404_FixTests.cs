namespace PickersTunes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tunes", "ApplicationUserId", c => c.String());
            DropColumn("dbo.Tunes", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tunes", "UserId", c => c.String());
            DropColumn("dbo.Tunes", "ApplicationUserId");
        }
    }
}
