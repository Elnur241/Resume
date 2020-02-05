using Microsoft.EntityFrameworkCore;
using Resume.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models.DataContext
{
    public class PortfoliodbContext:DbContext
    {
        public PortfoliodbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
