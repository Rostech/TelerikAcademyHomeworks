namespace InterpreterPattern.Interpreters
{
    using System;

    using InterpreterPattern.Expressions;

    public class EmojiInterpreter
    {
        private readonly Expression expression;

        public EmojiInterpreter()
        {
            this.expression = new Expression();
        }

        public void Interpret(Context context)
        {
            this.expression.Interpret(context);
            Console.WriteLine("Current context: Input = {0} Output = {1}", context.Input, context.Output);
        }
    }
}
