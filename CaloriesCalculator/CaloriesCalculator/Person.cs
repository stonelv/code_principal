using System;

namespace CaloriesCalculator
{
    internal class Person
    {
        protected decimal baseCalories;
        protected decimal weightFactor;
        protected decimal heightFactor;
        protected decimal ageFactor;
        protected decimal weight;
        protected decimal heightOfFeet;
        protected decimal heightOfInch;
        protected decimal age;

        public Person(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age)
        {
            this.weight = weight;
            this.heightOfFeet = heightOfFeet;
            this.heightOfInch = heightOfInch;
            this.age = age;
        }

        public decimal CalculateCalories()
        {
            return baseCalories
                + weightFactor * weight
                + heightFactor * (heightOfFeet + heightOfInch)
                - ageFactor * age;
        }

        internal decimal CalculateCalories(PersonFactor personFactor)
        {
            return personFactor.baseCalories
                + personFactor.weightFactor * weight
                + personFactor.heightFactor * (heightOfFeet + heightOfInch)
                - personFactor.ageFactor * age;
        }
    }
}