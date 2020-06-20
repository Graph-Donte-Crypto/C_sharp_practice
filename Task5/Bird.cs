using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task5 {
	class Bird : IAnimal, IFlyable {
		public void fly() {
			Console.WriteLine("Bird fly!");
		}

		public void move() {
			fly();
		}

		public void sound() {
			Console.WriteLine("*Bird sound*");
		}
	}
}
