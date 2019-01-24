﻿namespace LEARNING_CONCEPTS.Learn02
{
	public class Person
	{
		public Person()
		{
		}

		// دستور ذیل مطلقا توصیه نمی‌شود
		//public int Age;

		private int age;

		public int GetAge()
		{
			//return this.age;

			return age;
		}

		public void SetAge(int age)
		{
			//age = age;

			this.age = age;
		}

		public void ShowInformation()
		{
			//string message =
			//	$"I'm { age } years old.";

			string message =
				$"I'm { GetAge() } years old.";

			System.Console.WriteLine(message);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			//person.age = 30; // Compile Error!
			person.SetAge(30);

			person.ShowInformation();

			//person.age = -20; // Compile Error!
			person.SetAge(-20);

			person.ShowInformation();

			//person.age = 5000; // Compile Error!
			person.SetAge(5000);

			person.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
