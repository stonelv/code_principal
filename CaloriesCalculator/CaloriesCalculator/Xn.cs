namespace CaloriesCalculator
{
    internal class Xn : Person
    {
        public Xn(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age) 
            : base(weight, heightOfFeet, heightOfInch, age)
        {
            baseCalories = 133M;
            weightFactor = 5.5M;
            heightFactor = 5.1M * 12M;
            ageFactor = 5.7M;
        }
    }
}