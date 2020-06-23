using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task6 {

	enum FavoriteSerial { 
		House,
		Checnobyl,
		DoctorWho,
		Startrack,
		Castle
	}
	class Girl : Human {
		public override int age {
			get { return base.age * 4 / 5; }
		}

		public FavoriteSerial favoriteSerial { get; set; }

		public Girl(string name, int height, int age, FavoriteSerial favoriteSerial) : base(name, height, age) {
			this.favoriteSerial = favoriteSerial;
		}
		public override string getInfo() {
			return "Girl: " + base.getNameAndAge() + ", favirite serial: " + favoriteSerial.ToString();
		}
	}
}
