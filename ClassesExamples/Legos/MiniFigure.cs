using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class MiniFigure
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }
        //legs

        public MiniFigure(Head head, Torso body)
        {
            Head = head;
            Body = body;
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
