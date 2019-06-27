namespace LEARNING_CONCEPTS.Learn11
{
	public class Person
	{
		public Person()
		{
		}

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
	}

	class Program
	{
		static void Main(string[] args)
		{
			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
