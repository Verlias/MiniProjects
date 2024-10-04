import java.util.ArrayList;
import java.util.List;

public class Student {
	private final List<String> courses;
	private String name;

	public Student(String name) {
		this.name = name;
		courses = new ArrayList<>();
	}

	public String getName() {
		return name;
	}

	public List<String> getCourses() {
		return courses;
	}

	public void enroll(String courseName) {
		courses.add(courseName);
	}

	public void unenroll(String courseName) {
		courses.remove(courseName);
	}
}
