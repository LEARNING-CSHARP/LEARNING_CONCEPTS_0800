namespace LEARNING_CONCEPTS.Learn09
{
	public class Person
	{
		public Person(int salary)
		{
			_salary = salary;

			//Salary = salary; // Compile Error!
		}

		private int _salary;

		/// <summary>
		/// Read Only Property
		/// </summary>
		public int Salary
		{
			get
			{
				return _salary;
			}
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Person person = new Person(1000000);

			//person.Salary = 2000000; // Compile Error!

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
