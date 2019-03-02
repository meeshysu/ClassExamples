using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        //Properties
        public string Flavor { get; set; } //you could do 'private set' and you would not be able to change the flavor over on the Program.cs bc its no longer public.
        public string Review { get; private set; }
        public int Rating { get; private set; }
        public string Name { get; set; }
        public CandyType Type { get; set; }

        //Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10; //starting implicitly private

        //Constructor
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        //Methods
        public void SetRating(int userRating)
        {
            //what kind of control flow stuff do we need to so we can set a rating between 1-10? a conditional.

            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue} - {MaxRatingValue}. No candy for you."); //instead of a console.writeline or something like this, it alerts the user that they are stupid
            }
        }

           public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}";
        }
    

    }
    enum CandyType
    {
        Chocolate,
        HardCandy,
        Caramel,
        Sour,
        Stretchy,
        Nut
    }
}

//props usually internal and there to expose at least the ability to get stuff out and sometimes to set things.
//fields are there to store data as you care about but maybe no one else