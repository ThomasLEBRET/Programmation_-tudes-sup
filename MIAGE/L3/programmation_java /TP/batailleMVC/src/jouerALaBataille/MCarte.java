package jouerALaBataille;

public class MCarte {
	private ECouleurs couleur;
	private EFaces face;
	
	public MCarte(ECouleurs couleur, EFaces face) {
		this.couleur = couleur;
		this.face = face;
	}
	
	public String couleur() {
		return this.couleur.name();
	}
	
	public String valeur() {
		return this.face.name();
	}
	
	public int valeurFace() {
		return face.ordinal();
	}
}
