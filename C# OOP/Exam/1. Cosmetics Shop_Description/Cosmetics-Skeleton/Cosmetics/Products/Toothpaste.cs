namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            :base(name, brand, price, gender)
        {
            this.Ingredients = string.Join(", ", Validations.ValidateIgredientsList(ingredients));
        }

        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
            private set
            {
                this.ingredients = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("\n- {0} - {1}:", base.Brand, base.Name));
            result.AppendLine(string.Format("  * Price: ${0}", base.Price));
            result.AppendLine(string.Format("  * For gender: {0}", base.Gender));
            result.Append(string.Format("  * Ingredients: {0}", this.Ingredients));

            return result.ToString();
        }
    }
}
