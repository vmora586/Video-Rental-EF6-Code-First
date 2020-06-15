
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace VideoRentalCodeFirst.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<VideoRentalCodeFirst.Model.VideoRentalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}