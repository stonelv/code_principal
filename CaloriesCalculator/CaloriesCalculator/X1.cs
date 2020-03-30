namespace CaloriesCalculator
{
    internal class X1 : Person
    {
        public X1(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age) 
            : base(weight, heightOfFeet, heightOfInch, age)
        {
            baseCalories = 333M;
            weightFactor = 5.3M;
            heightFactor = 5.7M * 12M;
            ageFactor = 4.7M;
        }
    }
}