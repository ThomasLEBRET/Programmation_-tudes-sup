package multiplication;

public class Machin {
	 /**
	   * Cette méthode doit exprimer la valeur numérique entière de la multiplication des deux chiffres b et a
	   * Exemple: si a= 10 et b=9 on doit obtenir l'entier 90 (9*10).
	   * @param a un entier sur un octet
	   * @param b un entier sur un octet
	   * @return la valeur numérique de l'entier b*a
	   */
	public static int valeurNumeriqueDeab(Byte a, Byte b) {
		return Integer.parseInt(""+b*a);
	}
}


