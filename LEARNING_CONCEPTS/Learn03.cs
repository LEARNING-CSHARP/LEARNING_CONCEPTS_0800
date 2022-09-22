namespace Learn03
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int _age;

		public int GetAge()
		{
			return _age;
		}

		public void SetAge(int age)
		{
			if (age >= 0 && age <= 100)
			{
				_age = age;
			}
		}

		public void ShowInformation()
		{
			string message =
				$"I'm {GetAge()} years old.";

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
		//	var person = new Person();

		//	person.ShowInformation();

		//	person.SetAge(age: 30);

		//	person.ShowInformation();

		//	person.SetAge(age: -20);

		//	person.ShowInformation();

		//	person.SetAge(age: 5_000);

		//	person.ShowInformation();

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
