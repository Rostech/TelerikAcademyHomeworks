namespace FormattingEvents.FormattedCode
{
    internal static class Messages
    {
        public static void EventAdded()
        { 
            StartProgram.Output.Append("Event added\n"); 
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                StartProgram.Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound() 
        { 
            StartProgram.Output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                StartProgram.Output.Append(eventToPrint + "\n");
            }
        }
    }
}
