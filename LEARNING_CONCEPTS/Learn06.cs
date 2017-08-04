namespace LEARNING_CONCEPTS.Learn06
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		// Traditional
		//private int _age;

		//public int Age
		//{
		//	get
		//	{
		//		return (_age);
		//	}
		//	set
		//	{
		//		_age = value;
		//	}
		//}

		// Modern
		public int Age { get; set; }

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

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
