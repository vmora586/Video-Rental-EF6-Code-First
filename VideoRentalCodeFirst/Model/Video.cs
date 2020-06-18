using System;
using System.Collections.Generic;

namespace VideoRentalCodeFirst.Model
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual Genre Genre { get; set; }
    }  
}