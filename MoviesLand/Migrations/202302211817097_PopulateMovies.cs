namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Rambo1', 1, '1978-11-01', '1978-12-01', 5)");
            Sql("INSERT INTO Movies (Title, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Rambo2', 1, '1990-11-01', '1990-12-01', 5)");
            Sql("INSERT INTO Movies (Title, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Rambo3', 1, '1998-11-01', '1998-12-01', 5)");
            Sql("INSERT INTO Movies (Title, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Taxi', 2, '1992-11-01', '1992-12-01', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
