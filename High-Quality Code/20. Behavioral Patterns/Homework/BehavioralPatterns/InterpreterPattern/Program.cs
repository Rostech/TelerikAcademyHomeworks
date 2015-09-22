using InterpreterPattern.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var emojiInterpreter = new EmojiInterpreter();

            var context = new Context(":)");
            emojiInterpreter.Interpret(context);

            context = new Context(":(");
            emojiInterpreter.Interpret(context);
            context = new Context(";(");
            emojiInterpreter.Interpret(context);
            context = new Context(";)");
            emojiInterpreter.Interpret(context);
        }
    }
}
