using System;

namespace CaloriesCalculator
{
    internal class PersonFactory
    {
        private string sexName;

        public PersonFactory(string sexName)
        {
            this.sexName = sexName;
        }

        internal Person CreatePerson(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age)
        {
            Person person = null;
            switch (sexName)
            {
                case "Male":
                    person = new Male(weight, heightOfFeet, heightOfInch, age);
                    break;
                case "Female":
                    person = new Female(weight, heightOfFeet, heightOfInch, age);
                    break;
                case "X1":
                    person = new X1(weight, heightOfFeet, heightOfInch, age);
                    break;
                case "X2":
                    person = new X2(weight, heightOfFeet, heightOfInch, age);
                    break;
                case "Xn":
                    person = new Xn(weight, heightOfFeet, heightOfInch, age);
                    break;
            }
            return person;
        }
    }
}