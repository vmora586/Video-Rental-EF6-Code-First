using System.Collections.Generic;

namespace VideoRentalCodeFirst.Model
{
    public class Genre
    {
        public Genre()
        {
               this.Videos=new List<Video>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}