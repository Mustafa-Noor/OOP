using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Composition
            WorkoutRoutineBL monday = new WorkoutRoutineBL("Monday");
            monday.AddExerciseInWork("Push Ups");

            // Aggregation
            SetBL twelve = new SetBL(12, 100);

            ExerciseBL e = new ExerciseBL("Sit Ups");

        }
    }
}
