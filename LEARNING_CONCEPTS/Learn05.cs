namespace LEARNING_CONCEPTS.Learn05
{
	public class Person
	{
		public Person()
		{
		}

		private int _age;

		/// <summary>
		/// Read And Write Property = Property
		/// </summary>
		public int Age
		{
			get
			{
				return (_age);
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
				return (_lastName);
			}
		}

		//private string _fatherName;

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
			Person oPerson = new Person();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
