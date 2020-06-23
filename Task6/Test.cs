using System;
using System.Collections.Generic;
using C_sharp_practice.Task6;

namespace C_sharp_practice {
	class Test6 {

		public static void test() {
			List<Human> humans = new List<Human> {
				new Human("Tom", 164, 20),
				new Human("Alice", 160, 18),
				new Girl("Mary", 156, 25, FavoriteSerial.House),
				new Girl("Olga", 171, 19, FavoriteSerial.DoctorWho),
				new Boy("Alex", 170, 24, FavoriteGame.Borderlands),
				new Boy("Andrei", 164, 18, FavoriteGame.Bioshock),
			};

			foreach (Human human in humans) 
				Console.WriteLine(human.getInfo());

		}
	}
}
