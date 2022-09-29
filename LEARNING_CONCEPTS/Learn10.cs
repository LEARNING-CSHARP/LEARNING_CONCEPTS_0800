namespace Learn10
{
	public class Person
	{
		public Person(int salary)
		{
			//_salary = salary;

			Salary = salary;
		}

		private int _salary;

		/// <summary>
		/// اضافه شد .NET Framework 2.0 این امکان در
		/// </summary>
		public int Salary
		{
			get
			{
				return _salary;
			}
			private set
			{
				_salary = value;
			}
		}

		//public int Salary { get; private set; }
	}

	public static class Program
	{
		static Program()
		{
		}

		//public static void Main()
		//{
		//	var person =
		//		new Person(salary: 1_000_000);

		//	person.Salary = 2_000_000; // Compile Error!

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
