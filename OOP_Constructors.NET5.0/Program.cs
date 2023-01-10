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


            Console.ReadKey();
        }
    }
}
