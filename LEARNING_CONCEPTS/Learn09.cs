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

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
