namespace UdhetimeTuristike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactUs", "contactPhone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactUs", "contactPhone", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
