﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;

namespace ClassesExamples.Legos.Torsos
{
    abstract class Torso
    {
        public int NumberOfArms { get; protected set; }
        public string FitnessOfAbs { get; protected set; }
        public Sex Sex { get; protected set; }
        public Colors Color { get; protected set; }

        protected Torso(int numberOfArms, Sex sex, Colors color, string fitnessOfAbs)//this is an example of a constructor inside the main class
        {
            NumberOfArms = numberOfArms;
            Sex = sex;
            Color = color;
            FitnessOfAbs = fitnessOfAbs;
        }

        public virtual void Wave()
        {
            Console.WriteLine(@"Waves hello 0/");
        }
    }

    internal enum Sex
    {
        Male,
        Female,
        Other,
        Shrug 
    }
}
