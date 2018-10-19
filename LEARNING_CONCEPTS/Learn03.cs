namespace LEARNING_CONCEPTS.Learn03
{
	public class Person
	{
		public Person()
		{
		}

		private int age;

		public void SetAge(int age)
		{
			if ((age >= 0) && (age <= 100))
			{
				this.age = age;
			}
		}

		public int GetAge()
		{
			return age;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine($"I'm { GetAge() } years old.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.SetAge(30);

			person.ShowInfo();

			person.SetAge(-20);

			person.ShowInfo();

			person.SetAge(5000);

			person.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
