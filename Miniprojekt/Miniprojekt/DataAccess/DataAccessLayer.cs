using Miniprojekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miniprojekt.DataAccess
{
    public class DataAccessLayer : DbContext
    {
        public DbSet<Uppgift2> uppgift2 { get; set; }
        public DataAccessLayer(): base("DefaultConnection") {}
    }
}