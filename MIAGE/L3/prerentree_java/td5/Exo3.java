class Compte {
    int salaire;
    int solde;
    int no;

    static int lastNo = 0;
    static double tx;

    public Compte(int salaire, int solde) {
        this.salaire = salaire;
        this.solde = solde;

        lastNo++;
        this.no = lastNo;
    }

    static void afficherCompte(Compte c) {
        System.out.println("Le compte numéro " + c.no + " est soldé de " + c.solde + " et a un salaire de " + c.salaire + " et bénéficie d'un taux de " + tx + ".");
    }
}

class Exo3 {
    public static void main(String[] args) {
        Compte c1 = new Compte(1000, 400);
        Compte c2 = new Compte(2500, 800);
        Compte c3 = new Compte(3000, 1200);

        Compte.tx = Double.parseDouble(args[0]);
        Compte.afficherCompte(c1);

        if(c1.salaire > c2.salaire && c1.salaire > c3.salaire){
            System.out.println("Le compte numéro " + c1.no + " a le salaire le plus élevé.");
        }
        else if(c2.salaire > c1.salaire && c2.salaire > c3.salaire){
            System.out.println("Le compte numéro " + c2.no + " a le salaire le plus élevé.");
            c1.salaire = c2.salaire;
        }
        else {
            System.out.println("Le compte numéro " + c2.no + " a le salaire le plus élevé.");
            c1.salaire = c3.salaire;
        }
    }
}