using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task5 {
	class Bat : IAnimal, IFlyable {
		public void fly() {
			Console.WriteLine("Bat flying");
		}

		public void move() {
			fly();
		}

		public void sound() {
			Console.WriteLine("*Bat sound*");
		}
	}
}
