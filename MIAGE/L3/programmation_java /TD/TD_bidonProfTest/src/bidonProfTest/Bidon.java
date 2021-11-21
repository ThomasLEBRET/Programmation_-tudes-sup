package bidonProfTest;

/**
 * Bidon pour test : Sara Messaoudene, Marc Mansouri, Thomas LEBRET
 * Problème : 6 failures lors du test -> vient de la précision, 
 * on ne comprend pas à quoi elle sert dans le code
 */

public class Bidon {
    final double PI = Math.PI;
    
	private double hauteur, volumeMax, volumeCourant, largeur, precision;
	
	public Bidon(double hauteur, double volumeMax, double volumeCourant) {
		volumeCourant = Math.abs(volumeCourant);
		this.volumeMax = Math.abs(volumeMax);
		this.hauteur = Math.abs(hauteur);
		
		if(volumeCourant > volumeMax)
			this.volumeCourant = volumeMax;
		else
			this.volumeCourant = volumeCourant;
		
		this.largeur = (Math.sqrt(this.volumeMax*1000/(PI*this.hauteur)))*2;
		this.precision = this.volumeMax/100;
	}

	public Bidon(int hauteur, int largeur) {
		this.hauteur = Math.abs(hauteur);
		this.largeur = Math.abs(largeur);
		this.volumeCourant = 0;
		this.volumeMax = PI * Math.pow(this.largeur/2, 2) * this.hauteur;
		this.precision = this.volumeMax/100;
	}

	public boolean est_plein() {
		return (volumeCourant() == volumeMax());
	}

	public boolean est_vide() {
		return (volumeCourant() == 0);
	}

	public double hauteurCourante() {
		return volumeCourant()*1000/(PI*Math.pow(this.largeur/2,2));
		
	}

	public double precisionEnCm() {
		return Math.cbrt(this.precision);
	}

	public double volumeCourant() {
		return this.volumeCourant*1000;
	}

	public double precisionEnCm3() {
		return precisionEnCm()*1000;
	}

	public double hauteur() {
		return this.hauteur;
	}

	public double largeur() {
		return this.largeur;
	}

	public double rayon() {
		return this.largeur/2;
	}

	public double volumeMaxEnCm3() {
		return volumeMax()*1000;
	}
	
	public double volumeMax() {
		return PI*Math.pow(rayon(),2)*hauteur()/1000;
	}

	public double ajouter(double volume) {
		if(volume < 0) 
			return 0;
		else {
			double new_volume=volumeCourant()+ volume;

			if(new_volume< volumeMax()) {
				this.volumeCourant= this.volumeCourant()+volume;
				return volume;
			} 
			else {

				double tmp= volumeMax()-volumeCourant();
				remplir();
				return tmp;
			}
		}
		
	}

	public boolean ajouter1LitreSiPossible() {
		double new_volume=volumeCourant()+1;

		if(new_volume <= volumeMax()) {
			this.volumeCourant= this.volumeCourant()+1;
			return true ;
		}
		return false;
	}

	public double ajouterHauteur(double hauteurEnCm) {
		hauteurEnCm = Math.abs(hauteurEnCm);
		double new_hauteur=hauteurCourante()+hauteurEnCm;
		if(new_hauteur <= hauteur()) {
			this.volumeCourant= (Math.PI*Math.pow(rayon(),2)*new_hauteur)/1000;
			return hauteurEnCm;
		} 
		else {
			double val_ajoute=hauteur()-hauteurCourante();
			remplir();
			return val_ajoute;
		}
	}

	public boolean ajouterM3SiPossible() {
		double new_volume= (volumeCourant()/1000) +1;

		if( new_volume < (volumeMax()/1000)) {
			this.volumeCourant= this.volumeCourant()+1;
			return true;
		} 
		else 
			return false;
	}

	public void changePrecision(double nouvellePrecision) {
		this.precision = nouvellePrecision;
	}

	public double diminuerHauteur(double hauteurEnCm) {
		hauteurEnCm = Math.abs(hauteurEnCm);
		
		double new_hauteur=hauteurCourante()-hauteurEnCm;
		
		if(new_hauteur >= 0) {
			this.volumeCourant= (Math.PI*Math.pow(rayon(),2)*new_hauteur)/1000;
			return hauteurEnCm;
			}
		else {
			double tmp=hauteurCourante();
			vider();
			return tmp ;
		}
	}

	public void remplir() {
		this.volumeCourant = volumeMax();
	}

	public void vider() {
		this.volumeCourant = 0;
	}

	public double retirer(double volumeEnLitre) {
		volumeEnLitre = Math.abs(volumeEnLitre);
		
		double new_volume=volumeCourant()-volumeEnLitre;

		if(new_volume >= 0) {
			this.volumeCourant= this.volumeCourant()-volumeEnLitre;
			return volumeEnLitre;
		} 
		else {
			double tmp = volumeCourant();
			vider();
			return tmp;
		}
	}

	public double verser(Bidon destination) {
		if(!(destination.est_plein()))
			return diminuerHauteur(destination.ajouter(volumeCourant()));	
		
		return 0;
	}

	public double transvaser(double hauteurEnCm, Bidon destination) {
		if(!(destination.est_plein())) {
			diminuerHauteur(hauteurEnCm);
			return destination.ajouter( (Math.PI*Math.pow(rayon(),2)*hauteurEnCm)/1000 );
		}

		return 0;
	}
	
	public String toString() {
		return
				(" Bidon "
						+ super.toString()
						+ " \n de "
						+ this.hauteur()
						+ " cm de haut \n par "
						+ this.largeur()
						+ " cm de large, "
						+ " \n d'un volume max de "
						+ this.volumeMax()
						+ " litres. \n"
						+ "Il contient un volume courant de "
						+ this.volumeCourant()
						+ " litres \n soit "
						+ this.hauteurCourante()+ " cm de liquide.");
	}
	
	
	
}
