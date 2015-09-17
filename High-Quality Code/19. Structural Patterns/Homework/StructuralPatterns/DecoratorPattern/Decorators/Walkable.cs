namespace DecoratorPattern.Decorators
{
    using System;
    using System.Text;

    using DecoratorPattern.Models;

    internal class Walkable : Decorator
    {
        internal Walkable(Human human) 
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
            info.AppendFormat("{0}- {1}", new string(' ', 3), "walk");
            info.AppendLine();
            return info.ToString();
        }
    }
}
