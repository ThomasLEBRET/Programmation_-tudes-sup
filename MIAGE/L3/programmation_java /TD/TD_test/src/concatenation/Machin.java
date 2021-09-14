package concatenation;

public class Machin {
	 /**
	   * Cette méthode doit exprimer la valeur numérique entière de la conténation des deux chiffres b et a
	   * Exemple: si a= 10 et b=9 on doit obtenir l'entier 910.
	   * @param a un entier sur un octet
	   * @param b un entier sur un octet
	   * @return la valeur numérique de l'entier ba
	   */
	public static int concatenation(Byte a, Byte b) {
		return Integer.parseInt(""+b+a);
	}
}