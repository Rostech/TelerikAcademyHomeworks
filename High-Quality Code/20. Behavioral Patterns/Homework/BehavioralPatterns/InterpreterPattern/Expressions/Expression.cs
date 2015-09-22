namespace InterpreterPattern.Expressions
{
    using System;

    using InterpreterPattern.Interpreters;

    public class Expression
    {
        public void Interpret(Context context)
        {
            if(context.Input.Length <= 1)
            {
                return;
            }

            if(context.Input.StartsWith(this.Colon()))
            {
                var secondPart = context.Input[1].ToString();

                if (secondPart == this.ClosingBracket())
                {
                    context.Output = "Smiley face";
                }
                else if (secondPart == this.OppeningBracket())
                {
                    context.Output = "Sad face";
                }
            }
            else if(context.Input.StartsWith(this.Semicolon()))
            {
                var secondPart = context.Input[1].ToString();

                if (secondPart == this.ClosingBracket())
                {
                    context.Output = "Winkey face";
                }
                else if(secondPart == this.OppeningBracket())
                {
                    context.Output = "Crying face";
                }
            }
            else
            {
                // The application will be extended to support all 
                // possible emoji's :D
                throw new NotImplementedException();
            }
        }

        protected string Semicolon()
        {
            return ";";
        }

        protected string Colon()
        {
            return ":";
        }

        protected string ClosingBracket()
        {
            return ")";
        }

        protected string OppeningBracket()
        {
            return "(";
        }
    }
}
