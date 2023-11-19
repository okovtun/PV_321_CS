using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Teacher:Human
	{
		public string Speciality { get; set; }
		public int Experience { get; set; }
		public Teacher
			(
			string last_name, string first_name, int age,
			string speciality, int experience
			) : base(last_name, first_name, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine("TConstructor:\t" + GetHashCode());
		}
		public Teacher(Human human, string speciality, int experience) : base(human)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine("TConstructor:\t" + GetHashCode());
		}
		~Teacher()
		{
			Console.WriteLine("TDestructor:\t" + GetHashCode());
		}
		public override string ToString()
		{
			return base.ToString() + $" {Speciality} {Experience} лет.";
		}
	}
}
