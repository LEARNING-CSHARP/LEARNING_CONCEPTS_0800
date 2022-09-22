namespace Learn02
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
			//var message =
			//	$"I'm {_age} years old.";

			var message =
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

		//	//person._age = 30; // Compile Error!
		//	person.SetAge(age: 30);

		//	person.ShowInformation();

		//	//person._age = -20; // Compile Error!
		//	person.SetAge(age: -20);

		//	person.ShowInformation();

		//	//person._age = 5_000; // Compile Error!
		//	person.SetAge(age: 5_000);

		//	person.ShowInformation();

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
