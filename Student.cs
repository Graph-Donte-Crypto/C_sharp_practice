public class Student {
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
