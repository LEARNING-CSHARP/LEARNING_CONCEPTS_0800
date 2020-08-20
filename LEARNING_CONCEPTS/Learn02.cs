namespace LEARNING_CONCEPTS.Learn02
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int _age;

		/// <summary>
		/// Getter
		/// </summary>
		public int GetAge()
		{
			return _age;
		}

		/// <summary>
		/// Setter
		/// </summary>
		public void SetAge(int age)
		{
			_age = age;
		}

		public void ShowInformation()
		{
			//string message =
			//	$"I'm { _age } years old.";

			string message =
				$"I'm { GetAge() } years old.";

			System.Console.WriteLine(message);
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Person person = new Person();

			person.ShowInformation();

			//person._age = 30; // Compile Error!
			person.SetAge(30);

			person.ShowInformation();

			//person._age = -20; // Compile Error!
			person.SetAge(-20);

			person.ShowInformation();

			//person._age = 5000; // Compile Error!
			person.SetAge(5000);

			person.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
