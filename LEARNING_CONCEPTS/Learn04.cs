namespace LEARNING_CONCEPTS.Learn04
{
	public class Person
	{
		public Person()
		{
		}

		public int SomeField;

		private int age;

		public int Age
		{
			get
			{
				return (age);
			}
			set
			{
				if ((value >= 0) && (value <= 100))
				{
					age = value;
				}
			}
		}

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

			//person.SomeField

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
