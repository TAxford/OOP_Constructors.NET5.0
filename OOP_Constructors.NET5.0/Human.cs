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


        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        public Human(string myFirstName)
        {
            //two ways or creating this constructor
            firstName = myFirstName;
        }

        public Human(string myFirstName, string lastName)
        {
            //two ways or creating this constructor
            firstName = myFirstName;
            this.lastName = lastName;
        }

        public Human(string myFirstName, string lastName, string eyeColor)
        {
            //two ways or creating this constructor
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

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
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
            Console.WriteLine("Hi, I'm {0} {1} and am {3} years old. My eye color is {2}", firstName, lastName, eyeColor, age);
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My age is {3}", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}.", firstName);
            }
        }
    }

    
}
