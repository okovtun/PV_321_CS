using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		public Human(string last_name, string first_name, int age)
		{
			LastName = last_name;
			FirstName = first_name;
			Age = age;
			Console.WriteLine("HConstructor:\t" + GetHashCode());
		}
		public Human(Human other)
		{
			this.LastName = other.LastName;
			this.FirstName = other.FirstName;
			this.Age = other.Age;
			Console.WriteLine("HCopyConstructor:\t" + GetHashCode());
		}
		~Human()
		{
			Console.WriteLine("HDestructor:\t" + GetHashCode());
		}
		public override string ToString()
		{
			return $"{LastName} {FirstName} {Age} лет.";
		}
	}
}
