namespace LEARNING_CONCEPTS.Learn02
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

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

		public void ShowInformation()
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

			person.ShowInformation();

			//person.age = -20;
			person.SetAge(-20);

			person.ShowInformation();

			//person.age = 5000;
			person.SetAge(5000);

			person.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
