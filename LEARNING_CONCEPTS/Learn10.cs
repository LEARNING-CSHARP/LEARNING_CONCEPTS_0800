namespace LEARNING_CONCEPTS.Learn10
{
	public class Person
	{
		public Person(int salary)
		{
			//this.salary = salary;

			Salary = salary;
		}

		private int salary;

		public int Salary
		{
			get
			{
				return salary;
			}
			private set
			{
				salary = value;
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
