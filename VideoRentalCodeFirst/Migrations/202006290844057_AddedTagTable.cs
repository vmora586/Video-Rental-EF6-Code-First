namespace VideoRentalCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTagTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VideoTags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        VideoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new {t.TagId, t.VideoId })
                .ForeignKey("Tags", t => t.TagId, cascadeDelete: true)
                .ForeignKey("Videos", t => t.VideoId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.VideoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("TagVideos", "VideoId", "Videos");
            DropForeignKey("TagVideos", "TagId", "Tags");
            DropIndex("TagVideos", new[] { "VideoId" });
            DropIndex("TagVideos", new[] { "TagId" });
            DropTable("TagVideos");
            DropTable("Tags");
        }
    }
}
