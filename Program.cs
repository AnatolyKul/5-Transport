using System;

namespace ConsoleApp13
{
	
		class Program
		{
		    static void Main(string[] args)
			{
			   Transport [] t = new Transport[5];
			   t[0] = new Car("Toyota", "Supra", "Orange", "400 km/h");
			
			   t[1] = new Bus("Камаз", "ВАЗ", "Белый", "100 km/h");
			   t[2] = new Moto("Kawasaki", "Ninja H2", "Black", "300 km/h");
			   t[3] = new Bicycle("Stels", "Sports", "Blue", "30 km/h");
			   t[4] = new Plane("Boing", "R-707", "White", "700 km/h");

			foreach (Transport a in t)
			  {
				a.name();
				a.model();
				a.color();
				a.speed();
				a.Move();
				a.Stop();
				Console.WriteLine("");
			}
			
			Console.ReadKey();
			   
			







		    } 
		}
}
