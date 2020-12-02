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
public class MainClass {
    public static void main(String[] args) {
        Vehicule v1, v2, v3, v4, v5;

        v1 = new Vehicule("aaa", "bleue");
        v2 = new Vehicule("bbb");

        v3 = new Voiture("ccc", "rouge", "automatique", 5);
        v4 = new Voiture("ddd", "automatique", 5);
        v5 = new Voiture("eee", 6);
        
        System.out.println(v1);
        System.out.println(v2);
        System.out.println(v3);
        System.out.println(v4);
        System.out.println(v5);
    }
}
