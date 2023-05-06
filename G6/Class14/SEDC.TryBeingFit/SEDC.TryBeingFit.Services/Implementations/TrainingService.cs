using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.DbInterfaces;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        //Service communicates with db
        private Domain.DbInterfaces.IDatabase<T> _database;

        public TrainingService()
        {
            _database = new Domain.Database.IDatabase<T>();
        }
        public void AddTraining(T newTraining)
        {
            //1. validation
            if (string.IsNullOrEmpty(newTraining.Title))
            {
                throw new Exception("Title can not be empty");
            }
            if (!ValidationHelper.ValidateTrainingDuration(newTraining.Duration))
            {
                throw new Exception("Duration must be at least 10 minutes");
            }
            if(newTraining.Trainer == null)
            {
                throw new Exception("Each training must have a trainer");
            }


            //2. insert into db
            _database.Add(newTraining);
        }

        public T ChangeInfo(T training)
        {
            T trainingDb = _database.GetById(training.Id);
            if(trainingDb == null)
            {
                throw new Exception("Training is not found");
            }
            _database.Update(training);

            return training;
        }

        public List<T> GetAll()
        {
            List<T> trainingsFromDB = _database.GetAll();
            return trainingsFromDB;
        }

        public T GetChosenTraining()
        {
            //get all trainings
            List<T> trainingsFromDB = _database.GetAll();

            //show
            int numInput = 0;
            while (true)
            {
                Console.WriteLine("Choose a training");
                for (int i = 0; i < trainingsFromDB.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {trainingsFromDB[i].Title}");
                }

                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out numInput);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number");
                    continue;
                }

                if (numInput < 1 || numInput > trainingsFromDB.Count)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

                break;
            }

            
            T chosenTraining = trainingsFromDB[numInput - 1];
            Console.WriteLine("You chose the following training:");
            Console.WriteLine(chosenTraining.GetInfo());

            return chosenTraining;
        }
    }
}
