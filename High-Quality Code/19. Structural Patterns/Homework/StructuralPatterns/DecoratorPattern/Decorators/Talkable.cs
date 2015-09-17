namespace DecoratorPattern.Decorators
{
    using System.Text;

    using DecoratorPattern.Models;

    internal class Talkable : Decorator
    {
        internal Talkable(Human human)
            : base(human)
        {
        }

        protected override void LearnActivity(int yersOfLearning)
        {
            base.Human.Age += yersOfLearning;
        }

        internal override string Introduce()
        {
            LearnActivity(1);
            StringBuilder info = new StringBuilder();
            info.Append(base.Introduce());
            info.AppendFormat("{0}- {1}", new string(' ', 3), "talk");
            info.AppendLine();
            return info.ToString();
        }
    }
}
