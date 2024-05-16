namespace Learn06
{
	public class Person
	{
		#region Constructor
		public Person()
		{
		}
		#endregion /Constructor

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		// Traditional
		//private int _age;

		//public int Age
		//{
		//	get
		//	{
		//		return _age;
		//	}
		//	set
		//	{
		//		_age = value;
		//	}
		//}

		// Modern
		public int Age { get; set; }

		// Snippet: Prop, PropFull
		public string FirstName { get; set; }

		//public int SomeProperty1 { set; }

		public int SomeProperty2 { get; }

		#region public int Salary { get; set; }
		private int _salary;

		/// <summary>
		/// 
		/// </summary>
		public int Salary
		{
			get
			{
				return _salary;
			}
			set
			{
				_salary = value;
			}
		}
		#endregion /public int Salary { get; set; }

		#region ShowInformation()
		public void ShowInformation()
		{
			string message =
				$"I'm {Age} years old.";

			System.Console.WriteLine(value: message);
		}
		#endregion /ShowInformation()
	}

	public static class Program
	{
		static Program()
		{
		}

		//public static void Main()
		//{
		//	System.Console.WriteLine(value: "Learn (6)");

		//	var person = new Person();

		//	person.Age = 30;

		//	person.ShowInformation();

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
