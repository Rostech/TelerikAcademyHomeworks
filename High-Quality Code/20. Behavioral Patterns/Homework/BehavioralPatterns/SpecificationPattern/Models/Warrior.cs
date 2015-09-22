namespace SpecificationPattern.Models
{
    using System;

    public class Warrior
    {
        public int Id { get; set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public bool IsAffraid { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\n Id: {1} \n Health: {2}\n Strenght: {3}\n IsAffraid: {4}\n{0}", 
                new string('-', 60), 
                this.Id, 
                this.Health,
                this.Strength,
                this.IsAffraid);
        }
    }
}
