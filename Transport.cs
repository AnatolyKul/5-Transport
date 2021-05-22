using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Transport
	{
		protected string Name;
		protected string Model;
		protected string Color;
		protected string Speed;
		 
		public Transport(string name, string model,string color, string speed)
		{
			Name = name;
			Model = model;
			Color = color;
			Speed = speed;
		}
		public virtual void name()
		{
			Console.WriteLine(Name);
		}
		public virtual void model()
		{
			Console.WriteLine(Model);
		}
		public virtual void color()
		{
			Console.WriteLine(Color);
		}
		public virtual void speed()
		{
			Console.WriteLine(Speed);
		}
		public virtual void Move()
		{
			Console.WriteLine("Двигаюсь");
		}
		public virtual void Stop()
		{
			Console.WriteLine("Стою");
		}




	}
	

}


