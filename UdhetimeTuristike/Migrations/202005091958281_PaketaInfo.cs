namespace UdhetimeTuristike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaketaInfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Paketa", "emriShtetit", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Paketa", "emriShtetit", c => c.String(nullable: false));
        }
    }
}
