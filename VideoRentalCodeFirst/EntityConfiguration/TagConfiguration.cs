using System.Data.Entity.ModelConfiguration;
using VideoRentalCodeFirst.Model;

namespace VideoRentalCodeFirst.EntityConfiguration
{
    public class TagConfiguration:EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            ToTable("Tags");

            HasKey(t => t.Id);

            HasMany(t => t.Videos)
                .WithMany(v => v.Tags)
                .Map(m =>
                {
                        m.ToTable("VideoTags");
                        m.MapLeftKey("TagId");
                        m.MapRightKey("VideoId");
                });
        }
    }
}