namespace DecoratorPattern.Models
{
    using System.Text;

    internal abstract class Human
    {
        internal int Age { get; set; }

        internal string Name { get; set; }

        internal virtual string Introduce()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat(" Name: {0}", this.Name);
            info.AppendLine();
            info.AppendFormat(" Age: {0}", this.Age);
            info.AppendLine();
            info.Append("  I can: ");
            return info.ToString();
        }
    }
}
