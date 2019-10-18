﻿namespace LEARNING_CONCEPTS.Learn01
{
	public class Person
	{
		public Person()
		{
		}

		public int Age;

		public void ShowInformation()
		{
			string message =
				$"I'm { Age } years old.";

			System.Console.WriteLine(message);
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

			person.ShowInformation();

			person.Age = 30;

			person.ShowInformation();

			person.Age = -20;

			person.ShowInformation();

			person.Age = 5000;

			person.ShowInformation();

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
