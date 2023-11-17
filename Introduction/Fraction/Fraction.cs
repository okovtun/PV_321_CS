using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Fraction
	{
		int denominator;
		public int Integer { get; set; }
		public int Numerator { get; set; }
		public int Denominator
		{
			get { return denominator; }
			set
			{
				if (value == 0) value = 1;
				this.denominator = value;
			}
		}
		//--------------------------------------------------------------------------//
		public Fraction(int integer)
		{
			Integer = integer;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("Construtor:\t" + GetHashCode());
		}
		public Fraction(int numerator, int denominator)
		{
			//Integer = 0;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Construtor:\t" + GetHashCode());
		}
		public Fraction(int integer = 0, int numerator = 0, int denominator = 1) : this(numerator, denominator)
		{
			Integer = integer;
			//Numerator = numerator;
			//Denominator = denominator;
			Console.WriteLine("Construtor:\t" + GetHashCode());
		}
		public Fraction(Fraction other)
		{
			if(this.Equals(other))Console.WriteLine("Вы хотите скопировать объект в самого себя");
			this.Integer = other.Integer;
			this.Numerator = other.Numerator;
			this.Denominator = other.Denominator;
			Console.WriteLine("CopyConstructor:\t" + GetHashCode());
		}
		~Fraction()
		{
			Console.WriteLine("Destrutor:\t" + GetHashCode());
		}

		//				Operators:
		public static Fraction operator *(Fraction left_operand, Fraction right_operand)
		{
			Fraction left = new Fraction(left_operand);
			Fraction right = new Fraction(right_operand);
			left.ToImproper();
			right.ToImproper();
			return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator).ToProper();
		}
		//---------------------------------------------------------------------------
		public static bool operator ==(Fraction left_operand, Fraction right_operand)
		{
			Fraction left = new Fraction(left_operand);
			Fraction right = new Fraction(right_operand);
			left.ToImproper();
			right.ToImproper();
			return left.Numerator * right.Denominator == right.Numerator * left.Denominator;
		}
		public static bool operator !=(Fraction left, Fraction right)
		{
			return !(left == right);
		}
		//				 Methods:
		public Fraction ToImproper()
		{
			Numerator += Integer * Denominator;
			Integer = 0;
			return this;
		}
		public Fraction ToProper()
		{
			Integer += Numerator / Denominator;
			Numerator %= Denominator;
			return this;
		}
		public void Print()
		{
			//Console.Write($"{Integer}({Numerator}/{Denominator})");
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator}/{Denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
		public override string ToString()
		{
			string fraction = "";
			if (Integer != 0) fraction += Integer;
			if (Numerator != 0)
			{
				if (Integer != 0) fraction += "(";
				fraction += $"{Numerator}/{Denominator}";
				if (Integer != 0) fraction += ")";
			}
			else if (Integer == 0) fraction = "0";
			return fraction;
		}
	}
}
