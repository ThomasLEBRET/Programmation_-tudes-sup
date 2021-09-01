class Client {
    int noCompte;
    String ville;
    String nom;

    static int noMax = 0;

    public Client(String ville, String nom) {
        noMax++;
        this.noCompte = noMax;
        this.ville = ville;
        this.nom = nom;
    }

    public static void afficherClient(Client c) {
        System.out.println("Le client " + c.nom + " vit à " + c.ville);
    }
}

class Exo4 {
    public static void main(String[] args) {
        Client c1 = new Client("Massy", "Didier");
        Client c2 = new Client("Chatelet", "Henry");

        Client.afficherClient(c1);
        Client.afficherClient(c2);
    }
}
