using System.Collections.Generic;

namespace CaloriesCalculator
{
    internal static class PersonFactors
    {
        private static Dictionary<string, PersonFactor> factorDictionary;

        static PersonFactors()
        {
            factorDictionary = new Dictionary<string, PersonFactor>();
            factorDictionary.Add("Female", 
                new PersonFactor() { baseCalories = 655M, heightFactor= 4.7M * 12M, weightFactor= 4.3M, ageFactor= 4.7M });
            factorDictionary.Add("Male", 
                new PersonFactor() { baseCalories = 66M, heightFactor= 12.9M * 12M, weightFactor= 6.3M, ageFactor= 6.8M }); 
            factorDictionary.Add("X1", 
                new PersonFactor() { baseCalories = 655M, heightFactor= 4.7M * 12M, weightFactor= 4.3M, ageFactor= 4.7M }); 
            factorDictionary.Add("X2", 
                new PersonFactor() { baseCalories = 655M, heightFactor= 4.7M * 12M, weightFactor= 4.3M, ageFactor= 4.7M }); 
            factorDictionary.Add("X3", 
                new PersonFactor() { baseCalories = 655M, heightFactor= 4.7M * 12M, weightFactor= 4.3M, ageFactor= 4.7M }); 
        }
        public static PersonFactor GetPersonFactor(string sexName)
        {
            return factorDictionary[sexName];
        }
    }
}