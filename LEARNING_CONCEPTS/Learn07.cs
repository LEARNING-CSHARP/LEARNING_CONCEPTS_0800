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
			age = 30; // Field قطعا و همیشه از
			Age = 30; // Property قطعا و همیشه از
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.Age = 30;
			//person.age = 30;

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
