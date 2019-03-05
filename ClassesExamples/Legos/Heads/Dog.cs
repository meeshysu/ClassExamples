using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Dog : Head
    {
        //Properties
       

        //Fields
        //Constructors
        //Methods
        public override string Talk() //this is a method signature
        {
            return "Bark! Bark! I'm a dog head!";
        }

        public string Lick()
        {
            return "Tastes like hooman.";
        }
    }
}
