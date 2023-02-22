namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayFiel : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '01/01/1988' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
