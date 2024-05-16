namespace Learn11
{
	public class Person
	{
		public Person()
		{
		}

		private int _age;

		public int Age
		{
			get
			{
				// حواسم نبوده
				//return Age;

				// باید دستور ذیل نوشته می‌شد
				return _age;
			}
			set
			{
				// حواسم نبوده
				//Age = value;

				// باید دستور ذیل نوشته می‌شد
				_age = value;
			}
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		//public static void Main()
		//{
		//	System.Console.WriteLine(value: "Learn (11)");

		//	var person =
		//		new Person();

		//	person.Age = 20;

		//	System.Console.Write
		//		(value: "Press [ENTER] To Exit... ");

		//	System.Console.ReadLine();
		//}
	}
}
