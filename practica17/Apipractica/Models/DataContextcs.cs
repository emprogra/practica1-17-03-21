using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Apipractica.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<Apipractica.Models.Pais> Pais { get; set; }
    }
}