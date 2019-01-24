namespace LEARNING_CONCEPTS.Learn03
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int age;

		public int GetAge()
		{
			return age;
		}

		public void SetAge(int age)
		{
			if ((age >= 0) && (age <= 100))
			{
				this.age = age;
			}
		}

		public void ShowInformation()
		{
			string message =
				$"I'm { GetAge() } years old.";

			System.Console.WriteLine(message);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.SetAge(30);

			person.ShowInformation();

			person.SetAge(-20);

			person.ShowInformation();

			person.SetAge(5000);

			person.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
