using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace C_sharp_practice.Task8 {
	public class TextTransformer {
		public TextTransformer() { 

		}
		public string transform(string s) {
			if (s == null)
				return "NullString";
			StringBuilder result = new StringBuilder();
			foreach (char c in s) 
				result.Append(char.ToUpper(c));
			return result.ToString();
		}
	}
}
