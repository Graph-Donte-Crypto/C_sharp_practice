using System;
using System.Collections.Generic;

namespace C_sharp_practice {
	class Test6 {

		public static void test() {
			List<Employee> employees = new List<Employee>();
			employees.Add(new Employee("Иванов", 100));
			employees.Add(new Employee("Петров", 300));
			employees.Add(new Employee("Сидоров", 150));
			employees.Add(new Employee("Иваненко", 200));
			
			
			Console.WriteLine("Original List");
			foreach (Employee employee in employees) {
				Console.WriteLine("Name: " + employee.name + " Salary: " + employee.salary);
			}

			employees.Sort();
			Console.WriteLine("Sort()");
			foreach (Employee employee in employees) {
				Console.WriteLine("Name: " + employee.name + " Salary: " + employee.salary);
			}

			employees.Sort(Employee.NameComparer);
			Console.WriteLine("Sort(Employee.NameComparer)");
			foreach (Employee employee in employees) {
				Console.WriteLine("Name: " + employee.name + " Salary: " + employee.salary);
			}

			employees.Sort(Employee.SalaryComparer);
			Console.WriteLine("Sort(Employee.SalaryComparer)");
			foreach (Employee employee in employees) {
				Console.WriteLine("Name: " + employee.name + " Salary: " + employee.salary);
			}
			
		}
	}
}
