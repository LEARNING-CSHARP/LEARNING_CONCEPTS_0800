namespace LEARNING_CONCEPTS.Learn03
{
	public class Person
	{
		public Person()
		{
		}

		private int _age;

		public void SetAge(int age)
		{
			if ((age >= 0) && (age <= 100))
			{
				_age = age;
			}
		}

		public int GetAge()
		{
			return (_age);
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("I'm {0} years old.", GetAge());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			//oPerson._age = 30;
			oPerson.SetAge(30);

			oPerson.ShowInfo();

			//oPerson._age = -20;
			oPerson.SetAge(-20);

			oPerson.ShowInfo();

			//oPerson._age = 5000;
			oPerson.SetAge(5000);

			oPerson.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
