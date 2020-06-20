using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task5 {
	class Fox : IAnimal {
		public void move() {
			Console.WriteLine("Fox moving");
		}

		public void sound() {
			Console.WriteLine("*Fox sound*");
		}
	}
}
