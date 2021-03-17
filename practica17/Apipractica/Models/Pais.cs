using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apipractica.Models
{
 
    public class Pais
    {
        [Key]
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<string> Latlng { get; set; }
        public List<string> Timezones { get; set; }
        public List<string> Currencies { get; set; }
        public string Flag { get; set; }




    }
}