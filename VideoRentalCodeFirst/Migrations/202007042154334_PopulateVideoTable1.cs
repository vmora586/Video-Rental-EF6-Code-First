namespace VideoRentalCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVideoTable1 : DbMigration
    {
        public override void Up()
        {
           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Matrix', '2001/05/12', 2, 1)");

           Sql(@" INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Pirates Of The Caribean', '2003/08/12', 5,null)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Jhon Wich', '2005/12/12', 4, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Avengers', '2007/02/27', 1, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Alpha', '2018/09/20', 5, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Shrek', '2005/09/02', 5,null)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Fast and Furious', '2004/07/12', 2, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Golliat', '2019/02/12', 7, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('You and Me', '2004/05/12', 6, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('The Revenge', '2008/09/30', 2, 1)");

           Sql(@"INSERT INTO VideoRentalCodeFirst.Videos
                (Name, ReleaseDate, GenreId, Classification)
            VALUES('Rescuing Private Rian', '2004/10/12', 4, 1)");
        }
        
        public override void Down()
        {
            Sql("Delete from VideoRentalCodeFirst.Videos");
        }
    }
}
