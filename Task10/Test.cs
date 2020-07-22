using System;
using System.Collections.Generic;
using C_sharp_practice.Task10;

namespace C_sharp_practice {
	class Test10 {
		public static void test() {
			Book book = new Book("first", "me", 2010, 15, "Interesting content");
			book.safeToXml("first.xml");

			Book book1 = new Book();
			book1.loadFromXml("first.xml");
			book1.safeToJson("first.json");

			Book book2 = new Book();
			book2.loadFromJson("first.json");

			Console.WriteLine(book.ToString());
			Console.WriteLine(book1.ToString());
			Console.WriteLine(book2.ToString());

		}
	}
}
