package jouerALaBataille;

import java.util.*;

public class MComparateurValeurFacialeCarte implements Comparator {
	public MComparateurValeurFacialeCarte() {
		
	}
	
	@Override
	public int compare(Object o1, Object o2) {
		if(o1 != null && o2 != null) {
			MCarte c1 = (MCarte)o1;
			MCarte c2 = (MCarte)o2;
			
			if(c1.valeurFace() == c2.valeurFace())
				return 0;
			if(c1.valeurFace() < c2.valeurFace()) {
				return -1;
			}
			else
				return 1;
		}
		return 0;
	}
}
