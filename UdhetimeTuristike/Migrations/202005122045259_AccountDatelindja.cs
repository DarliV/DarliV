namespace UdhetimeTuristike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountDatelindja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Datelindja", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Datelindja");
        }
    }
}
