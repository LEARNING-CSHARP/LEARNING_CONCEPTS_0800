namespace LEARNING_CONCEPTS.Learn04
{
	public class Person
	{
		public Person()
		{
		}

		public int SomeField;

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int age;

		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				if ((value >= 0) && (value <= 100))
				{
					age = value;
				}
			}
		}

		public void ShowInformation()
		{
			string message =
				$"I'm { Age } years old.";

			System.Console.WriteLine(message);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.ShowInformation();

			//person.SomeField

			person.Age = 30;
			int googooli = person.Age;

			person.ShowInformation();

			person.Age = -20;

			person.ShowInformation();

			person.Age = 5000;

			person.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
