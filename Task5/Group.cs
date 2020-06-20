using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task5 {
	class Group<T> where T : IAnimal {
		public List<T> animals;
		public Group() {
			animals = new List<T>();
		}

		public void allMove() {
			foreach (IAnimal animal in animals) 
				animal.move();
		}

		public void allSound() {
			foreach (IAnimal animal in animals)
				animal.sound();
		}
	}
}
