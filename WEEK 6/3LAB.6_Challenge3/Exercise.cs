using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge3
{
    internal class Exercise
    {
        private string ExerciseDay;
        private string ExerciseName;
        private List<Sets> NewSets = new List<Sets>();
        public Exercise(string exerciseDay, string exerciseName, List<Sets> newSets)
        {
            ExerciseDay = exerciseDay;
            ExerciseName = exerciseName;
            NewSets = newSets;
        }
        public Exercise() { }
        public void SetExerciseDay(string exerciseDay)
        {
            ExerciseDay = exerciseDay;
        }
        public string GetExerciseDay()
        {
            return ExerciseDay;
        }
        public void SetExerciseName(string exerciseName)
        { 
            ExerciseName = exerciseName; 
        }
        public string GetExerciseName()
        {
            return ExerciseName;
        }
        public void Set_Sets(List<Sets> newSets)
        {
            NewSets = newSets;
        }
        public List<Sets> Get_Sets()
        {
            return NewSets; 
        } 

    }
}
