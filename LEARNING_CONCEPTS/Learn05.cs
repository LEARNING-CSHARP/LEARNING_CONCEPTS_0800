namespace LEARNING_CONCEPTS.Learn05
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int age;

		/// <summary>
		/// Read And Write Property = Property
		/// </summary>
		public int Age
		{
			get
			{
				return age;
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
				return lastName;
			}
		}

		//private string fatherName;

		// هم چین چیزی نداریم
		//public string FatherName
		//{
		//}

		public void ShowInformation()
		{
			string message =
				$"I'm { Age } years old.";

			System.Console.WriteLine(message);
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Person person = new Person();

			person.Age = 30;
			int age = person.Age;

			person.FirstName = "Dariush";
			//string firstName = person.FirstName; // Compile Error!

			//person.LastName = "Tasdighi"; // Compile Error!
			string lastName = person.LastName;

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
