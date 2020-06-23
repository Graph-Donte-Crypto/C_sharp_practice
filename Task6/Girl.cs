using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task6 {
	class Girl : Human {
		public override int age {
			get { return base.age * 4 / 5; }
		}

		public Girl(string name, int height, int age) : base(name, height, age) {
		}
		public override string getInfo() {
			return "Girl: " + base.getNameAndAge();
		}
	}
}
