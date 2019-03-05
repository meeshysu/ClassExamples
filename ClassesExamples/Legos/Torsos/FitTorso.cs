using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;

namespace ClassesExamples.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Sex sex, Colors color) 
            : base(numberOfArms, sex, color, "OMG, so fitt!!!")//constructor -- no return type on this guy
        {
        }

        public void Crunch(int howManyCrunches)
        {
            FitnessOfAbs = FitnessOfAbs + " even more fit.";
            Console.WriteLine($"I just did {howManyCrunches}, brah. CROSSFIT!");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯");
        }
    }
}
