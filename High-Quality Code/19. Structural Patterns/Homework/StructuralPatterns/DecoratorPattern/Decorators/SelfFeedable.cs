namespace DecoratorPattern.Decorators
{
    using System.Text;

    using DecoratorPattern.Models;

    internal class SelfFeedable : Decorator
    {
        internal SelfFeedable(Human human)
            : base(human)
        {
        }

        protected override void LearnActivity(int yersOfLearning)
        {
            base.Human.Age += yersOfLearning;
        }

        internal override string Introduce()
        {
            LearnActivity(2);
            StringBuilder info = new StringBuilder();
            info.Append(base.Introduce());
            info.AppendFormat("{0}- {1}", new string(' ', 3), "eat by my self");
            info.AppendLine();
            return info.ToString();
        }
    }
}
