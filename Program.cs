using System;

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

			if ((student.GetAvgMark() - 7.2) >= 0.001)
				return false;

			student.ResetAllMarks();
			foreach (Mark mark in student.marks)
				if (mark.value != 0)
					return false;

			return true;
		}
		static void Main(string[] args) {
			Console.WriteLine(test01().ToString());
		}
	}
}
