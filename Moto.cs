using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Moto : Transport
	{
		public Moto(string name, string model, string color, string speed) : base(name, model, color, speed)
		{
		}
		public void A()
		{
			Console.WriteLine(Name + " " + Model + " " + Color + " " + Speed);
		}
		public override void name()
		{
			base.name();
		}
		public override void model()
		{
			base.model();
		}
		public override void color()
		{
			base.color();
		}
		public override void speed()
		{
			base.speed();
		}
		public override void Move()
		{
			Console.WriteLine("Гонит");
		}
		public override void Stop()
		{
			Console.WriteLine("Разбивается");
		}

	}
}
