using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class SetBL
    {
        private int Reps;
        private float Weights;

        public SetBL(int reps, float weights)
        {
            Reps = reps;
            Weights = weights;
        }

        public void SetReps(int reps)
        {
            Reps = reps;
        }

        public int GetReps()
        {
            return Reps;
        }

        public void SetWeights(float weights)
        {
            Weights = weights;
        }

        public float GetWeights()
        {
            return Weights;
        }

    }

}
