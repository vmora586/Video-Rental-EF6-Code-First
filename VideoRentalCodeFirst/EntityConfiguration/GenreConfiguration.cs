using System.Data.Entity.ModelConfiguration;
using VideoRentalCodeFirst.Model;

namespace VideoRentalCodeFirst.EntityConfiguration
{
    public class GenreConfiguration:EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}