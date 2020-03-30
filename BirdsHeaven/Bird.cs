using System;

namespace BirdsHeaven
{
    internal class Bird
    {
        internal void Perform(string time)
        {
            var action = "performing";
            PrintScheduleInfo(time, action);
        }

        internal void Eat(string time)
        {
            var action = "eating";
            PrintScheduleInfo(time, action);
        }

        internal void PrintScheduleInfo(string time, string action)
        {
            Console.WriteLine(string.Format("It's {0}, I'm {1}, I'm {2}.", time, this.GetName(), action));
        }

        internal virtual string GetName()
        {
            return "Bird";
        }

        internal void Walk(string time)
        {
            string action = "walking";
            PrintScheduleInfo(time, action);
        }
    }
}