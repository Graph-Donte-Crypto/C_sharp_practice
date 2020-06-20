using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task5 {
	class Rabbit : IAnimal {
		public void move() {
			Console.WriteLine("Rabbit moving");
		}

		public void sound() {
			Console.WriteLine("*Rabbit sound*");
		}
	}
}
