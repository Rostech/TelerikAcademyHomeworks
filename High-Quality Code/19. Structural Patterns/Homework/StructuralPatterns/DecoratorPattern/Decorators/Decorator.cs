namespace DecoratorPattern.Decorators
{
    using System.Text;

    using DecoratorPattern.Models;

    internal abstract class Decorator : Human
    {
        protected Decorator(Human human)
        {
            this.Human = human;
        }

        protected Human Human { get; private set; }

        protected abstract void LearnActivity(int yersOfLearning);

        internal override string Introduce()
        {
            StringBuilder info = new StringBuilder();
            info.Append(this.Human.Introduce());
            return info.ToString();
        }
    }
}
