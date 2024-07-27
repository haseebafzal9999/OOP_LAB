using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge3
{
    internal class User_workout
    {
        private String UserName;
        private String UserID;
        private List<Exercise> ExerciseList = new List<Exercise>();

        public User_workout(string userName, string userID, List<Exercise> ExerciseList)
        {
            UserName = userName;
            UserID = userID;
            this.ExerciseList = ExerciseList;
        }
        public User_workout() { }

        public void SetUserName(String userName)
        {
            UserName = userName;
        }
        public void SetUserID(String userID)
        {
            UserID = userID;
        }
        public string GetUserName()
        {
            return UserName;
        }
        public String GetUserID()
        {
            return UserID;
        }
        public void AddExercise(string exerciseDay, string exerciseName, List<Sets> newSets) 
        { 
            Exercise newExercise = new Exercise(exerciseDay , exerciseName , newSets);
            ExerciseList.Add(newExercise);
        }
        public List<Exercise> GetExerciseList()
        {
            return ExerciseList;
        }


    
    }
}
