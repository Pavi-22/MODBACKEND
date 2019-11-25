using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD_PaymentService.Context;
using MOD_PaymentService.Models;

namespace MOD_PaymentService.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void AddPayment(Payment item)
        {
            _context.Payments.Add(item);
            _context.SaveChanges();
        }

        public void DeletePayment(int id)
        {
            var item = _context.Payments.Find(id);
            _context.Payments.Remove(item);
            _context.SaveChanges();
        }

        public List<Payment> GetAllPayment()
        {
            return _context.Payments.ToList();
        }

        public void UpdatePayment(Payment item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
