using System;
using System.Collections.Generic;
using C_sharp_practice.Task5;

namespace C_sharp_practice {
	class Test5 {

		public static void test() {

			Group<IAnimal> group = new Group<IAnimal>();
			group.animals.Add(new Wolf());
			group.animals.Add(new Bird());
			group.animals.Add(new Bat());
			group.animals.Add(new Rabbit());
			group.animals.Add(new Fox());

			group.allMove();
			group.allSound();
		}
	}
}
