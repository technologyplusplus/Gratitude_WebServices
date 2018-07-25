using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace WebServices.Models
{
    public class WebServicesContext : DbContext
    {
        public WebServicesContext (DbContextOptions<WebServicesContext> options)
            : base(options)
        {
        }

        public DbSet<WebServices.Models.GratitudeList> GratitudeList { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //optionsBuilder.UseMySQL(Configuration.GetConnectionString("WebServicesContext")));
        //}
    }
}
