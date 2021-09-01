class Compte {
    private int salaire;
    private int solde;
    private int no;

    private static int lastNo = 0;
    private static double tx;

    public Compte(int salaire, int solde) {
        this.salaire = salaire;
        this.solde = solde;

        lastNo++;
        this.no = lastNo;
    }

    public Compte() { }

    public static void displayCompte(Compte c) {
        System.out.println("Le compte numéro " + c.no + " est soldé de " + c.solde + " et a un salaire de " + c.salaire + " et bénéficie d'un taux de " + tx + ".");
    }

    public double getTaux() {
        return tx;
    }

    public void setTaux(double taux) {
        tx = taux;
    }

    public int getSalaire() {
        return salaire;
    }

    public int getSolde() {
        return solde;
    } 

    public int getNo() {
        return no;
    }

    public Compte getCompte(Compte[] t, int no) {
        Compte c = new Compte();
        for(int i = 0; i < t.length; i++) {
            if(t[i].no == no) {
                c = t[i];
                break;
            }
        }
        return c;
    }

    public static int getNoPlusHautSalaire(Compte[] t) {
        int meilleurSalaire = t[0].no;
        for(int i = 0; i < t.length; i++) {
            if(meilleurSalaire < t[i].salaire)
                meilleurSalaire = t[i].no;
        }
        return meilleurSalaire;
    }

    public void equilibreCompte(Compte[] t) {
        t[0].salaire = getCompte(t, getNoPlusHautSalaire(t)).salaire;
    }
}


class Exo3 {
    public static void main(String[] args) {
        Compte c1 = new Compte(2000,4000);
        Compte c2 = new Compte(1000,2000);
        Compte c3 = new Compte(1500,500);

        Compte[] tC = {c1,c2,c3};

        Compte.displayCompte(c1);
        System.out.println(Compte.getNoPlusHautSalaire(tC));

    }
    
}
