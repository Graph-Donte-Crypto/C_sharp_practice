using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task6 {
	class Human {
		public string name { get; set; }
		public int height { get; set; }
		public virtual int age { get; set; }

		public Human(string name, int height, int age) {
			this.name = name;
			this.height = height;
			this.age = age;
		}

		public string getNameAndAge() {return name + "(" + age.ToString() + ")";}
		public virtual string getInfo() {
			return "Human: " + getNameAndAge();
		}

	}
}
