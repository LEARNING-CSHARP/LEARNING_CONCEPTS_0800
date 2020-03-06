namespace LEARNING_CONCEPTS.Learn11
{
	public class Person
	{
		#region Constructor
		public Person()
		{
		}
		#endregion /Constructor

		#region Age Property
		/// <summary>
		/// سن شخص
		/// </summary>
		private int age;

		/// <summary>
		/// سن شخص - نمایش یک فاجعه در اثر یک بی‌دقتی
		/// </summary>
		public int Age
		{
			get
			{
				// حواسم نبوده
				//return Age;

				// باید دستور ذیل نوشته می‌شد
				return age;
			}
			set
			{
				// حواسم نبوده
				//Age = value;

				// باید دستور ذیل نوشته می‌شد
				age = value;
			}
		}
		#endregion /Age Property
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Person person = new Person();

			person.Age = 20;

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
