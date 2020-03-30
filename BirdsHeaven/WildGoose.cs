using System;

namespace BirdsHeaven
{
    internal class WildGoose : Bird, IFly, ISwim
    {
        private readonly Flier flier;
        private readonly Swimer swimer;

        public WildGoose()
        {
            flier = new Flier(PrintScheduleInfo);
            swimer = new Swimer(PrintScheduleInfo);
        }
        internal override string GetName()
        {
            return "WildGoose";
        }

        void IFly.Fly(string time)
        {
            flier.Fly(time);
        }

        void ISwim.Swim(string time)
        {
            swimer.Swim(time);
        }
    }
}