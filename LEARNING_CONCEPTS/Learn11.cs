namespace LEARNING_CONCEPTS.Learn11
{
	/// <summary>
	/// کلاس شخص
	/// </summary>
	public class Person
	{
		/// <summary>
		/// سازنده کلاس شخص
		/// </summary>
		/// <param name="salary">حقوق شخص</param>
		public Person(int salary)
		{
			Salary = salary;
		}

		#region Age Property
		/// <summary>
		/// سن
		/// </summary>
		private int age;

		/// <summary>
		/// سن
		/// </summary>
		public int Age
		{
			get
			{
				return (age);
			}
			set
			{
				if ((value >= 0) && (value <= 100))
				{
					age = value;
				}
			}
		}
		#endregion /Age Property

		#region Salary Property
		/// <summary>
		/// حقوق
		/// </summary>
		private int salary;

		/// <summary>
		/// حقوق
		/// </summary>
		public int Salary
		{
			get
			{
				return (salary);
			}
			private set
			{
				if (value >= 0)
				{
					salary = value;
				}
			}
		}
		#endregion /Salary Property

		//private string firstName;

		//public string FirstName
		//{
		//	get
		//	{
		//		return (firstName);
		//	}
		//	set
		//	{
		//		firstName = value;
		//	}
		//}

		/// <summary>
		/// نام
		/// </summary>
		public string FirstName { get; set; }

		//private string lastName;

		//public string LastName
		//{
		//	get
		//	{
		//		return (lastName);
		//	}
		//	set
		//	{
		//		lastName = value;
		//	}
		//}

		/// <summary>
		/// نام خانوادگی
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// نام و نام خانوادگی
		/// </summary>
		public string FullName
		{
			get
			{
				string fullName =
					$"{ FirstName } { LastName }";

				return (fullName);
			}
		}

		/// <summary>
		/// با استفاده از این تابع اطلاعات شخص به طور کامل نمایش داده می‌شود
		/// </summary>
		public void ShowInfo()
		{
			//string message =
			//	$"I'm { FullName } and { age } years old and I make { salary }$";

			string message =
				$"I'm { FullName } and { Age } years old and I make { Salary }$";

			System.Console.WriteLine(message);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person(1000000);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
