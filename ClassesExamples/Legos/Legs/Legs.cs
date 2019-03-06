using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Legs
{
    abstract class Legs
    {
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        public Legs(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("Weeeeeeeeee!!!!!!!");
        }

        public void Kick(MiniFigure personToKick)
        {
            //GetType();
            //below- going to return the name of the class, the type of legs being kicked, that's what we are going to get...

            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. Ha Ha HAAA! " +
                $"You're not even a scientist.");
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} walked to the taco truck...");
        }
    }

    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
