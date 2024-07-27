using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Next 8 lines Shows aggregation relationship between exercises and sets.
            Exercise SetList = new Exercise();
            Sets sets = new Sets("5" ,"10KG");
            Sets sets2 = new Sets("3", "20KG");
            List<Sets> NewSets = new List<Sets>();
            NewSets.Add(sets);
            NewSets.Add(sets2);
            SetList.Set_Sets(NewSets);
            Console.WriteLine($"{NewSets[0].GetRepetition()}\t{NewSets[1].GetWeights()} ");
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            //Next lines Shows  composition relationship between a workout routine and its  exercises
            User_workout user = new User_workout();
            user.AddExercise("Monday","PushUp", NewSets);
            List<Exercise> NewExercise = user.GetExerciseList();
            List<Sets> NewSet = NewExercise[0].Get_Sets();
            user.SetUserName("Tayyab");
            user.SetUserID("A1");
            Console.WriteLine($"{user.GetUserName()}\t{ NewExercise[0].GetExerciseName()}\t{NewExercise[0].GetExerciseDay()} \t{ NewSet[0].GetRepetition()}");

            Console.ReadLine();
            


        }
    }
}
