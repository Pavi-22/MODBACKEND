using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TrainingService.Context;
using MOD_TrainingService.Models;

namespace MOD_TrainingService.Repositories
{
    public class TrainingsRepository : ITrainingsRepository
    {
        private readonly TrainingContext _context;
        public TrainingsRepository(TrainingContext context)
        {
            _context = context;
        }
        public void AddTrainings(Training item)
        {
            _context.trainings.Add(item);
            _context.SaveChanges();
        }

        public void EditTraining(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public List<Training> GetTrainingByMentorId(int id)
        {
            return _context.trainings.Where(i => i.UserId == id).ToList();
        }

        public List<Training> GetTrainingByUserId(int id)
        {
            return _context.trainings.Where(i => i.UserId == id).ToList();

        }

        public List<Training> GetTrainings()
        {
            return _context.trainings.ToList();
        }
    }
}
