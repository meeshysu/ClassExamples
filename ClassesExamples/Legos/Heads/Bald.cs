using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Bald : Head
    {
        //Things that make up a class:
        //Properties
        public int ShineLevel { get; set; } //autoproperty
        public bool HasToupe { get; set; } //""

        //Fields
        //Constructors
        //Methods
        public void Cut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;
        }

        public override string Talk()
        {
            return "I pity the fool!";
        }
    }

    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }
}
