package tp1;

import musiqueTD1Feuilles20212022ADiffuser.*;

public class EssayeMusiqueLebretThomas {
	public static void main(String[] args)  {
		InstrumentDeMusique it   = new Trompette("Toad" ,  "Eva");
		InstrumentAVent     ifac = new FluteABec("Yosih" , "Jean");
		System.out.println("Les deux instruments crées sont "
		                   + it + "\n et \""+ ifac +"\"\n");
		System.out.println(it.jouer());
		System.out.println(ifac.jouer());
	}
}
