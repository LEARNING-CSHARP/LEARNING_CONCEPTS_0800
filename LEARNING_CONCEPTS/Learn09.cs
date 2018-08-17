namespace LEARNING_CONCEPTS.Learn09
{
	public class Person
	{
		public Person(int salary)
		{
			this.salary = salary;

			//Salary = salary; // Compile Error!
		}

		private int salary;

		/// <summary>
		/// Read Only Property
		/// </summary>
		public int Salary
		{
			get
			{
				return (salary);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person(1000000);

			//person.Salary = 2000000; // Compile Error!

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
