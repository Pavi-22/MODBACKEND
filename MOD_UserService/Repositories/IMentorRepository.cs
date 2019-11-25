using MOD_UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Repositories
{
    public interface IMentorRepository
    {
        void AddMentor(Mentor item);
        void UpdateMentorPassword(string email,string password);
        void DeleteMentor(int Id);
        void BlockMentor(int id);
        List<Mentor> GetAll();
        Mentor GetById(int Id);
       
    }
}
