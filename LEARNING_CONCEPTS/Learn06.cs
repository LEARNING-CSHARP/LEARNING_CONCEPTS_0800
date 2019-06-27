namespace LEARNING_CONCEPTS.Learn06
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		// Traditional
		//private int age;

		//public int Age
		//{
		//	get
		//	{
		//		return age;
		//	}
		//	set
		//	{
		//		age = value;
		//	}
		//}

		// Modern
		public int Age { get; set; }

		// Snippet: Prop, PropFull
		public string FirstName { get; set; }

		//public int SomeProperty1 { set; }
		public int SomeProperty2 { get; }

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

			person.Age = 30;

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
