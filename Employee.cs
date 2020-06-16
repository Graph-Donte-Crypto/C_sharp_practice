using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class Employee : IComparable<Employee>{
	public string name;
	public decimal salary;

	public Employee(string name, decimal salary){
		this.name = name;
		this.salary = salary;
	}
    public int CompareTo(Employee e) {
        return name.CompareTo(e.name);
    }

	public static SalaryComparerClass SalaryComparer = new SalaryComparerClass();
	public static NameComparerClass   NameComparer   = new NameComparerClass();

	public class SalaryComparerClass : IComparer<Employee> {
		public int Compare(Employee x, Employee y) {
			return x.salary.CompareTo(y.salary);
		}
	}

	public class NameComparerClass : IComparer<Employee> {
		public int Compare(Employee x, Employee y) {
			return x.name.CompareTo(y.name);
		}
	}
}
