using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebServices.Models
{
    public class WebServicesContext : DbContext
    {
        public WebServicesContext (DbContextOptions<WebServicesContext> options)
            : base(options)
        {
        }

        public DbSet<WebServices.Models.GratitudeList> GratitudeList { get; set; }
    }
}
