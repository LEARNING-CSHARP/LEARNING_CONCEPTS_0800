namespace LEARNING_CONCEPTS.Learn08
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
				if ((value >= 0) && (value <= 100))
				{
					_age = value;
				}
			}
		}

		public void DoSomething(int age)
		{
			//_age = age;

			//if ((age >= 0) && (age <= 100))
			//{
			//	_age = age;
			//}

			Age = age;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person oPerson = new Person();

			oPerson.Age = 30;
			oPerson.Age = -20;
			oPerson.DoSomething(40);
			oPerson.DoSomething(-30);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
