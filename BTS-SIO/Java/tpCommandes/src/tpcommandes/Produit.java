/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpcommandes;

/**
 *
 * @author Thomas
 */
class Produit {
    private String nom;
    private String code;
    private int prix;

    public Produit(String nom, String code, int prix) {
        this.nom = nom;
        this.code = code;
        this.prix = prix;
    }
    
    public int getPrix() {
        return prix;
    }

    @Override
    public String toString() {
        return "Produit{" + "nom=" + nom + ", code=" + code + ", prix=" + prix + '}';
    }
   
}
