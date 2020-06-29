﻿namespace VideoRentalCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVideoConfigurationClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Videos", name: "Genre_Id", newName: "GenreId");
            AlterColumn("dbo.Videos", "Classification", c => c.Byte());
            AlterColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreId" });
            AlterColumn("dbo.Videos", "GenreId", c => c.Int());
            AlterColumn("dbo.Videos", "Classification", c => c.Int());
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
