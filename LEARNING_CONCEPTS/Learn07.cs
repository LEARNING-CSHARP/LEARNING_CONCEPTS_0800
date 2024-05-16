namespace Learn07
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
				return _age;
			}
			set
			{
				_age = value;
			}
		}

		public void DoSomething()
		{
			_age = 30; // Field آیا قطعا و همیشه از
			Age = 30; // Property آیا قطعا و همیشه از
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		//public static void Main()
		//{
		//	System.Console.WriteLine(value: "Learn (7)");

		//	var person = new Person();

		//	person.Age = 30;
		//	//person.age = 30;

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
