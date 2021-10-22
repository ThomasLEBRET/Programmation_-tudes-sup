package jouerALaBataille;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class MCarteTest {
	MCarte roiCoeur ;
    MCarte asTrefle ;
    MCarte valetPique ;
    MCarte deuxCarreau ;
    MCarte asCoeur;
    MComparateurValeurFacialeCarte comp;

	@BeforeAll
	static void setUpBeforeClass() throws Exception {
	}

	@AfterAll
	static void tearDownAfterClass() throws Exception {
	}

	@BeforeEach
	void setUp() throws Exception {
		roiCoeur    = new MCarte(ECouleurs.Coeur,EFaces.ROI);
        asTrefle    = new MCarte(ECouleurs.Trèfle,EFaces.AS);
        valetPique  = new MCarte(ECouleurs.Pique,EFaces.VALET);
        deuxCarreau = new MCarte(ECouleurs.Carreau,EFaces.DEUX);
        asCoeur     = new MCarte(ECouleurs.Coeur,EFaces.AS);
        comp        = new MComparateurValeurFacialeCarte();

	}

	@Test
    void testCouleur() {
        assertEquals("Coeur",roiCoeur.couleur());
    }
    @Test
    void testvaleur() {
        assertEquals("AS",asTrefle.valeur());
        assertEquals("ROI",roiCoeur.valeur());
    }
    @Test
    void testvaleurFace() {
        assertEquals(12,asTrefle.valeurFace());
        assertEquals(11,roiCoeur.valeurFace());
        assertEquals(9,valetPique.valeurFace());
        assertEquals(0,deuxCarreau.valeurFace());
    }

    @Test
    void testcomparateurValeurFacialMCarteEgalite() {
        assertEquals(0, comp.compare(asCoeur, asTrefle) );
    }
    @Test
    void testcomparateurValeurFacialMCarteSuperieur() {
        assertTrue(comp.compare(asCoeur, roiCoeur)>0 );
    }
    @Test
    void testcomparateurValeurFacialMCarteInferieur() {
        assertTrue(comp.compare(deuxCarreau, roiCoeur)<0 );
    }


}
