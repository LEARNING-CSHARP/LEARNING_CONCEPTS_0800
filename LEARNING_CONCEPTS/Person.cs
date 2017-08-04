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
		private int _age;

		/// <summary>
		/// سن
		/// </summary>
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

		/// <summary>
		/// حقوق
		/// </summary>
		private int _salary;

		/// <summary>
		/// حقوق
		/// </summary>
		public int Salary
		{
			get
			{
				return (_salary);
			}
			private set
			{
				if (_salary >= 0)
				{
					_salary = value;
				}
			}
		}

		///// <summary>
		///// نام
		///// </summary>
		//private string _firstName;

		///// <summary>
		///// نام
		///// </summary>
		//public string FirstName
		//{
		//	get
		//	{
		//		return (_firstName);
		//	}
		//	set
		//	{
		//		_firstName = value;
		//	}
		//}

		/// <summary>
		/// نام
		/// </summary>
		public string FirstName { get; set; }

		///// <summary>
		///// نام خانوادگی
		///// </summary>
		//private string _lastName;

		///// <summary>
		///// نام خانوادگی
		///// </summary>
		//public string LastName
		//{
		//	get
		//	{
		//		return (_lastName);
		//	}
		//	set
		//	{
		//		_lastName = value;
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
				string strFullName =
					string.Format("{0} {1}",
					FirstName, LastName).Trim();

				return (strFullName);
			}
		}

		/// <summary>
		/// تابع نمایش اطلاعات شخص
		/// </summary>
		public void ShowInfo()
		{
			System.Console.WriteLine
				("I'm {0} and {1} years and I catch {2}$.", FullName, Age, Salary);
		}
	}
}
