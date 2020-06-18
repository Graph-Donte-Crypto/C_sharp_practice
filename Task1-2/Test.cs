using System;
using System.Collections.Generic;

namespace C_sharp_practice {
	class Test1_2 {

		public static bool test() {
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
	}
}
