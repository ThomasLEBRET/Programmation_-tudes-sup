package tri_insertion;
import java.util.ArrayList;
import musiqueTD1Feuilles20212022ADiffuser.*;

public class tri_insertion {
		
		public static ArrayList<InstrumentDeMusique> triInstrument(ArrayList<InstrumentDeMusique> listeinstrument) {
            
            for(int indice=0; indice<listeinstrument.size();indice++) {
                InstrumentDeMusique instrumentAInserer = (InstrumentDeMusique) listeinstrument.get(indice);
                int aComparer=indice-1;
                while(aComparer>=0 && (instrumentAInserer.indiquer_identite().compareTo(((InstrumentDeMusique) listeinstrument.get(aComparer)).indiquer_identite()))>0) {
                 listeinstrument.set(aComparer+1, listeinstrument.get(aComparer));
                 aComparer--;   
                }
                listeinstrument.set(aComparer+1, instrumentAInserer);
            }
            return listeinstrument;
          }
}
