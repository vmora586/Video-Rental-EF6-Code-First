using System;
using System.Collections.Generic;
using VideoRentalCodeFirst.Enums;

namespace VideoRentalCodeFirst.Model
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual VideoClassification? Classification { get; set; }
    }  
}