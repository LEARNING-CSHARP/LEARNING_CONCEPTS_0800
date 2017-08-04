namespace LEARNING_CONCEPTS.Learn07
{
	public class Person
	{
		public Person()
		{
		}

		private int _age;

		public int Age
		{
			get
			{
				return (_age);
			}
			set
			{
				_age = value;
			}
		}

		public void DoSomething()
		{
			Age = 30;
			_age = 30;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			//oPerson._age = 30;
			oPerson.Age = 30;

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
