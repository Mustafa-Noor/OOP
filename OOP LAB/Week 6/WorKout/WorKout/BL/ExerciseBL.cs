using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class ExerciseBL
    {
        private string Name;
        private List<SetBL> ExerciseSets;

        public ExerciseBL(string name, List<SetBL> exerciseSets)
        {
            Name = name;
            ExerciseSets = exerciseSets;
        }
        public ExerciseBL(string name)
        {
            Name=name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void AddExerciseSet(SetBL s)
        {
            ExerciseSets.Add(s);
        }

        public void SetExerciseSets(List <SetBL> sets)
        {
            this.ExerciseSets = sets;
        }

        public List<SetBL> GetExerciseSets()
        {
            return this.ExerciseSets;
        }


    }
}
