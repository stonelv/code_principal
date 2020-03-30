using System;

namespace BirdsHeaven
{
    internal class Builder : IBuild
    {
        private Action<string, string> printScheduleInfo;

        public Builder(Action<string, string> printScheduleInfo)
        {
            this.printScheduleInfo = printScheduleInfo;
        }

        public void build(string time)
        {
            string action = "building";
            printScheduleInfo(time, action);
        }
    }
}