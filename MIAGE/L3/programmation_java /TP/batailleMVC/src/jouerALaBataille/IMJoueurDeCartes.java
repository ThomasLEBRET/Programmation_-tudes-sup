package jouerALaBataille;

import java.util.ArrayList;

public interface IMJoueurDeCartes {
	public String prenom();

    public boolean accepte(MCarte c) ;
    public void pose(MCarte c);

    public boolean mainVide();
    public int indiqueNombreCartesEnMain();
    public boolean resteDesCartesEnMain(int n);

    public MCarte indiquePremiereCarteDuPaquet();
    public MCarte donnePremiereCarteDuPaquet();
    public MCarte indiqueNiemeCarteDeLaMainNonVide(int n);
    public MCarte donneNiemeCarteDeLaMainNonVide(int n);

    public void ramasse(ArrayList<MCarte> pli);
    public ArrayList<MCarte> indiqueLesPlisFaits();
    public int evaluePointsDesPlisFaits();
}
