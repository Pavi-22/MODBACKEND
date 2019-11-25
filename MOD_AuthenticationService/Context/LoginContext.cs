using Microsoft.EntityFrameworkCore;
using MOD_AuthenticationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
    }
}
