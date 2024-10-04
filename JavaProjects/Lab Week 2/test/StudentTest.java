import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class StudentTest {

	public static final String NAME = "Boris Valerstein";
	Student student;

	@BeforeEach
	void setUp() {
		student = new Student(NAME);
	}

	@Test
	void student_has_name() {
		assertEquals(NAME, student.getName());
	}

	@Test
	void student_is_not_enrolled_in_any_courses_initially() {
		assertTrue(student.getCourses().isEmpty());
	}

}
