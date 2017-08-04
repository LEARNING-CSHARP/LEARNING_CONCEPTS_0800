namespace LEARNING_CONCEPTS.Learn09
{
	public class Person
	{
		public Person()
		{
		}

		private int _salary;

		public int Salary
		{
			get
			{
				return (_salary);
			}
		}

		public void DoSomething(int salary)
		{
			//_salary = salary;

			//Salary = salary;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
