package forme;

/**
 * @author Thomas LEBRET, Alex CORVEST
 */

public class Bidon {
	
	private final double PI = Math.PI;
	private double rayon, hauteur, qteLiquide;
	
	/**
	 * Constructeur de la classe bidon permettant de créer un cylindre avec une hauteur, un rayon et une quantité de liquide initiale
	 * La quantité de liquide est supérieur ou égal à 0 et inférieur ou égale au volume max du cylindre.  
	 * Le rayon et la hauteur doivent etre strictement supérieur à 0.
	 * @param rayon  le rayon du cylindre de type double
	 * @param hauteur la hauteur du cylindre de type double
	 * @param qteLiquide la quantité de liquide maximale du cylindre de type double
	 */
	public Bidon(double rayon, double hauteur, double qteLiquide) {
		
	}
	
	/**
	 * Surcharge contructeur de la classe bidon permettant de créer un cylindre avec une hauteur et un rayon initial.
	 * La quantité de liquide est supérieur ou égal à 0 et inférieur ou égale au volume max du cylindre.  
	 * Le rayon et la hauteur doivent etre strictement supérieur à 0.
	 * @param rayon  le rayon du cylindre de type double
	 * @param hauteur la hauteur du cylindre de type double
	 */
	public Bidon(double rayon, double hauteur) {
		
	}
	
	/**
	 * Accesseur du rayon du cylindre 
	 * @return le rayon du cylindre de type double
	 */
	public double getRayon() {
		
	}
	
	
	/**
	 * Accesseur de la hauteur du cylindre
	 * @return la hauteur du cylindre de type double
	 */
	public double getHauteur() {
		
	}
	
	
	/**
	 * Accesseur retournant la quantité de liquide composant le bidon.
	 * @return qteLiquide de type double
	 */
	public double getQteLiquide() {
		
	}
	
	/**
	 * Mutateur changeant la quantité de liquide composant le bidon par celle passée en paramètre
	 * @param qteLiquide la nouvelle quantité de liquide
	 */
	public void setQteLiquide(double qteLiquide) {
		
	}
	
	/**
	 * Calcul et renvoi l'air du cercle du cylindre (afin de calculer le volume du cylindre entre autre)
	 * Elle se calciul par R^2*PI
	 * @return l'air du cercle du cylindre en private
	 */
	private double getAirCercle() {
		
	}
	
	/**
	 * Accesseur du volume maximum du cylindre.
	 * Il se calcul comme : air du cercle * hauteur du cylindre.
	 * @return le volume maximal du cylindre de type double
	 */
	public double getVolumeMax() {
		
	}	

	
	/**
	 * Ajoute une quantité de liquide dans le cylindre. 
	 * La quantité ajoutée + le volume de liquide courant du cylindre ne doit pas dépasser le volumeMax du cylindre.
	 * @param qte la quantité de liquide à ajouter dans le cylindre
	 */
	public void ajouterVolume(double qte) {
		
	}
	
	/**
	 * Retirer une quantité de liquide dans le cylindre. 
	 * Le volume courant du bidon - qte, la quantité restante doit être supérieur ou égale à 0.
	 * @param qte la quantité de liquide à retirer dans le cylindre
	 */
	public void retirerVolume(double qte) {
		
	}
	
	/**
	 * Ajoute une quantité de liquide dans le cylindre. 
	 * 1 + le volume de liquide courant du cylindre ne doit pas dépasser le volumeMax du cylindre.
	 */
	public void ajouterUnLitre() {
		
	}
	
	/**
	 * Retirer un litre de liquide dans le cylindre. 
	 * Le volume courant du bidon - 1, la quantité restante doit être supérieur ou égale à 0.
	 */
	public void retirerUnLitre() {
		
	}
	
	/**
	 * Met à 0 la valeur qteLiquide du bidon
	 */
	public void vider() {
		
	}
	
	/**
	 * Met à volumeMax la valeur qteLiquide du bidon
	 */
	public void remplir() {
		
	}
	
	/**
	 * Transvase le contenu du bidon d'indice i dans le bidon d'indice j dans le tableau de bidon tB.
	 * Si le volumeMax du bidon receveur ne peut pas contenir la quantité de volume du bidon i, 
	 * il restera un reliquat de liquide dans le bidon i et le bidon j sera intégralement rempli.
	 * @param tB un tableau de bidon
	 * @param i l'indice du bidon à trasvaser
	 * @param j l'indice du bidon recevant le contenu de liquide du bidon d'indice i
	 */
	public void trasvaser(Bidon[] tB, int i, int j) {
		
	}
	
	/**
	 * Echange le contenu du bidon d'indice i dans le bidon d'indice j dans le tableau de bidon tB.
	 * Si le volumeMax du bidon receveur ne peut pas contenir la quantité de volume du bidon i, on échange pas.
	 * @param tB un tableau de bidon
	 * @param i l'indice du bidon à échanger
	 * @param j l'indice du bidon à échanger
	 */
	public void echanger(Bidon[] tB, int i, int j) {
		
	}
	
	
}
