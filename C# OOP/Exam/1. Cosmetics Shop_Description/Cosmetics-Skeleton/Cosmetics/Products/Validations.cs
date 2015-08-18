namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;

    public static class Validations
    {
        public static bool ValidateName(string input, int minLength, int maxLength, string message)
        {
            if(string.IsNullOrEmpty(input))
            {
                return false;
                throw new ArgumentNullException("Name cannot be null or empty!");
            }
            if (input.Length < minLength || input.Length > maxLength)
            {
                Console.WriteLine(message);
                return false;
            }
            return true;
        }

        public static IList<string> ValidateIgredientsList(IList<string> ingredients)
        {
            IList<string> result = new List<string>();
            foreach(var ingredient in ingredients)
            {
                if (ValidateName(ingredient, 4, 12, string.Format("Each ingredient must be between {0} and {1} symbols long!", 4, 12)))
                    result.Add(ingredient);
            }
            return result;
        }
    }
}
