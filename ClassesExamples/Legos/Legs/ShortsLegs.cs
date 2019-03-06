using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Legs
{
    class ShortsLegs : Legs
    {
        public ShortsLegs(Length leglength, Colors shortsColor, bool isHairy) 
            : base(leglength, shortsColor)
        {
            Hairy = isHairy;
        }
    }
}
