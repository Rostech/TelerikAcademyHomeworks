namespace DecoratorPattern.Models
{
    using System.Text;

    internal class Boy : Human
    {
        internal Boy(string name)
        {
            this.Name = name;
            this.Age = 0;
        }

        internal override string Introduce()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Boy: ");
            info.AppendLine(base.Introduce());
            return info.ToString();
        }
    }
}
