/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpcommandes;

import java.time.LocalDate;
import java.util.ArrayList;

/**
 *
 * @author Thomas
 */
public class TpCommandes {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Commande c1 = new Commande(1, LocalDate.now());
        Produit p1 = new Produit("Nintendo Switch", "NSW", 300);
        c1.ajouterProduit(p1);
        c1.ajouterProduit(new Produit("PlayStation 5", "PS5", 500));
        System.out.println(c1.toString());
        for (Produit p : c1.getListProds()) {
            System.out.println(p.toString());
        }
        
        Commande c2 = new CommandeVIP(2, LocalDate.now(), 50);
        Produit p2 = new Produit("Converse All Star", "CONV", 200);
        c2.ajouterProduit(p2);
        c2.ajouterProduit(new Produit("Nike", "NI", 200));
        c2.ajouterProduit(new Produit("Balanciaga", "BAL", 400));
        System.out.println(c2.toString());
        for (Produit p : c2.getListProds()) {
            System.out.println(p.toString());
        }
        
        System.out.println(c2.getPrixTotal());
        
        c2.ajouterProduit(new Produit("Vans", "VA", 600));
        System.out.println(c2.toString());
        for (Produit p : c2.getListProds()) {
            System.out.println(p.toString());
        }
        
        System.out.println(c2.getPrixTotal());
        
    }
    
}
