﻿namespace LEARNING_CONCEPTS.Learn10
{
	public class Person
	{
		public Person(int salary)
		{
			//_salary = salary;

			Salary = salary;
		}

		private int _salary;

		public int Salary
		{
			get
			{
				return _salary;
			}
			private set
			{
				_salary = value;
			}
		}

		//public int Salary { get; private set; }
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Person person = new Person(1000000);

			//person.Salary = 2000000; // Compile Error!

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
