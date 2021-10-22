package bidonProf;

// Précision : en fonction du volume max du bidon

public class Bidon {
	private double hauteur;
	private double largeur;
	private double rayon;
	private double volumeCourant;
	private double volumeMax;
	private double precision;
	
	/**
	 * construit un bidon vide avec la précision par défaut et dont les dimensions sont précisées en paramètre
	 * @param hauteur : la hauteur en cm
	 * @param largeur la largeur en cm
	 */
	public Bidon(int hauteur, int largeur) {
		this.hauteur = hauteur;
		this.largeur = largeur;
		this.rayon = this.largeur/2;
		this.volumeCourant = 0;
		this.volumeMax = Math.PI * Math.pow(rayon, 2) * this.hauteur * 1000;
		this.precision = (this.volumeMax * 1) / 100; // 1% de précision
	}
	
	/**
	 * construit un bidon avec un volume courant prédéfini ainsi que son volume max et sa hauteur
	 * son volume max doit etre inférieur ou égal à son volume courant
	 * @param hauteur : la hauteur en cm
	 * @param volumeMax : le volume en litre (1L = 1000cm3)
	 * @param volumeCourant : le volume courant prédéfini 
	 */
	public Bidon(double hauteur, double volumeMax, double volumeCourant) {
		this.hauteur = hauteur; 
		this.volumeMax = volumeMax * 1000;
		this.volumeCourant = volumeCourant * 1000;
		if(this.volumeMax < this.volumeCourant)
			this.volumeCourant = this.volumeMax;
		this.rayon = Math.sqrt((this.volumeMax / this.hauteur) / Math.PI);
		this.largeur = this.rayon * 2;
		this.precision = (this.volumeMax * 1) / 100;
	}
	
	/**
	 * un bidon vide peut contenir du liquide mais moins que la précision définie pour ce dernier
	 * @return un booléen qui indique si le bidon est vide
	 */
	public boolean est_vide() {
		if(this.volumeCourant <= this.precision && this.volumeCourant >= 0) {
			return true;
		}
		return false;
	}
	
	/**
	 * un bidon plein contient du liquide tel que le volumeCourant = volumeMax à précision près
	 * @return un booléen qui indique si le bidon est plein 
	 */
	public boolean est_plein() {
		if(this.volumeMax - this.volumeCourant <= this.precision && this.volumeMax - this.volumeCourant >= 0) {
			return true;
		}
		return false;
	}
	
	/**
	 * Vide le contenu du bidon
	 */
	public void vider() {
		this.volumeCourant = 0;
	}
	
	/**
	 * Rempli le bidon à précision près 
	 */
	public void remplir() {
		this.volumeCourant = this.volumeMax - this.precision;
	}
	
	/**
	 * tente d'ajouter une hauteur en cm de liquide et retourne la valeur effectivement ajoutée
	 * @param hauteurEnCm : la hauteur en cm de liquide à ajouter
	 * @return la hautuer de liquide en cm ajoutée 
	 */
	public double ajouterHauteur(double hauteurEnCm) {
		double hauteurAjoutable = this.hauteur - hauteurCourante();
		if(hauteurAjoutable >= hauteurEnCm) {
			this.volumeCourant += hauteurEnCm * (Math.PI * Math.pow(this.rayon, 2));
			return hauteurEnCm;
		}
		else {
			this.volumeCourant = hauteurAjoutable;
			return hauteurAjoutable;
		}
	}
	
	/**
	 * tente d'ajoute un volume en litre de liquide et retourne la valeur effectivement ajoutée
	 * @param volumeEnLitre : le volume en litre à ajouter
	 * @return le volume en litre ajouté 
	 */
	public double ajouter(double volumeEnLitre) {
		double volumeAjoutable = this.volumeMax - this.volumeCourant;
		if(volumeAjoutable >= volumeEnLitre) {
			this.volumeCourant += volumeEnLitre;
			return volumeEnLitre;
		}
		else {
			this.volumeCourant += volumeAjoutable;
			return volumeAjoutable;
		}
	}
	
	
}