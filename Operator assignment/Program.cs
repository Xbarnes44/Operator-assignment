using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 17;
			int b = 4;

			int quotient = a / b;
			int remainder = a % b;

			if (a == 17 && b == 4) ;

			Console.WriteLine($"{a}/{4} is {quotient} remainder {remainder}");

			//Area of a circle Exercise 2

			Console.WriteLine("What is the radius of the circle");

			double realRadius;
			var radius = double.TryParse(Console.ReadLine(), out realRadius);

			var areaOfCircle = AreaOfCircle (realRadius);

			Console.WriteLine($"The area of the circle with the radius of {realRadius} is {areaOfCircle}");

		}

			 public static double AreaOfCircle (double radius) 
		{
		
			return Math.PI * radius * radius;
		
		}
        
	}
}
