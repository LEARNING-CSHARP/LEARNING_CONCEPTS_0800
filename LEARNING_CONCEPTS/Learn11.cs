namespace LEARNING_CONCEPTS.Learn11
{
	public class Person
	{
		public Person()
		{
		}

		private int age;

		/// <summary>
		/// فاجعه
		/// </summary>
		public int Age
		{
			get
			{
				return Age;
			}
			set
			{
				// حواسم نبوده
				Age = value;

				//age = value;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
