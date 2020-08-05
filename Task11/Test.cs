using System;
using System.Collections.Generic;
using System.Linq;
using C_sharp_practice.Task11;

namespace C_sharp_practice {
	class Test11 {

		public static void test() {

			Group<IAnimal> myGroup = new Group<IAnimal>();
			myGroup.animals.Add(new Wolf { name = "Volk", age = 3});
			myGroup.animals.Add(new Bird { name = "Sova", age = 1 });
			myGroup.animals.Add(new Bat { name = "Letuchka", age = 2 });
			myGroup.animals.Add(new Rabbit { name = "Pushok", age = 1 });
			myGroup.animals.Add(new Fox { name = "Lisichka", age = 1 });

			var result1 = from animal0 in myGroup.animals
						  where animal0.age == (
							from a in myGroup.animals
							select a.age
						  ).Max()
						  select animal0.name;

			Console.WriteLine("oldest animals: " + string.Join(", ", result1));

			var result2 = from animal1 in myGroup.animals
						  orderby animal1.age
						  select animal1;

			Console.WriteLine("Animals table by age");
			foreach (IAnimal a in result2) {
				Console.WriteLine("    name: " + a.name + ", age: " + a.age);
			}

			/*
			var result3 = 
			*/

			var tableForResult3 = (
				from a in myGroup.animals
				group a by a.age into g
				select new {
					count = g.Count(),
					age = g.Key
				}
			);

			var result3 =
				from animal3 in myGroup.animals
				where animal3.age == (
					from pair in tableForResult3
					where pair.count == (
							from a in tableForResult3
							select a.count
							).Max()
					select pair.age
				).Max()
				select animal3.name;

			Console.WriteLine("sameage animals: " + string.Join(", ", result3));
		}
	}
}
