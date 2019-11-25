using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD_UserService.Context;
using MOD_UserService.Models;

namespace MOD_UserService.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void AddUser(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void BlockUser(int Id)
        {
            var item = _context.Users.Find(Id);
            item.UserActive = !(item.UserActive);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(int Id)
        {
            var item = _context.Users.Find(Id);
            _context.Users.Remove(item);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int Id)
        {
            return _context.Users.Find(Id);
        }

        public List<Mentor> SearchMentor(string MentorSkills)
        {
            //return _context.Mentors.Find(MentorSkills);

            return _context.Mentors.Where(i => i.MentorSkills == MentorSkills).ToList();
                 
        }

        public void UpdateUserPassword(string email,string password)
        {
            var item = _context.Users.SingleOrDefault(i => i.UserEmail == email);
            item.UserPassword = password;
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        
    }
}
