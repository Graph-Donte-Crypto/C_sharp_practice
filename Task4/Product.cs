﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task4 {
	class Product {
		public string name;
		public decimal pricePerItem;
		public Product(string name, decimal priceByOne) {
			this.name = name;
			this.pricePerItem = priceByOne;
		}
	}
}
