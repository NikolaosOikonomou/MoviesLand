namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayField : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '1/1/1988' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
