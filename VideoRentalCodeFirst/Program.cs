using System;
using System.Linq;
using VideoRentalCodeFirst.Model;

namespace VideoRentalCodeFirst
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var context = new VideoRentalDbContext();

            // Action movies sorted by name
            Console.WriteLine();
            Console.WriteLine("ACTION MOVIES SORTED BY NAME");

           /* var actionMovies = context.Videos
                .Where(v => v.Genre.Name == "Action")
                .OrderBy(v => v.Name);

            foreach (var video in actionMovies)
            {
                Console.WriteLine(video.Name);
            }
*/

        }
    }
}