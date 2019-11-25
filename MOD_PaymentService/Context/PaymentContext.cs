using Microsoft.EntityFrameworkCore;
using MOD_PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_PaymentService.Context
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        { }
        public DbSet<Payment> Payments { get; set; }
    }
}
