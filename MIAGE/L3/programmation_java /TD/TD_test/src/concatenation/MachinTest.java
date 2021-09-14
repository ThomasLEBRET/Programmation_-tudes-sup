package concatenation;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class MachinTest {
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
		assertEquals(45, Machin.concatenation(a, b));
	}
	
	@Test
	void testNotEqual() {
		assertNotEquals(54, Machin.concatenation(a, b));
	}
	
	@Test
	void testParticulier() {
		Byte c = 0;
		assertEquals(0, Machin.concatenation(c,c));
	}

}
