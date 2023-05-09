using TryBeingFit.Models;
using TryBeingFit.Models.Database;
using TryBeingFit.Models.Enums;

namespace TryBeingFit.Services.Seeder
{
    public class DatabaseSeeder
    {
        private IDatabase<User> _userDatabase;
        private IDatabase<Training> _trainingDatabase;

        public DatabaseSeeder(IDatabase<User> userDatabase, IDatabase<Training> trainingDatabase)
        {
            _userDatabase = userDatabase;
            _trainingDatabase = trainingDatabase;
        }

        public void Seed()
        {
            Trainer trainer1 = new Trainer("Elena", "Bubalo", "elenaB", "elenaB123", "elena@gmail.com", "070123456", 10, "");
            Trainer trainer2 = new Trainer("Ana", "Stojanovska", "anaS", "anaS123", "ana@gmail.com", "070654321", 5, "");

            LiveTraining l1 = new LiveTraining("HIT training", "No equip needed", 30, 4.5, TrainingDifficulty.Advanced, "link 1", DateTime.Now.AddDays(2), trainer1);
            LiveTraining l2 = new LiveTraining("Yoga", "Mat", 60, 4, TrainingDifficulty.Beginner, "link 2", DateTime.Now.AddDays(7), trainer2);

            trainer1.LiveTrainings.Add(l1);
            trainer2.LiveTrainings.Add(l2);

            VideoTraining v1 = new VideoTraining("Cardio training", "None", 50, 4, TrainingDifficulty.Beginner, "link 2");
            VideoTraining v2 = new VideoTraining("Zumba training", "None", 20, 3.5, TrainingDifficulty.Advanced, "link 5");

            _userDatabase.Insert(trainer1);
            _userDatabase.Insert(trainer2);

            _trainingDatabase.Insert(l1);
            _trainingDatabase.Insert(l2);
            _trainingDatabase.Insert(v1);
            _trainingDatabase.Insert(v2);
        }
    }
}
