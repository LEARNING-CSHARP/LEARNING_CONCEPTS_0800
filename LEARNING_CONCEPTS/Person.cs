namespace LEARNING_CONCEPTS
{
	/// <summary>
	/// Learn (1)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	public int Age;

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0} years old.", Age);
	//	}
	//}

	/// <summary>
	/// Learn (2)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	private int _age;

	//	public void SetAge(int age)
	//	{
	//		_age = age;
	//	}

	//	public int GetAge()
	//	{
	//		return (_age);
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0} years old.", _age);
	//	}
	//}

	/// <summary>
	/// Learn (3)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	private int _age;

	//	public void SetAge(int age)
	//	{
	//		if ((age >= 0) && (age <= 100))
	//		{
	//			_age = age;
	//		}
	//	}

	//	public int GetAge()
	//	{
	//		return (_age);
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0} years old.", _age);
	//	}
	//}

	/// <summary>
	/// Learn (4)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	public int SomeField;

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			if ((value >= 0) && (value <= 100))
	//			{
	//				_age = value;
	//			}
	//		}
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0} years old.", _age);
	//	}
	//}

	/// <summary>
	/// Learn (5)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	private int _age;

	//	/// <summary>
	//	/// Read And Write Property = Property
	//	/// </summary>
	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			_age = value;
	//		}
	//	}

	//	private string _firstName;

	//	/// <summary>
	//	/// Write Only Property
	//	/// </summary>
	//	public string FirstName
	//	{
	//		set
	//		{
	//			_firstName = value;
	//		}
	//	}

	//	private string _lastName;

	//	/// <summary>
	//	/// Read Only Property
	//	/// </summary>
	//	public string LastName
	//	{
	//		get
	//		{
	//			return (_lastName);
	//		}
	//	}

	//	//private string _fatherName;

	//	//public string FatherName
	//	//{
	//	//}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0} years old.", _age);
	//	}
	//}

	/// <summary>
	/// Learn (6)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	//public string FullName;

	//	//private string _fullName;

	//	//public string FullName
	//	//{
	//	//	get
	//	//	{
	//	//		return (_fullName);
	//	//	}
	//	//	set
	//	//	{
	//	//		_fullName = value;
	//	//	}
	//	//}

	//	public string FullName { get; set; }

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0}", _age);
	//	}
	//}

	/// <summary>
	/// Learn (7)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//		Age = 20;
	//		_age = 20;
	//	}

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			_age = value;
	//		}
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0}", _age);
	//	}
	//}

	/// <summary>
	/// Learn (8)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	public Person(int age)
	//	{
	//		//_age = age;

	//		//if ((age >= 0) && (age <= 100))
	//		//{
	//		//	_age = age;
	//		//}

	//		Age = age;
	//	}

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			if ((value >= 0) && (value <= 100))
	//			{
	//				_age = value;
	//			}
	//		}
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0}", _age);
	//	}
	//}

	/// <summary>
	/// Learn (9)
	/// </summary>
	//public class Person
	//{
	//	public Person(int age, int salary)
	//	{
	//		Age = age;
	//		Salary = salary;
	//	}

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			if ((value >= 0) && (value <= 100))
	//			{
	//				_age = value;
	//			}
	//		}
	//	}

	//	private int _salary;

	//	public int Salary
	//	{
	//		get
	//		{
	//			return (_salary);
	//		}
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0}", _age);
	//	}
	//}

	/// <summary>
	/// Learn (10)
	/// </summary>
	//public class Person
	//{
	//	public Person()
	//	{
	//	}

	//	public Person(int age, int salary)
	//	{
	//		Age = age;
	//		Salary = salary;
	//	}

	//	private int _age;

	//	public int Age
	//	{
	//		get
	//		{
	//			return (_age);
	//		}
	//		set
	//		{
	//			if ((value >= 0) && (value <= 100))
	//			{
	//				_age = value;
	//			}
	//		}
	//	}

	//	private int _salary;

	//	public int Salary
	//	{
	//		get
	//		{
	//			return (_salary);
	//		}
	//		private set
	//		{
	//			_salary = value;
	//		}
	//	}

	//	public void ShowInfo()
	//	{
	//		System.Console.WriteLine("I'm {0}", _age);
	//	}
	//}

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
