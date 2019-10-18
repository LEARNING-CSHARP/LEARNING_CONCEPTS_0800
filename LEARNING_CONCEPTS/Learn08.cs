﻿namespace LEARNING_CONCEPTS.Learn08
{
	public class Person
	{
		public Person()
		{
		}

		private int age;

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

		public void DoSomething(int age)
		{
			// **************************************************
			//this.age = age;
			// **************************************************

			// **************************************************
			//if ((age >= 0) && (age <= 100))
			//{
			//	this.age = age;
			//}
			// **************************************************

			// **************************************************
			Age = age;
			// **************************************************
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			Person person = new Person();

			person.Age = 30;
			person.Age = -20;
			person.Age = 5000;

			person.DoSomething(30);
			person.DoSomething(-20);
			person.DoSomething(5000);

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
