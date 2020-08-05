using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task11 {
	class Group<T> where T : IAnimal {
		public List<T> animals;
		public Group() {
			animals = new List<T>();
		}
	}
}
