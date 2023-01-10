using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructors.NET5._0
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            //two ways or creating this constructor
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1} {2} {3}", firstName, lastName, eyeColor, age);
        }
    }

    
}
