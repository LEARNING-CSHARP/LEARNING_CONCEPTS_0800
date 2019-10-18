namespace LEARNING_CONCEPTS.Learn11
{
	public class Person
	{
		public Person()
		{
		}

		#region Age Property
		private int age;

		/// <summary>
		/// فاجعه
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
			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
