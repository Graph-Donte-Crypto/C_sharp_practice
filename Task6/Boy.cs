using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task6 {
	class Boy : Human {
        public override int age {
            get { return base.age; }
        }

		public Boy(string name, int height, int age) : base(name, height, age) {
		}
		public override string getInfo() {
			return "Boy: " + base.getNameAndAge();
		}
	}
}
