namespace VideoRentalCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VideoRentalCodeFirst.Genres (Name) VALUES('Action')");
            Sql("INSERT INTO VideoRentalCodeFirst.Genres (Name) VALUES('Drama')");
            Sql("INSERT INTO VideoRentalCodeFirst.Genres (Name) VALUES('Science Fiction')");
            Sql("INSERT INTO VideoRentalCodeFirst.Genres (Name) VALUES('Thriller')");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE VideoRentalCodeFirst.Genres");
        }
    }
}
