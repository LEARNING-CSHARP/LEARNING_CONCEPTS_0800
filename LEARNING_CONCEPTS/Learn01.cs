namespace LEARNING_CONCEPTS.Learn01
{
	public class Person
	{
		public Person()
		{
		}

		public int Age;

		public void ShowInfo()
		{
			System.Console.WriteLine("I'm {0} years old.", Age);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			oPerson.Age = 30;

			oPerson.ShowInfo();

			oPerson.Age = -20;

			oPerson.ShowInfo();

			oPerson.Age = 5000;

			oPerson.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
