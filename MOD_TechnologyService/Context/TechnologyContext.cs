using Microsoft.EntityFrameworkCore;
using MOD_TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Context
{
    public class TechnologyContext : DbContext
    {
        public TechnologyContext(DbContextOptions<TechnologyContext> options) : base(options)
        { }
        public DbSet<Technology> Technologies { get; set; } 
    }
}
