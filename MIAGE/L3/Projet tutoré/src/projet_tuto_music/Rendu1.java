package projet_tuto_music;

import java.util.Scanner;
import java.util.*;

public class Rendu1 {
	public static void main(String[] args) {
		
		List<String> playlistLocale = new ArrayList<String>();
		String nomMusique, auteurMusique, urlYoutube, pseudo, musique;

		
		Scanner sc = new Scanner(System.in);
		System.out.println("Veuillez saisir un pseudo :");
		pseudo = sc.next();
		
		System.out.println("Votre pseudo : " + pseudo);
		
		int quit = 0;
		
		System.out.println("Bienvenu dans votre espace musique :");
		
		do {
			System.out.println();System.out.println();System.out.println();
			
			System.out.println("1 -> Voir la playlist locale");
			System.out.println("2 -> Ajouter une musique (lien Youtube) ");
			System.out.println("3 -> Ajouter une musique (nom, auteur) ");
			System.out.println("4 -> Quitter");
		
			do {
				quit = sc.nextInt();
			} while(quit < 0 || quit > 4);
			
			System.out.println();
			
			switch(quit) {
			case 1:
				for(int i = 0; i < playlistLocale.size(); i++) {
					musique = playlistLocale.get(i);
					System.out.println(musique);
				}
				break;
			case 2: 
				System.out.println("Entrez le lien d'une video de musique Youtube :");

				do {
					urlYoutube = sc.next();
				} while(!urlYoutube.contains("www.youtube.com/watch?v="));
				playlistLocale.add(urlYoutube + " : Ajouté par " + pseudo);
				
				System.out.println("Votre vidéo a été ajoutee !");
				break;
			case 3 :
				System.out.println("Entrez ici le nom et l'artiste de la musique :");
				
				
				do {
					System.out.print("Nom : ");
					nomMusique = sc.next();
					
					System.out.println();
					
					System.out.print("Auteur : ");
					auteurMusique = sc.next();
				} while(auteurMusique == "" || nomMusique == "");
				playlistLocale.add(nomMusique + " par " + auteurMusique + " : Ajoute par " + pseudo);
				break;
			case 4:
				System.out.println("Au revoir " + pseudo + ". Au plaisir de partager à nouveau de la musique avec vous.");
				break;
			}
			
		} while(quit != 4);
	}
}
