namespace VideoRentalCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVideoTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VideoRentalCodeFirst.Videos(Name, ReleaseDate, Genre_Id) VALUES('Avatar', '2007/05/20', 3)");
            Sql("INSERT INTO VideoRentalCodeFirst.Videos(Name, ReleaseDate, Genre_Id) VALUES('Jurassic Park', '2017/08/20', 3)");
            Sql("INSERT INTO VideoRentalCodeFirst.Videos(Name, ReleaseDate, Genre_Id) VALUES('John Wick 3', '2018/02/15', 1)");
            Sql("INSERT INTO VideoRentalCodeFirst.Videos(Name, ReleaseDate, Genre_Id) VALUES('Avengers Infinity War', '2018/06/15', 1)");
            
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE VideoRentalCodeFirst.Video");
        }
    }
}
