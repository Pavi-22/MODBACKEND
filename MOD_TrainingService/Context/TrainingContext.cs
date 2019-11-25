using Microsoft.EntityFrameworkCore;
using MOD_TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Context
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
        { }
        public DbSet<Training> trainings{ get; set; }
    }
}
