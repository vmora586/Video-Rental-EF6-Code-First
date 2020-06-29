using System.Collections;
using System.Collections.Generic;

namespace VideoRentalCodeFirst.Model
{
    public class Tag
    {
        public Tag()
        {
            Videos = new List<Video>();
        }
        public int Id { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}