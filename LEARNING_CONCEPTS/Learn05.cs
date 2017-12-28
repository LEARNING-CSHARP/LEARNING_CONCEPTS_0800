namespace LEARNING_CONCEPTS.Learn05
{
	public class Person
	{
		public Person()
		{
		}

		private int age;

		/// <summary>
		/// Read And Write Property = Property
		/// </summary>
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

		private string firstName;

		/// <summary>
		/// Write Only Property
		/// </summary>
		public string FirstName
		{
			set
			{
				firstName = value;
			}
		}

		private string lastName;

		/// <summary>
		/// Read Only Property
		/// </summary>
		public string LastName
		{
			get
			{
				return (lastName);
			}
		}

		//private string fatherName;

		// هم چین چیزی نداریم
		//public string FatherName
		//{
		//}

		public void ShowInfo()
		{
			System.Console.WriteLine("I'm {0} years old.", Age);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.Age = 30;
			int age = person.Age;

			person.FirstName = "Dariush";
			//string firstName = person.FirstName;

			//person.LastName = "Tasdighi";
			string lastName = person.LastName;

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
