/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.slam45_tptdheritageconstructeur;

/**
 *
 * @author Thomas
 */
public class Voiture extends Vehicule {
    private int nbVitesse;
    private String typeBoite;

    Voiture(String immat, String couleur, String typeBoite, int nbVitesse) {
        super(immat, couleur);
        this.typeBoite = typeBoite;
        this.nbVitesse = nbVitesse;
    }
    Voiture(String immat, String typeBoite,int nbVitesse) {
        super(immat);
        this.typeBoite = typeBoite;
        this.nbVitesse = nbVitesse;
    }
    Voiture(String immat, int nbVitesse) {
        super(immat);
        this.nbVitesse = nbVitesse;
    }

    @Override
    public String toString() {
        return super.toString()+ nbVitesse+"/"+typeBoite;
    }
}