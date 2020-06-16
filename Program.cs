using System;
using System.Collections.Generic;

namespace C_sharp_practice {
	class Program {

		static bool test01() {
			Student student = new Student();

			Mark[] array = { 
				new Mark("T1", 6), 
				new Mark("T1", 6), 
				new Mark("T1", 7), 
				new Mark("T2", 8), 
				new Mark("T3", 9), 
			};

			student.marks = array;

			
			if (!student.GetAvgMark().Equals(7.2)) 
				return false;

			/*
			if (Math.Abs(student.GetAvgMark() - 7.2) >= 0.001)
				return false;
			*/

			student.ResetAllMarks();
			foreach (Mark mark in student.marks)
				if (mark.value != 0)
					return false;

			return true;
		}

		static void test06() {
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
		static void Main(string[] args) {
			Console.WriteLine(test01().ToString());
			test06();
		}
	}
}
