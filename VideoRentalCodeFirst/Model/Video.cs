using System;
using System.Collections.Generic;

namespace VideoRentalCodeFirst.Model
{
    public class Video
    {
        public Video()
        {
            this.Genres=new List<Genre>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }  
}