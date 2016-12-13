using Miniprojekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miniprojekt.DataAccess
{
    public class DataAccessLayerUppgift2 : DbContext
    {
        public DbSet<Uppgift2> uppgift2 { get; set; }
        public DataAccessLayerUppgift2() : base("DefaultConnection") { }
    }
}