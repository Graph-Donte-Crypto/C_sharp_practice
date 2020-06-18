using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task4 {
	class Order {
		public Customer customer;
		public string name;
		public List<Tuple<Product, int>> orderList;

		public Order(Customer customer, string name) {
			this.customer = customer;
			this.name = name;
			orderList = new List<Tuple<Product, int>>();
		}

		public void addProduct(Product product, int quantity) {
			for (int i = 0; i < orderList.Count; i++) {
				if (orderList[i].Item1.Equals(product)) {
					orderList[i] = Tuple.Create(product, orderList[i].Item2 + quantity);
					return;
				}
			}
			orderList.Add(Tuple.Create(product, quantity));
		}
		public decimal getFullPrice() {
			decimal full_price = 0;
			foreach (var tuple in orderList) 
				full_price += tuple.Item1.pricePerItem * tuple.Item2;
			return full_price;
		}
	}
}
