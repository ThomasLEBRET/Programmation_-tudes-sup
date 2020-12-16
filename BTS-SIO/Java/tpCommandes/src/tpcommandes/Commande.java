/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpcommandes;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Objects;

/**
 *
 * @author Thomas
 */
public class Commande {
    private int no;
    private LocalDate date;
    private ArrayList<Produit> listProds;

    public Commande(int no, LocalDate date) {
        this.no = no;
        this.date = date;
        this.listProds = new ArrayList<>();
    }

    public int getNo() {
        return no;
    }

    public LocalDate getDate() {
        return date;
    }

    public ArrayList<Produit> getListProds() {
        return listProds;
    }

    public void setDate(LocalDate date) {
        this.date = date;
    }

    public void setListProds(ArrayList<Produit> listProds) {
        this.listProds = listProds;
    }

    @Override
    public int hashCode() {
        int hash = 3;
        hash = 61 * hash + Objects.hashCode(this.no);
        hash = 61 * hash + Objects.hashCode(this.date);
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Commande other = (Commande) obj;
        if (!Objects.equals(this.no, other.no)) {
            return false;
        }
        return true;
    }
    
    public float getPrixTotal() {
        int resultat = 0;
        for (Produit p : listProds) {
            resultat += p.getPrix();
        }
        return resultat;
    }
    
    public void ajouterProduit(Produit p) {
        listProds.add(p);
    }
    
    @Override
    public String toString() {
        return "Commande{" + "no=" + no + ", date=" + date + '}';
    }
}
