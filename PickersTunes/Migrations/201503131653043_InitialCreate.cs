namespace PickersTunes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tunes",
                c => new
                    {
                        TuneId = c.Int(nullable: false, identity: true),
                        Artist = c.String(),
                        Name = c.String(),
                        Album = c.String(),
                    })
                .PrimaryKey(t => t.TuneId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tunes");
        }
    }
}
