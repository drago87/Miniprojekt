using Miniprojekt.Models.ImgText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Miniprojekt.DataAccess
{
    public class ImgTextContext : DbContext
    {
        public ImgTextContext() : base("DefaultConnection")
        { }

        public virtual DbSet<Image> Images { get; set; }
    }
}