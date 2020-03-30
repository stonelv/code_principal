using System;

namespace BirdsHeaven
{
    internal class Programer : IProgram
    {
        private Action<string, string> printScheduleInfo;

        public Programer(Action<string, string> printScheduleInfo)
        {
            this.printScheduleInfo = printScheduleInfo;
        }

        public void programing(string time)
        {
            var action = "programing";
            printScheduleInfo(time, action);
        }
    }
}