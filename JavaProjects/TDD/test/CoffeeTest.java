import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class CoffeeTest {

	Coffee coffee;

	@BeforeEach
	public void setUp() {
		coffee = new Coffee();
	}

	@Test
	public void coffee_created_with_100mg_sugar_by_default() {
		double actual = coffee.getSugar();

		assertEquals(Coffee.COFFEE_DEFAULT_SUGAR, actual);
	}

	@Test
	public void price_is_300_cents() {
		int actual = coffee.getPrice();

		assertEquals(Coffee.COFFEE_COST, actual);
	}
}
