namespace T4TemplateExample
{
	public class TestTemplate
	{
		private void Tuesday()
		{
			System.Console.WriteLine("Today is {0}", System.DateTime.Now.DayOfWeek);
		}
	
		public void Creeting()
		{
			string ho = "";
								ho += "Ho, ";
									ho += "Ho, ";
					
			ho += "Ho. :) ";
	
			System.Console.WriteLine("Hello, World. {0}", ho);
			Tuesday();
		}
	}
}