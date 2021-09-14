package baseDix;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class MachinBaseDixTest {
	static Byte a = 5;
	static Byte b = 2;

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
	void testEquals() {
		assertEquals(52, Machin.baseDix(a, b));
	}
	
	@Test
	void testNotEquals() {
		assertNotEquals(25, Machin.baseDix(a, b));
	}
	
	@Test
	void testParticulier() {
		Byte c = 0;
		assertEquals(0, Machin.baseDix(c, c));
	}

}
