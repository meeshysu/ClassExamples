using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Astronaut : Head //can only have an inheritance relationship with one thing
    {
        //Properties

        public List<string> Accessories { get; set; }

        //Methods
        public override string Talk()
        {
            //base.Talk();

            return $"Houson we have a problem... I have {HairLength} " +
                   $"long hair and I'm {Color} and my ears are {EarSize}";
        }
    }
}
