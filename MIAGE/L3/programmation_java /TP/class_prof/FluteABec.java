package musiqueTD1Feuilles20212022ADiffuser;

public class FluteABec extends InstrumentAVent {

	public FluteABec(String lequel, String aQui) {
		super(lequel, aQui);
	}

	@Override
	public String jouer() {		
		return this.toString()+"Je siffle.";
	}
	
	public String toString() {
		return new String("Je suis une flute � Bec nomm�e "+ this.indiquer_identite() 
		+ ", j'appartiens � " + this.indiquer_proprietaire()+". " );
	}

}
