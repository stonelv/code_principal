using System;

namespace BirdsHeaven
{
    internal class Flier : IFly
    {
        private readonly Action<string, string> reportStatus;

        public Flier(Action<string, string> reportStatus)
        {
            this.reportStatus = reportStatus;
        }
        public void Fly(string time)
        {
            var action = "Flying";
            reportStatus(time, action);
        }
    }
}