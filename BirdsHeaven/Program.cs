using System;
using System.Collections.Generic;

namespace BirdsHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            var birds = new List<Bird> { 
                new WildGoose(), 
                new Swallow(),
                new Penguin() };

            birds.ForEach(bird =>
            {
                string time = "7:00";
                bird.Eat(time);

                time = "8:00";
                bird.Walk(time);

                time = "9:00";
                bird.Perform(time);

                time = "10:00";
                if (bird is IFly flier) flier.Fly(time);

                time = "11:00";
                if (bird is ISwim swimmer) swimmer.Swim(time);

                time = "13:00";
                if (bird is IProgram program) program.programing(time);

                time = "15:00";
                if (bird is IBuild build) build.build(time);
            });
              
        }
    }
}
