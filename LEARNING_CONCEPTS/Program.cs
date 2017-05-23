using System;

namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			// Learn (1)
			//Person oPerson = new Person();

			//oPerson.Age = 30;

			//oPerson.ShowInfo();

			//oPerson.Age = -20;

			//oPerson.ShowInfo();

			//oPerson.Age = 5000;

			//oPerson.ShowInfo();
			// /Learn (1)

			// Learn (2)
			//Person oPerson = new Person();

			////oPerson.Age = 30; // It is not Accessable!

			//oPerson.SetAge(30);

			//oPerson.ShowInfo();

			//oPerson.SetAge(-20);

			//oPerson.ShowInfo();

			//oPerson.SetAge(5000);

			//oPerson.ShowInfo();
			// /Learn (2)

			// Learn (3)
			//Person oPerson = new Person();

			//oPerson.SetAge(30);

			//oPerson.ShowInfo();

			//oPerson.SetAge(-20);

			//oPerson.ShowInfo();

			//oPerson.SetAge(5000);

			//oPerson.ShowInfo();
			// /Learn (3)

			// Learn (4)
			Person oPerson = new Person();

			oPerson.Age = 30;

			oPerson.ShowInfo();

			oPerson.Age = -20;

			oPerson.ShowInfo();

			oPerson.Age = 5000;

			oPerson.ShowInfo();
			// /Learn (4)

			//Person oPerson = new Person(age: 30, salary: 2000);

			//oPerson.Salary = 3000;

			//Person oPerson = new Person(salary: 2000);

			//oPerson.Age = 20;
			//oPerson.FirstName = "Ali";
			//oPerson.LastName = "Alavi";
			//oPerson.ShowInfo();

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
