using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge3
{
    internal class Sets
    {
        private string repetitions;
        private string weights;
        public Sets(string repetitions, string weights)
        {
            this.repetitions = repetitions;
            this.weights = weights;
        }
        public Sets() { }

        public void SetRepetition(string repetition)
        {
            repetitions = repetition;
        }
        public void SetWeights(string weights)
        {
            this.weights = weights;
        }
        public string GetRepetition()
        {
            return repetitions;
        }
        public string GetWeights()
        {
            return weights;
        }
    }
}
