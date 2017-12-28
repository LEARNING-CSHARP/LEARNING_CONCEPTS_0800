namespace LEARNING_CONCEPTS
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
				if (salary >= 0)
				{
					salary = value;
				}
			}
		}

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
		/// تابع نمایش اطلاعات شخص
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
}
