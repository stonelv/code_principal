using System;

namespace BirdsHeaven
{
    internal class Swimer : ISwim
    {
        private readonly Action<string, string> reportStatus;

        public Swimer(Action<string, string> reportStatus)
        {
            this.reportStatus = reportStatus;
        }
        public void Swim(string time)
        {
            var action = "swimming";
            this.reportStatus(time, action);
        }
    }
}