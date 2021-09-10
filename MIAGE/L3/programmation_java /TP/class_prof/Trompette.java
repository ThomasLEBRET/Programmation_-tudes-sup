package musiqueTD1Feuilles20212022ADiffuser;

public class Trompette extends InstrumentAVent {

	public Trompette(String lequel, String aQui) {
		super(lequel, aQui);
	}

	@Override
	public String jouer() {
		return "Je suis "+ this.indiquer_identite()+ ", la trompette de " + this.indiquer_proprietaire()+" "
	              + "et je joue \" pom pom pom pom \" . ";		
	}

}
