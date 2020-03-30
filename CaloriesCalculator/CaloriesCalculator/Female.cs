using System;

namespace CaloriesCalculator
{
    internal class Female : Person
    {
        public Female(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age) 
            : base(weight, heightOfFeet, heightOfInch, age)
        {
            baseCalories = 655M;
            weightFactor = 4.3M;
            heightFactor = 4.7M * 12M;
            ageFactor = 4.7M;
        }

    }
}