using System;
namespace Priorty_Queue.Models
{
	public class Employee
	{
		public string Fullname { get; set; }
		public int Age { get; set; }

		public Employee(string fullname, int age)
		{
			this.Fullname = fullname;
			this.Age = age;
		}
	}
}

