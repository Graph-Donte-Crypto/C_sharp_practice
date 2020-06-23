using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task6 {

	enum FavoriteGame {
		MassEffect, 
		Bioshock, 
		Borderlands, 
		Stalker, 
		Civilization
	}
	class Boy : Human {
        public override int age {
            get { return base.age; }
        }

		public FavoriteGame favoriteGame { get; set; }

		public Boy(string name, int height, int age, FavoriteGame favoriteGame) : base(name, height, age) {
			this.favoriteGame = favoriteGame;
		}
		public override string getInfo() {
			return "Boy: " + base.getNameAndAge() + ", favorite game: " + favoriteGame.ToString();
		}
	}
}
