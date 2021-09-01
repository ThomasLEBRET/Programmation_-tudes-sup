class Exo6 {
    public static void main(String[] args) {
        int[] numero = {2,3,4,5,6};
        int[] solde = {1200, 500, 200, 600, 3000};
        int[] salaire = {2500, 1050, 2500, 3000, 4250};

        double tx = 0.1;

        for(int i = 0; i < numero.length; i++) {
            System.out.println("Le compte numéro " + numero[i] + " est soldé de " + solde[i] + " et a un salaire équivalent à " + salaire[i] + "E.");
            System.out.println("Le montant acceptable de découvert pour ce compte est de " + salaire[i]*tx + ".");
        }
    }
}
