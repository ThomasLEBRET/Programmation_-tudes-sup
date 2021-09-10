package musiqueTD1Feuilles20212022ADiffuser;

public interface InstrumentDeMusique {
	public String jouer();
	public String indiquer_identite();
	public String indiquer_proprietaire();
	public void changerProprietaire(String nouveau);
}
