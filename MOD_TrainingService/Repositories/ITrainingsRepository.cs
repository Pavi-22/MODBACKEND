using MOD_TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Repositories
{
    public interface ITrainingsRepository
    {
        void AddTrainings(Training item);

        void EditTraining(Training item);
        List<Training> GetTrainings();
        List<Training> GetTrainingByUserId(int id);
        List<Training> GetTrainingByMentorId(int id);

    }
}
