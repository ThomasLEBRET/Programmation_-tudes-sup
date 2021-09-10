package musiqueTD1Feuilles20212022ADiffuser;

public abstract class  InstrumentAVent implements InstrumentDeMusique {
	
	private String _proprietaire;
	private String _identite;

	public InstrumentAVent(String lequel, String aQui) {
		_proprietaire = aQui;
		_identite = lequel;
	}

	@Override
	public abstract String jouer() ;

	@Override
	public String indiquer_identite() {		
		return _identite;
	}

	@Override
	public String indiquer_proprietaire() {
		return _proprietaire;
	}

	@Override
	public void changerProprietaire(String nouveau) {
		_proprietaire = nouveau; 
	}

}
