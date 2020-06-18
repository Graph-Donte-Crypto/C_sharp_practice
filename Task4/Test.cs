using System;
using System.Collections.Generic;
using C_sharp_practice.Task4;

namespace C_sharp_practice {
	class Test4 {

		public static void test() {
			Customer customerIvan = new Customer("Ivan", 50);
			Customer customerDima = new Customer("Dima", 100);
			Customer customerOlga = new Customer("Olga", 150);

			Product productWater = new Product("Water", 1);
			Product productMilk = new Product("Milk", 2);
			Product productJuice = new Product("Juice", 3);

			Shop shopSmall = new Shop("SmallShop");
			Shop shopBig = new Shop("BigShop");

			shopSmall.addGoods(productWater, 30);
			shopSmall.addGoods(productMilk, 10);

			shopBig.addGoods(productWater, 100);
			shopBig.addGoods(productMilk, 50);
			shopBig.addGoods(productJuice, 10);

			Order order1 = new Order(customerIvan, "SomeWaterMilk");
			order1.addProduct(productWater, 10);
			order1.addProduct(productMilk, 10);

			Order order2 = new Order(customerIvan, "SomeJuice");
			order2.addProduct(productWater, 10);

			shopSmall.addOrder(order1);
			shopSmall.addOrder(order2);

			Order order3 = new Order(customerOlga, "SomeMilk");
			order3.addProduct(productMilk, 20);

			Order order4 = new Order(customerDima, "ManyWaterMilk");
			order4.addProduct(productWater, 100);
			order4.addProduct(productWater, 30);

			Order order5 = new Order(customerIvan, "5Juice");
			order5.addProduct(productJuice, 5);

			Order order6 = new Order(customerDima, "1Juice");
			order6.addProduct(productJuice, 1);

			Order order7 = new Order(customerDima, "NotManyWaterMilk");
			order7.addProduct(productWater, 50);
			order7.addProduct(productMilk, 10);

			Order order8 = new Order(customerOlga, "ManyThings");
			order8.addProduct(productWater, 60);
			order8.addProduct(productMilk, 10);
			order8.addProduct(productJuice, 5);

			shopBig.addOrder(order3);
			shopBig.addOrder(order4);
			shopBig.addOrder(order5);
			shopBig.addOrder(order6);
			shopBig.addOrder(order7);
			shopBig.addOrder(order8);

			shopSmall.fulfillOrders();
			Console.WriteLine();
			shopBig.fulfillOrders();
		}
	}
}
