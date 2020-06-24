using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace C_sharp_practice.Task7 {
	class TypeInfo {

		public static void show(Type type) {
			Console.WriteLine("Fields: ");
			foreach (var field in type.GetFields()) {
				Console.WriteLine("    " + field.ToString());
			}
			Console.WriteLine("Properties: ");
			foreach (var property in type.GetProperties()) {
				Console.WriteLine("    " + property.ToString());
			}
			Console.WriteLine("Constructors: ");
			foreach (var constructor in type.GetConstructors()) {
				Console.WriteLine("    " + constructor.ToString());
			}
			Console.WriteLine("Methods: ");
			foreach (var method in type.GetMethods()) {
				Console.WriteLine("    " + method.ToString());
			}
			Console.WriteLine("Interfaces: ");
			foreach (var iface in type.GetInterfaces()) {
				Console.WriteLine("    " + iface.ToString());
			}

		}
	}
}
