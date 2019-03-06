using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class MiniFigure
    {
        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public Legs.Legs Legs { get; set; }

        //we have a namespace named legs and a type named legs. bc C# is 
        //strongly typed, it needs to know what you are talking about. bc those two things have the same name, \
        //C# doesn't know what you are talking about -namespace or type
        //doing legs.legs -- this is the namespace and this is the class. if we were to just do ONE legs, 
        //you would get an error. 'using' would not solve the problem. you have to disambiguate it. (sp lol)

        /// <summary>
        /// Construct a minifigure
        /// </summary>
        /// <param name="head">Takes and instance of Head, the base class for all heads.
        /// Because all heads inherit from Head any head can be passed in to the minifigure.</param>
        /// <param name="body">Takes an instance of Torso, the base class for all Torsos.  Because all heads inherit from this,
        /// any head can be passed in to the minifigure.</param>

        public MiniFigure(string name, Head head, Torso body, Legs.Legs legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = Legs;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest()
        //}

        public void Greet()
        {
            Head.Talk();
            Body.Wave();
        }
    }
}
