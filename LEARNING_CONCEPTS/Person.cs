namespace LEARNING_CONCEPTS.Learn12
{
	/// <summary>
	/// کلاس شخص
	/// </summary>
	public class Person
	{
		// سوتی‌ها
		// constructor
		// /constructor
		// نباید خالی باشد

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
		private int age;

		/// <summary>
		/// سن
		/// </summary>
		public int Age
		{
			get
			{
				return age;
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
				return salary;
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
		//		return firstName;
		//	}
		//	set
		//	{
		//		firstName = value;
		//	}
		//}

		#region FirstName Property
		/// <summary>
		/// نام
		/// </summary>
		public string FirstName { get; set; }
		#endregion /FirstName Property

		//private string lastName;

		//public string LastName
		//{
		//	get
		//	{
		//		return lastName;
		//	}
		//	set
		//	{
		//		lastName = value;
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
		//private string fullName;

		#region FullName Property
		/// <summary>
		/// نام و نام خانوادگی
		/// </summary>
		public string FullName
		{
			get
			{
				string result =
					$"{ FirstName } { LastName }".Trim();

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
			string message =
				$"I'm { FullName } and { Age } years old and I make { Salary }$";

			System.Console.WriteLine(message);
		}
		#endregion /ShowInformation Method
	}
}
