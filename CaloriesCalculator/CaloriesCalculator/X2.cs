namespace CaloriesCalculator
{
    internal class X2 : Person
    {
        public X2(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age) 
            : base(weight, heightOfFeet, heightOfInch, age)
        {
            baseCalories = 433M;
            weightFactor = 5.1M;
            heightFactor = 5.1M * 12M;
            ageFactor = 4.3M;
        }
    }
}