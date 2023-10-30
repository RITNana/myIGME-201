using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_Codes
{

    public interface IHobby
    {
        void Hobby();
        
    }

    public interface IWorkout
    {
        void Workout();
    }

    public abstract class Exercise
    {
        public string exerciseChoice;

        public string ExerciseChoice
        {
            get { return exerciseChoice; }
        }

        public abstract void Push();

        public virtual void Pull()
        {
           Console.WriteLine("I love doing Pull Days!");
        }
    }

    public class Gym : Exercise
    {
        public override void Push()
        {
           Console.WriteLine("I love doing Push Days at the gym!");
        }

        public override void Pull()
        {
           Console.WriteLine("I love doing Pul Days at the gym!");
        }
    }

    public class Outside : Exercise
    {
        public override void Push()
        {
            Console.WriteLine("I love doing Push-Ups!");
        }

        public override void Pull()
        {
            Console.WriteLine("I love doing Pull-Ups!");
        }
    }

    internal class Hobby
    {
        static void Main(string[] args)
        {
            
            Outside outside = new Outside();
            Gym gym = new Gym();
            MyMethod(gym);
            MyMethod(outside);
           
           
            
        }

        static void MyMethod(object obj)
        {
            Exercise exercise = (Exercise)obj;  
            exercise.Push();

            IWorkout workout = (IWorkout)obj;
            workout.Workout();

            if (obj.GetType() == typeof(Gym))
            {
                Gym gym = (Gym)obj;
                gym.Pull();

            } else
            {
                Outside outside = (Outside)obj;
                outside.Push();
            }


        }
    }
} 
