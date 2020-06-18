using System;

namespace C_sharp_practice.Task1_2 {

	public class Student {
		string name;
		string group;
		string curator;
		public enum StudyYear {
			First,
			Second,
			Third,
			Fourth
		};
		StudyYear studyYear;
		bool isPaidEducation = true;
		public Mark[] marks;
		public Student() { }

		public Student(string name, string group, StudyYear studyYear) {
			this.name = name;
			this.group = group;
			this.studyYear = studyYear;
		}
		public double GetAvgMark() {
			int sum = 0;
			foreach (Mark mark in marks) {
				sum += mark.value;
			}
			return ((double)sum) / marks.Length;
		}

		public void setDefaultCurator() {
			switch (studyYear) {
				case StudyYear.First:
				curator = null;
				break;
				case StudyYear.Second:
				curator = "Петренко";
				break;
				default:
				curator = "Мясников";
				break;
			}
		}

		public void TryToFixGrades() {
			if (isPaidEducation) {
				foreach (Mark mark in marks)
					if (mark.value < 4)
						mark.value = 4;
			}
		}
		public void ResetAllMarks() {
			foreach (Mark mark in marks)
				mark.value = 0;
		}
	}
}