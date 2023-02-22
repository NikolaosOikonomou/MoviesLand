namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropName : DbMigration
    {
        public override void Up()
        {
           
           
        }
        
        public override void Down()
        {
           
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
