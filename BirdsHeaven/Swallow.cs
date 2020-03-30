namespace BirdsHeaven
{
    internal class Swallow : Bird, IFly, IBuild
    {
        private readonly Flier flier;
        private readonly Builder builder;

        public Swallow()
        {
            flier = new Flier(PrintScheduleInfo);
            builder = new Builder(PrintScheduleInfo);
        }

        public void build(string time)
        {
            builder.build(time);
        }

        internal override string GetName()
        {
            return "Swallow";
        }

        void IFly.Fly(string time)
        {
            flier.Fly(time);
        }
    }
}