using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD_UserService.Context;
using MOD_UserService.Models;

namespace MOD_UserService.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void AddMentor(Mentor item)
        {
            _context.Mentors.Add(item);
            _context.SaveChanges();
        }

        public void BlockMentor(int id)
        {
            var item = _context.Mentors.Find(id);
            item.MentorActive = !(item.MentorActive);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMentor(int Id)
        {
            var item = _context.Mentors.Find(Id);
            _context.Mentors.Remove(item);
            _context.SaveChanges();
        }

        public List<Mentor> GetAll()
        {
            return _context.Mentors.ToList();
        }

        public Mentor GetById(int Id)
        {
            return _context.Mentors.Find(Id);
        }

       
        public void UpdateMentorPassword(string email,string password)
        {
            var item = _context.Mentors.SingleOrDefault(i => i.MentorEmail == email);
            item.MentorPassword = password;
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
