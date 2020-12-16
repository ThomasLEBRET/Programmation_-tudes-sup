/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpcommandes;

import java.time.LocalDate;

/**
 *
 * @author Thomas
 */
public class CommandeVIP extends Commande {
    private int txReduc;
    
    public CommandeVIP(int no, LocalDate date, int txReduc) {
        super(no, date);
        this.txReduc = txReduc;
    }
    
    @Override
    public float getPrixTotal() {
        float resultat = super.getPrixTotal()*(txReduc / 100f);
        if(resultat >= 200 && getListProds().size() >= 4) {
            resultat *= 0.75;
        }
        return resultat;
    }

    @Override
    public String toString() {
        return super.toString() + " : " + txReduc + "%";
    }
}
