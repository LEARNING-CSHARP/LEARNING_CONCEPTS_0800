namespace Learn01
{
	public class Person
	{
		public Person()
		{
		}

		public int Age;

		public void ShowInformation()
		{
			var message =
				$"I'm {Age} years old.";

			System.Console.WriteLine(value: message);
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			var person = new Person();

			person.ShowInformation();

			person.Age = 30;

			person.ShowInformation();

			person.Age = -20;

			person.ShowInformation();

			person.Age = 5_000;
			//person.Age = 5000;

			person.ShowInformation();

			System.Console.Write
				(value: "Press [ENTER] To Exit... ");

			System.Console.ReadLine();
		}
	}
}
