package multiplication;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class MachinTestMultiplication {
	static Byte a = 5;
	static Byte b = 4;

	@BeforeAll
	static void setUpBeforeClass() throws Exception {
	}

	@AfterAll
	static void tearDownAfterClass() throws Exception {
	}

	@BeforeEach
	void setUp() throws Exception {
	}

	@AfterEach
	void tearDown() throws Exception {
	}

	@Test
	void testEqual() {
		assertEquals(20, Machin.valeurNumeriqueDeab(a, b));
	}
	
	@Test
	void testNotEqual() {
		assertNotEquals(30, Machin.valeurNumeriqueDeab(a, b));
	}

}
