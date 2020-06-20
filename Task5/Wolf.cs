using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task5 {
	class Wolf : IAnimal {
		public void move() {
			Console.WriteLine("Wolf moving");
		}

		public void sound() {
			Console.WriteLine("*Wolf sound*");
		}
	}
}
