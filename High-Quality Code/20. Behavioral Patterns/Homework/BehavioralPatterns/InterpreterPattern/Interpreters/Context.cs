namespace InterpreterPattern.Interpreters
{
    public class Context
    {
        public Context(string input)
        {
            this.Input = input;
        }

        public string Input { get; set; }

        public string Output { get; set; }
    }
}
