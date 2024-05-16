namespace Learn04
{
	public class Person
	{
		public Person()
		{
		}

		public int SomeField;

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int _age;

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value >= 0 && value <= 100)
				{
					_age = value;
				}
			}
		}

		public void ShowInformation()
		{
			string message =
				$"I'm {Age} years old.";

			System.Console.WriteLine(value: message);
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		//public static void Main()
		//{
		//	System.Console.WriteLine(value: "Learn (4)");

		//	var person = new Person();

		//	person.ShowInformation();

		//	person.SomeField = 100;

		//	person.Age = 30;
		//	var age = person.Age;

		//	person.ShowInformation();

		//	person.Age = -20;

		//	person.ShowInformation();

		//	person.Age = 5_000;

		//	person.ShowInformation();

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
