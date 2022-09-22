namespace Learn08
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
				if (value >= 0 && value <= 100)
				{
					_age = value;
				}
			}
		}

		public void DoSomething(int age)
		{
			// **************************************************
			//_age = age;
			// **************************************************

			// **************************************************
			//if (age >= 0 && age <= 100)
			//{
			//	_age = age;
			//}
			// **************************************************

			// **************************************************
			Age = age;
			// **************************************************
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			var person = new Person();

			person.Age = 30;
			person.Age = -20;
			person.Age = 5_000;

			person.DoSomething(age: 30);
			person.DoSomething(age: -20);
			person.DoSomething(age: 5_000);

			System.Console.Write
				(value: "Press [ENTER] To Exit... ");

			System.Console.ReadLine();
		}
	}
}
