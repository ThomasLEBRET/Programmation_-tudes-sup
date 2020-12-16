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
public class Vehicule {
    private String couleur;
    private String immat;

    @Override
    public String toString() {
        return immat + " : " + couleur + "/";
    }
    
    Vehicule(String immat) {
        this.immat = immat;
    }
    
    Vehicule(String immat, String couleur) {
        this.immat = immat;
        this.couleur = couleur;
    }
}
