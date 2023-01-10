using System;

namespace OOP_Constructors.NET5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner");
            sissy.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
