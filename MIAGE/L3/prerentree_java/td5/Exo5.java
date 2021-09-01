class Comptee {
    int salaire;
    int solde;
    int no;

    static int lastNo = 0;
    static double tx;

    public Comptee(int salaire, int solde) {
        this.salaire = salaire;
        this.solde = solde;

        lastNo++;
        this.no = lastNo;
    }

    static void afficherCompte(Comptee c) {
        System.out.println("Le compte numéro " + c.no + " est soldé de " + c.solde + " et a un salaire de " + c.salaire + " et bénéficie d'un taux de " + tx + ".");
    }
}

class Clientt {
    Comptee compte;
    String ville;
    String nom;


    public Clientt(String ville, String nom, Comptee c) {
        this.ville = ville;
        this.nom = nom;
        this.compte = c;
    }

    public static void afficherClient(Clientt c) {
        System.out.println("Le client " + c.nom + " vit à " + c.ville);
    }
}

class Exo5 {
    public static void main(String[] args) {
        Comptee co1 = new Comptee(2000,4000);
        Clientt cl1 = new Clientt("Massy", "Didier", co1);

        Clientt.afficherClient(cl1);
    }
    
}
