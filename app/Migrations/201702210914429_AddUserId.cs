namespace app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "user_id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "user_id");
        }
    }
}
