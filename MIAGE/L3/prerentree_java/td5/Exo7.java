class Exo7 {
    static int[] numero = {2,3,4,5,6};
    static int[] solde = {1200, 500, 200, 600, 3000};
    static int[] salaire = {2500, 1050, 2500, 3000, 4250};

    static double tx = 0.1;

    public static void displayAllAccount() {
        for(int i = 0; i < numero.length; i++) {
            System.out.println("Le compte numéro " + numero[i] + " est soldé de " + solde[i] + " et a un salaire équivalent à " + salaire[i] + "E.");
            System.out.println("Le montant acceptable de découvert pour ce compte est de " + salaire[i]*tx + ".");
        }
    }

    public static void displayAccount(int n) {
        System.out.println("Le compte numéro " + numero[n] + " est soldé de " + solde[n] + " et a un salaire équivalent à " + salaire[n] + "E.");
        System.out.println("Le montant acceptable de découvert pour ce compte est de " + salaire[n]*tx + ".");
    }
    public static void main(String[] args) {

        displayAllAccount();
        displayAccount(0);
    }
}
