using MOD_TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Repositories
{
    public interface ITechnologyRepository
    {
        void AddSkills(Technology item);
        void EditSkills(Technology item);
        List<Technology> GetSkills();
        void DeleteSkills(int Id);
    }
}
