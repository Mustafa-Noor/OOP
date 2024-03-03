using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class WorkoutRoutineBL
    {
        private string Name;
        private List<ExerciseBL> Exercises;

        public WorkoutRoutineBL (string name)
        {
            Name = name;
            Exercises = new List<ExerciseBL>();

        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void AddExerciseInWork(string name)
        {
            Exercises.Add(new ExerciseBL(name));
        }

        public void SetExerciseInWork(List<ExerciseBL> Exercises)
        {
            this.Exercises = Exercises;
        }

        public List<ExerciseBL> GetExerciseSets()
        {
            return this.Exercises;
        }


    }
}
