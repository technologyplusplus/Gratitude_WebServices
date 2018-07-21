using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebServices.Models
{
    public class GratitudeList
    {
        [Key]
        public int ListId { get; set; }
        public int AuthId { get; set; }
        public string ListItem { get; set; }
        public DateTime  ListCreateDate { get; set; }        
    }
}
