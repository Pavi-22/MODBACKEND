using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TechnologyService.Context;
using MOD_TechnologyService.Models;

namespace MOD_TechnologyService.Repositories
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly TechnologyContext _context;
        public TechnologyRepository(TechnologyContext context)
        {
            _context = context;
        }
        public void AddSkills(Technology item)
        {
            _context.Technologies.Add(item);
            _context.SaveChanges();
        }

        public void DeleteSkills(int Id)
        {
            var item = _context.Technologies.Find(Id);
            _context.Technologies.Remove(item);
            _context.SaveChanges();
        }

        public void EditSkills(Technology item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public List<Technology> GetSkills()
        {
            return _context.Technologies.ToList();
        }
    }
}
