namespace Learn05
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int _age;

		/// <summary>
		/// Read And Write Property = Property
		/// </summary>
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

		private string _firstName;

		/// <summary>
		/// Write Only Property
		/// </summary>
		public string FirstName
		{
			set
			{
				_firstName = value;
			}
		}

		private string _lastName;

		/// <summary>
		/// Read Only Property
		/// </summary>
		public string LastName
		{
			get
			{
				return _lastName;
			}
		}

		//private string _fatherName;

		// هم چین چیزی نداریم
		//public string FatherName
		//{
		//}

		public void ShowInformation()
		{
			string message =
				$"I'm {Age} years old.";

			System.Console.WriteLine(value: message);
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		//public static void Main()
		//{
		//	System.Console.WriteLine(value: "Learn (5)");

		//	var person = new Person();

		//	person.Age = 30;
		//	var age = person.Age;

		//	person.FirstName = "Dariush";
		//	//var firstName = person.FirstName; // Compile Error!

		//	//person.LastName = "Tasdighi"; // Compile Error!
		//	var lastName = person.LastName;

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
