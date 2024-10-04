import java.util.HashMap;
import java.util.Map;

public class University {
    private final Map<String, Student> students;

    University() {
        students = new HashMap<>();

    }

    public Map<String, Student> getStudents() {
        return students;
    }

    public void addStudent(String quickId, String name) {
        students.put(quickId, new Student(name));
    }

    public void enrollStudent(String quickId, String courseName) {
        students.get(quickId).enroll(courseName);
    }

    public void unenroll(String quickId, String courseName) {
        students.get(quickId).unenroll(courseName);
    }

}
