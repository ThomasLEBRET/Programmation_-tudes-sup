package musiqueTD1Feuilles20212022ADiffuser;

public class Conservatoire {

	public static void main(String[] args) {
		
	  //Déclarations
		FluteABec f1;
		InstrumentAVent f2;
		InstrumentDeMusique f3; 
	
	  //Créations	
	  f1 = new FluteABec ("picolo vert","John");
	  f2 = new FluteABec ("traversière jaune","Florence");
	  f3 = new FluteABec ("f3", "Bruno");
	  
	  //Utilisations
	  System.out.println( "Entree du magazin\n"
			  +"             	  "+f1+"\n"
			  +"             	  "+f2+"\n"
			  +"             	  "+f3+"\n"
			  +"sortie du magazin."   +"\n");	
	  
	  System.out.println( "Entree du conservatoire\n"
	  +"             	  "+f1.jouer()+"\n"
	  +"             	  "+f2.jouer()+"\n"
	  +"             	  "+f3.jouer()+"\n"
	  +"sortie du conservatoire."     +"\n");	
	  
	  
	}

}
