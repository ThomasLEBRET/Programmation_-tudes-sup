package tri_insertion;

import static org.junit.jupiter.api.Assertions.*;

import java.util.ArrayList;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import musiqueTD1Feuilles20212022ADiffuser.*;

class test_tri_insertion {
	public static ArrayList<InstrumentDeMusique> listeinstrument;
	@BeforeAll
	static void setUpBeforeClass() throws Exception {
		listeinstrument = new ArrayList<InstrumentDeMusique>();
		
		InstrumentAVent     a1 = new FluteABec("Janine" , "John");
		InstrumentAVent     a2 = new FluteABec("traversière jaune" , "Florence");
		InstrumentAVent     a3 = new FluteABec("bb8" , "Bruno");
		InstrumentDeMusique a4 = new Trompette("bb9", "Bruno");
		InstrumentAVent     a5 = new Trompette("Janine" , "Florence");
		
		listeinstrument.add(a1);
		listeinstrument.add(a2);
		listeinstrument.add(a3);
		listeinstrument.add(a4);
		listeinstrument.add(a5);
	}

	@AfterAll
	static void tearDownAfterClass() throws Exception {
	}

	@BeforeEach
	void setUp() throws Exception {
		InstrumentAVent     a1 = new FluteABec("Janine" , "John");
		InstrumentAVent     a2 = new FluteABec("traversière jaune" , "Florence");
		InstrumentAVent     a3 = new FluteABec("bb8" , "Bruno");
		InstrumentDeMusique a4 = new Trompette("bb9", "Bruno");
		InstrumentAVent     a5 = new Trompette("Janine" , "Florence");
	}

	@AfterEach
	void tearDown() throws Exception {
	}

	@Test
	void test() {
	}

}
