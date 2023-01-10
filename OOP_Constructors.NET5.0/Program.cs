using System;

namespace OOP_Constructors.NET5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human tim = new Human("Tim", "Axford", "Blue", 37);
            tim.IntroduceMyself();

            Human becca = new Human("Becca", "Axford", "Green");
            becca.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human bob = new Human("Bob", "Baker");
            bob.IntroduceMyself();

            Human carl = new Human("Carl", "Walter", "Red", 23);
            carl.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
