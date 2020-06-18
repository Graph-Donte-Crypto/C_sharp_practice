using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_practice.Task4 {
	class Shop {
		string name;
		List<Order> orders;
		List<Tuple<Product, int>> allGoods;
		decimal revenue;
		public Shop(string name) {
			this.name = name;
			orders = new List<Order>();
			allGoods = new List<Tuple<Product, int>>();
			revenue = 0;
		}

		public void addOrder(Order order) {
			orders.Add(order);
		}
		public void addGoods(Product product, int quantity) {
			for (int i = 0; i < allGoods.Count; i++) {
				if (allGoods[i].Item1.Equals(product)) {
					allGoods[i] = Tuple.Create(product, allGoods[i].Item2 + quantity);
					return;
				}
			}
			allGoods.Add(Tuple.Create(product, quantity));
		}

		public void fulfillOrders() {
			Console.WriteLine("In shop {0}", name);
			foreach (Order order in orders) {
				if (order.getFullPrice() > order.customer.money) {
					Console.WriteLine("Can't fulfill order '{0}' from customer '{1}'", order.name, order.customer.name);
					Console.WriteLine("  Because full price {0} more than customer money {1}", order.getFullPrice(), order.customer.money);
				}
				else {
					bool notEnoughProducts = false;
					foreach (var productOrder in order.orderList) {
						int goodsQuantity = 0;
						foreach (var goods in allGoods) {
							if (goods.Item1.Equals(productOrder.Item1)) {
								goodsQuantity = goods.Item2;
								break;
							}
						}
						if (productOrder.Item2 > goodsQuantity) {
							if (!notEnoughProducts) {
								notEnoughProducts = true;
								Console.WriteLine("Can't fulfill order '{0}' from customer '{1}'", order.name, order.customer.name);
								Console.WriteLine("  Because:");
							}
							Console.WriteLine("    Requires {0} units of '{1}', but in stock only {2}", productOrder.Item2, productOrder.Item1.name, goodsQuantity);
						}
					}
					if (!notEnoughProducts) {
						revenue += order.getFullPrice();
						foreach (var productOrder in order.orderList) {
							int i = 0;
							for (; i < allGoods.Count; i++) { 
								if (allGoods[i].Item1.Equals(productOrder.Item1)) break;
							}
							allGoods[i] = Tuple.Create(allGoods[i].Item1, allGoods[i].Item2 - productOrder.Item2);
						}
						Console.WriteLine("Order {0} from customer {1} completed successfully", order.name, order.customer.name);
						Console.WriteLine("  Received {0} money, total {1}", order.getFullPrice(), revenue);
					}
				}
			}
		}
	}
}
