using System.Data.Entity.ModelConfiguration;
using VideoRentalCodeFirst.Model;

namespace VideoRentalCodeFirst.EntityConfiguration
{
    public class VideoConfiguration:EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            ToTable("Videos");
            HasKey(v => v.Id);

            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(v => v.Genre)
                .WithMany(g => g.Videos)
                .HasForeignKey(v => v.GenreId);
        }
        
    }
}