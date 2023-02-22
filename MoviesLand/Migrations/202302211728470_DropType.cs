namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "Type");
        }
        
        public override void Down()
        {
        }
    }
}
