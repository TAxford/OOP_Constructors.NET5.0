using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructors.NET5._0
{
    internal class Human
    {
        string firstName;
        string lastName;

        //constructor
        public Human(string myFirstName, string lastName)
        {
            //two ways or creating this constructor
            firstName = myFirstName;
            this.lastName = lastName;
        }



        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }

    
}
