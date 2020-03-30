namespace BirdsHeaven
{
    internal class Penguin : Bird, ISwim, IProgram
    {
        private readonly Swimer swimmer;
        private readonly Programer programer;

        public Penguin()
        {
            swimmer = new Swimer(PrintScheduleInfo);
            programer = new Programer(PrintScheduleInfo);
        }

        public void programing(string time)
        {
            programer.programing(time);
        }

        internal override string GetName()
        {
            return "Penguin";
        }

        void ISwim.Swim(string time)
        {
            swimmer.Swim(time); 
        }
    }
}