namespace LEARNING_CONCEPTS.Learn01
{
	public class Person
	{
		public Person()
		{
		}

		public int Age;

		public void ShowInfo()
		{
			System.Console.WriteLine($"I'm { Age } years old.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.Age = 30;

			person.ShowInfo();

			person.Age = -20;

			person.ShowInfo();

			person.Age = 5000;

			person.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
