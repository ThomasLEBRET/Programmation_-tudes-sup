package tp1;

import musiqueTD1Feuilles20212022ADiffuser.*;
import java.util.ArrayList;

public class UtiliseMusiqueLebretThomas {
	
	public static void main(String[] args) {
		InstrumentAVent     a1 = new FluteABec("Janine" , "John");
		InstrumentAVent     a2 = new FluteABec("traversière jaune" , "Florence");
		InstrumentAVent     a3 = new FluteABec("bb8" , "Bruno");
		InstrumentDeMusique a4 = new Trompette("bb9", "Bruno");
		InstrumentAVent     a5 = new Trompette("Janine" , "Florence");
		
		String name = args[0];
		String username = args[1];
		InstrumentAVent     a6;
		
		if(username.length() % 2 == 0) {
			 a6 = new FluteABec(name , username);
		} 
		else {
			a6 = new Trompette(name , username);
		}
		
		ArrayList<InstrumentDeMusique> l1 = new ArrayList();
		l1.add(a1);
		l1.add(a2);
		l1.add(a3);
		l1.add(a4);
		l1.add(a5);
		l1.add(a6);
		
		for(int i = l1.size() - 1; i >= 0; i--) {
			System.out.println(l1.get(i).jouer());
		}
		
		
		
		//Q15
		InstrumentDeMusique tmp;
		InstrumentDeMusique instruments[] = {a1, a2, a3, a4, a5, a6};
		
		//Tri ordre alphabétique par nom de propriétaire
		for (int i = 0; i < instruments.length; i++) {
            for (int j = i + 1; j < instruments.length; j++) {
                if (instruments[i].indiquer_proprietaire().toLowerCase().compareTo(instruments[j].indiquer_proprietaire().toLowerCase()) > 0) {
                    tmp = instruments[i];
                    instruments[i] = instruments[j];
                    instruments[j] = tmp;
                }
            }
        }
		/*
		for(int i = 0; i < instruments.length; i++) {
			System.out.println(instruments[i].indiquer_proprietaire());
		}
		*/
		
		//Tri ordre alphabétique inversé par nom d'instruments
		for (int i = 0; i < instruments.length; i++) {
            for (int j = i + 1; j < instruments.length; j++) {
                if (instruments[i].indiquer_identite().toLowerCase().compareTo(instruments[j].indiquer_identite().toLowerCase()) < 0) {
                    tmp = instruments[i];
                    instruments[i] = instruments[j];
                    instruments[j] = tmp;
                }
            }
        }
		
		/*
		for(int i = 0; i < instruments.length; i++) {
			System.out.println(instruments[i].indiquer_identite());
		}
		*/
	}
}
