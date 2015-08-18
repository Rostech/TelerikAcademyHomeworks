namespace NamingIdentifiers
{
    using NamingIdentifiers.Task01;
    using NamingIdentifiers.Task02;
    using NamingIdentifiers.Task04;

    internal class StartingPoint
    {
        public static void Main(string[] args)
        {
            // This is the result from the first task
            PrimitveType.OperationsOnBoolean();

            // This is the result from the second task
            PersonActions personActions = new PersonActions();
            personActions.MakePerson(23);
            personActions.MakePerson(32);

            // The result from the third task cannot be included
            // in this solution but the code can, so you can find
            // it in the solution explorer. 
            // Important! If you have JS Lint installed the project
            // may not run due to JSLind validation errors. 
            // Go to TOOLS > JS Lint Options... > uncheck
            // Cancel build on error

            // This is the result from the fourth task
            MinesGame.Engine();
        }
    }
}
