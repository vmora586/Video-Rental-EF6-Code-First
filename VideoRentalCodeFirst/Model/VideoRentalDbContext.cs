using System.Data.Entity;

namespace VideoRentalCodeFirst.Model
{
    public class VideoRentalDbContext:DbContext
    {
        public VideoRentalDbContext()
        :base("RentalVideoContext")
        {
                
        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}