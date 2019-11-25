using MOD_UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User item);
        List<User> GetAll();
        User GetById(int Id);
        void UpdateUserPassword(string email,string password);
        void DeleteUser(int Id);
        void BlockUser(int Id);
        List<Mentor> SearchMentor(string MentorSkills);
    }
}