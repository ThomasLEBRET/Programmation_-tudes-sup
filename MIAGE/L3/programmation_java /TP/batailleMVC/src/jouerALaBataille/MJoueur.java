package jouerALaBataille;

import java.util.ArrayList;

public class MJoueur implements IMJoueurDeCartes {

	@Override
	public String prenom() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean accepte(MCarte c) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public void pose(MCarte c) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public boolean mainVide() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public int indiqueNombreCartesEnMain() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public boolean resteDesCartesEnMain(int n) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public MCarte indiquePremiereCarteDuPaquet() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public MCarte donnePremiereCarteDuPaquet() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public MCarte indiqueNiemeCarteDeLaMainNonVide(int n) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public MCarte donneNiemeCarteDeLaMainNonVide(int n) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void ramasse(ArrayList<MCarte> pli) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public ArrayList<MCarte> indiqueLesPlisFaits() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public int evaluePointsDesPlisFaits() {
		// TODO Auto-generated method stub
		return 0;
	}

}
