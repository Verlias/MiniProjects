public class Main {
	public static void main(String[] args) {
		Main main = new Main();
		main.start();
	}

	private void start() {
		Rectangle rectangle = new Rectangle(5, 6);
		System.out.println(rectangle.calculateArea());
		Square square = new Square(5);
		System.out.println(square.calculateArea());

		// Cat cat = new Cat(1.1);
		// speak(cat);

		// Dog dog = new Dog(3.5);
		// speak(dog);

		speak("cat");
		speak("dog");

	}

	void speak(String animalType) {
		Animal animal;
		if (animalType.equalsIgnoreCase("cat")) {
			animal = new Cat(1.1);
		} else {
			animal = new Dog(3.5);
		}
		System.out.println(animal.speak());

	}

}
