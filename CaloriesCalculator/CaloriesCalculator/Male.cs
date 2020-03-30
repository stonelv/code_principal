using System;

namespace CaloriesCalculator
{
    internal class Male : Person
    {
        public Male(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age) 
            : base(weight, heightOfFeet, heightOfInch, age)
        {
            baseCalories = 66M;
            weightFactor = 6.3M;
            heightFactor = 12.9M * 12M;
            ageFactor = 6.8M;
        }
    }
}