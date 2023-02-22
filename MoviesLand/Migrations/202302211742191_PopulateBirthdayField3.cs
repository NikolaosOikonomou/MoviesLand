namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayField3 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('01/01/1988' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
