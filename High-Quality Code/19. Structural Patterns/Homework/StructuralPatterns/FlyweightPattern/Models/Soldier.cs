namespace FlyweightPattern.Models
{
    using System.Text;
    using FlyweightPattern.Utils;

    internal abstract class Soldier
    {
        protected string Name { get; set; }

        protected Rank Rank { get; set; }

        protected Weapon Weapon { get; set; }

        protected int NumberOfBuletts { get; set; }

        public virtual string SoldierInfo(int number)
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("{0}", new string('-', 60));
            info.AppendLine();
            info.AppendFormat("Soldier number: " + number);
            info.AppendLine();
            info.AppendFormat("Name: {0}", this.Name);
            info.AppendLine();
            info.AppendFormat("Rank: {0}", this.Rank);
            info.AppendLine();
            info.AppendFormat("Weapon: {0}", this.Weapon);
            info.AppendLine();
            info.AppendFormat("Number of bullets: {0}", this.NumberOfBuletts);
            info.AppendLine();
            return info.ToString();
        }
    }
}
