using System;
using System.Collections.Generic;
using C_sharp_practice.Task8;

namespace C_sharp_practice {
	class Test8 {
		public static void test() {
			string[] strings = new string[] {
				"Hello world",
				null,
				"Good morning!",
				"congratulations"
			};
			TextTransformer transformer = new TextTransformer();
			foreach (string s in strings)
				Console.WriteLine(transformer.transform(s));
		}
	}
}
