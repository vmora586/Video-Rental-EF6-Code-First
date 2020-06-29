namespace VideoRentalCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVideoConfigurationClass : DbMigration
    {
        public override void Up()
        {
            //Sql("ALTER TABLE VideoRentalCodeFirst.Videos DROP FOREIGN KEY FK_Videos_Genres_Genre_Id;");
            DropForeignKey("Videos", "Genre_Id", "Genres");
            DropIndex("Videos", new[] { "Genre_Id" });
            RenameColumn(table: "Videos", name: "Genre_Id", newName: "GenreId", anonymousArguments: new {ColumnType="int"});
            AlterColumn("Videos", "Classification", c => c.Byte());
            AlterColumn("Videos", "GenreId", c => c.Int(nullable: false));
            CreateIndex("Videos", "GenreId");
            AddForeignKey("Videos", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //Sql("ALTER TABLE VideoRentalCodeFirst.Videos DROP FOREIGN KEY FK_Videos_Genres_GenreId;");
            DropForeignKey("Videos", "GenreId", "Genres");
            DropIndex("Videos", new[] { "GenreId" });
            AlterColumn("Videos", "GenreId", c => c.Int());
            AlterColumn("Videos", "Classification", c => c.Int());
            RenameColumn(table: "Videos", name: "GenreId", newName: "Genre_Id", anonymousArguments: new {ColumType="int"});
            CreateIndex("Videos", "Genre_Id");
            AddForeignKey("Videos", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
