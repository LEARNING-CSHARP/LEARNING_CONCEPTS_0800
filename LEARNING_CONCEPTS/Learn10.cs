namespace LEARNING_CONCEPTS.Learn10
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
			private set
			{
				_salary = value;
			}
		}

		public void DoSomething(int salary)
		{
			//_salary = salary;

			Salary = salary;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			//oPerson.Salary = 1000;

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
