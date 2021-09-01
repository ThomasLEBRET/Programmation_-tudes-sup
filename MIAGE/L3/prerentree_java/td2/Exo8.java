class Exo8 {
    public static void main(String[] args) {
        System.out.println("Saisissez un prénom");
        String prenom = args[0];
        int sexe = Integer.parseInt(args[1]);
        if(sexe == 6) 
            System.out.println("Bonjour Mademoiselle " + prenom);
        else if(sexe == 13) {
            System.out.println("Bonjour Monsieur " + prenom);
        }
        else {
            System.out.println("Bonjour E.T " + prenom);
        }
    }
}
