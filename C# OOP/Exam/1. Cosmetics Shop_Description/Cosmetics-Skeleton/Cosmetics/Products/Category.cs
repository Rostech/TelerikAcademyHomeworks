namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private const int ErrorNameMax = 15;
        private const int ErrorNameMin = 2;

        private string name;
        private ICollection<IProduct> collection;

        public Category(string name)
        {
            this.Name = name;
            this.collection = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.CheckIfStringLengthIsValid(value, ErrorNameMax, ErrorNameMin, string.Format("Category name must be between {0} and {1} symbols long!", ErrorNameMin, ErrorNameMax));
                this.name = value;
            }
        }

        public ICollection<IProduct> Collection
        {
            get
            {
                return new List<IProduct>(this.collection);
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            this.collection.Add(cosmetics);
            this.collection =
                this.collection.OrderBy(c => c.Brand)
                .ThenByDescending(c => c.Price)
                .ToList();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            try
            {
                if(this.collection.Remove(cosmetics))
                {
                    // item is removed from the collection
                }
                else
                {
                    MissingMemberException missingMember = 
                        new MissingMemberException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
                    throw missingMember;
                }
            }
            catch(MissingMemberException m)
            {
                Console.WriteLine(m.Message);
            }
        }

        public string Print()
        {

            StringBuilder result = new StringBuilder();
            if (this.collection.Count != 1)
            {

                result.Append(string.Format("{0} category - {1} {2} in total"
                    , this.Name, this.collection.Count, this.collection.Count != 1 ? "products" : "product"));

                result.Append(string.Join("", this.collection));
            }
            else
            {

                result.Append(string.Format("{0} category - {1} {2} in total"
                    , this.Name, this.collection.Count, this.collection.Count != 1 ? "products" : "product"));

                result.Append(string.Join("", this.collection));
            }

            return result.ToString();
        }
    }
}
