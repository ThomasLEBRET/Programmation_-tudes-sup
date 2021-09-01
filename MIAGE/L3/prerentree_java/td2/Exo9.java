class Exo9 {
    public static void main(String[] args) {
        System.out.println("Saisissez un prénom");
        String prenom = args[0];
        int sexe = Integer.parseInt(args[1]);
        switch(sexe) {
            case 6 : 
                System.out.println("Bonjour Mademoiselle " + prenom);
                break;
            case 13 : 
                System.out.println("Bonjour Monsieur " + prenom);
                break;
            default : 
                System.out.println("Bonjour E.T " + prenom);
        }
    }
}
