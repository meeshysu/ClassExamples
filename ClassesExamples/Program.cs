using System;

namespace ClassesExamples
{
    class Program
    {
        private static void Main(string[] args)
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10); //calling this from the other page

            Console.WriteLine(taffy);

            Console.WriteLine("Hello World!");
        }
    }
}

//namespace ClassesExamples
//{
//    class Program
//    {
//        string _myData = "this is just for me to use";
//        //convention to use an underscore.

//        public int Number { get; set; }
//        //someone can call and set this property
//        // get/set is an auto property

//        public void DotheThing()
//        {
//            Number = 1;
//            var x = Number;
//        }

//        static void Main(string[] args) //this type of code block is a method 
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//var x = new string('a', 1); //this is instantiating 'new'
