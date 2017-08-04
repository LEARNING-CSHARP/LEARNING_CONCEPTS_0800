namespace LEARNING_CONCEPTS.Learn04
{
	public class Person
	{
		public Person()
		{
		}

		public int SomeField;

		private int _age;

		public int Age
		{
			get
			{
				return (_age);
			}
			set
			{
				if ((value >= 0) && (value <= 100))
				{
					_age = value;
				}
			}
		}

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

			//oPerson.SomeField

			//oPerson._age = 30;
			oPerson.Age = 30;

			oPerson.ShowInfo();

			//oPerson._age = -20;
			oPerson.Age = -20;

			oPerson.ShowInfo();

			//oPerson._age = 5000;
			oPerson.Age = 5000;

			oPerson.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
