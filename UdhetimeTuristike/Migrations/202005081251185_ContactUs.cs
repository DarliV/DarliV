namespace UdhetimeTuristike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactUs : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ContactUs");
            AddColumn("dbo.ContactUs", "contactID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ContactUs", "contactEmail", c => c.String(nullable: false));
            AddPrimaryKey("dbo.ContactUs", "contactID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ContactUs");
            AlterColumn("dbo.ContactUs", "contactEmail", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.ContactUs", "contactID");
            AddPrimaryKey("dbo.ContactUs", "contactEmail");
        }
    }
}
