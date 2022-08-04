namespace Learn12
{
	/// <summary>
	/// کلاس شخص
	/// </summary>
	public class Person
	{
		#region Constructor
		/// <summary>
		/// سازنده کلاس شخص
		/// </summary>
		/// <param name="salary">حقوق شخص</param>
		public Person(int salary)
		{
			Salary = salary;
		}
		#endregion /Constructor

		#region Age Property
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
				return _age;
			}
			set
			{
				if (value >= 0 && value <= 100)
				{
					_age = value;
				}
			}
		}
		#endregion /Age Property

		#region Salary Property
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
				return _salary;
			}
			private set
			{
				if (value >= 0)
				{
					_salary = value;
				}
			}
		}
		#endregion /Salary Property

		//private string _firstName;

		//public string FirstName
		//{
		//	get
		//	{
		//		return _firstName;
		//	}
		//	set
		//	{
		//		_firstName = value;
		//	}
		//}

		#region FirstName Property
		/// <summary>
		/// نام
		/// </summary>
		public string FirstName { get; set; }
		#endregion /FirstName Property

		//private string _lastName;

		//public string LastName
		//{
		//	get
		//	{
		//		return _lastName;
		//	}
		//	set
		//	{
		//		_lastName = value;
		//	}
		//}

		#region LastName Property
		/// <summary>
		/// نام خانوادگی
		/// </summary>
		public string LastName { get; set; }
		#endregion /LastName Property

		// های محاسباتی می‌باشد Property جزء FullName
		// نوابغ توجه داشته باشند که به هیچ عنوان نیازی به این فیلد نیست
		//private string _fullName;

		#region FullName Property
		/// <summary>
		/// نام و نام خانوادگی
		/// </summary>
		public string FullName
		{
			get
			{
				// دستور ذیل حرفه‌ای نیست
				//string result =
				//	$"{ _firstName } { _lastName }".Trim();

				string result =
					$"{FirstName} {LastName}".Trim();

				return result;
			}
		}
		#endregion /FullName Property

		#region ShowInformation Method
		/// <summary>
		/// با استفاده از این تابع اطلاعات شخص به طور کامل نمایش داده می‌شود
		/// </summary>
		public void ShowInformation()
		{
			// دستور ذیل حرفه‌ای نیست
			//string message =
			//	$"I'm {FullName} and {_age} years old and I make {_salary}$";

			string message =
				$"I'm {FullName} and {Age} years old and I make {Salary}$";

			System.Console.WriteLine(message);
		}
		#endregion /ShowInformation Method
	}
}
