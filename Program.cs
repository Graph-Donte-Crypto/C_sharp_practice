using System;

namespace C_sharp_practice {


	class Mark {
		string subject;
		public int value;
		public Mark(string subject, int value) {
			this.subject = subject;
			this.value	 = value;
		}
	}

	class Student {
		string name;
		string group;
		public Mark[] marks;
		public double GetAvgMark() {
			int sum = 0;
			foreach (Mark mark in marks) {
				sum += mark.value;
			}
			return ((double)sum) / marks.Length;
		}
		public void ResetAllMarks() {
			foreach (Mark mark in marks)
				mark.value = 0;
		}
	}
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
