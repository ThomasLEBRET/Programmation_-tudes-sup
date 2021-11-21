package jouerALaBataille;

import java.util.ArrayList;

public class MJoueur implements IMJoueurDeCartes {
	private String prenom;
	private ArrayList<MCarte> main;
	private ArrayList<ArrayList<MCarte>> plisHistorique;

	public MJoueur(String prenom) {
		this.prenom = prenom;
		this.main = new ArrayList<MCarte>();
		this.plisHistorique = new ArrayList<ArrayList<MCarte>>();
	}

	@Override
	public String prenom() {
		return this.prenom;
	}

	@Override
	/**
	 * Permet à un joueur de reçevoir une carte qui lui est transmise Il la place
	 * dans sa main.
	 */
	public boolean accepte(MCarte c) {
		return this.main.add(c);
	}

	@Override
	public void pose(MCarte c) {
		if (this.main.contains(c))
			this.main.remove(c);
	}

	@Override
	public boolean mainVide() {
		return (this.main.isEmpty());
	}

	@Override
	public int indiqueNombreCartesEnMain() {
		return (this.main.size());
	}

	@Override
	public boolean resteDesCartesEnMain(int n) {
		return (this.indiqueNombreCartesEnMain() >= n);
	}

	@Override
	public MCarte indiquePremiereCarteDuPaquet() {
		return (!this.mainVide()) ? this.main.get(0) : null;
	}

	@Override
	public MCarte donnePremiereCarteDuPaquet() {
		if (!this.mainVide()) {
			MCarte c = this.main.get(0);
			this.main.remove(0);
			return c;
		}

		return null;
	}

	@Override
	public MCarte indiqueNiemeCarteDeLaMainNonVide(int n) {
		return (!this.mainVide() && n < this.main.size()) ? this.main.get(n) : null;
	}

	@Override
	public MCarte donneNiemeCarteDeLaMainNonVide(int n) {
		if (!this.mainVide() && n < this.main.size()) {
			MCarte c = this.indiqueNiemeCarteDeLaMainNonVide(n);
			this.main.remove(n);
			return c;
		}
		return null;
	}

	@Override
	public void ramasse(ArrayList<MCarte> pli) {
		this.main.addAll(pli);
		this.plisHistorique.add(pli);
	}

	@Override
	public ArrayList<MCarte> indiqueLesPlisFaits() {
		ArrayList<MCarte> plisFaits = new ArrayList<MCarte>();
		for (ArrayList<MCarte> lC : plisHistorique) {
			for (MCarte c : lC) {
				plisFaits.add(c);
			}
		}
		return plisFaits;
	}

	@Override
	public int evaluePointsDesPlisFaits() {
		int cpt = 0;

		for (MCarte c : this.indiqueLesPlisFaits())
			cpt += c.valeurFace();

		return cpt;
	}

}
