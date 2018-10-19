namespace LEARNING_CONCEPTS.Learn02
{
	public class Person
	{
		public Person()
		{
		}

		private int age;

		public void SetAge(int age)
		{
			//age = age;

			this.age = age;
		}

		public int GetAge()
		{
			//return this.age;

			return age;
		}

		public void ShowInfo()
		{
			//System.Console.WriteLine($"I'm { age } years old.");

			System.Console.WriteLine($"I'm { GetAge() } years old.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			//person.age = 30;
			person.SetAge(30);

			person.ShowInfo();

			//person.age = -20;
			person.SetAge(-20);

			person.ShowInfo();

			//person.age = 5000;
			person.SetAge(5000);

			person.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
