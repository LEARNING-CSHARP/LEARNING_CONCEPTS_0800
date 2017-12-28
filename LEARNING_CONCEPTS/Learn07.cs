namespace LEARNING_CONCEPTS.Learn07
{
	public class Person
	{
		public Person()
		{
		}

		private int age;

		public int Age
		{
			get
			{
				return (age);
			}
			set
			{
				age = value;
			}
		}

		public void DoSomething()
		{
			Age = 30;
			age = 30;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			//person.age = 30;
			person.Age = 30;

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
