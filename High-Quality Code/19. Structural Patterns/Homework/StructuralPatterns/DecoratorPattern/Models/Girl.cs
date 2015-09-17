namespace DecoratorPattern.Models
{
    using System.Text;

    internal class Girl : Human
    {
        internal Girl(string name)
        {
            this.Name = name;
            this.Age = 0;
        }

        internal override string Introduce()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Girl: ");
            info.AppendLine(base.Introduce());
            return info.ToString();
        }
    }
}
