package bidonProfTest;

/* A faire: par binome de trois rendez moi un fichier Bidon.java avec le
nom des trois auteurs @author qui passe le test suivant pour lundi 25
octobre 2021...*/

import static org.junit.jupiter.api.Assertions.*;

import java.util.ArrayList;


import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class BidonTest {
     static ArrayList<Bidon> bidons;
     Bidon baril, becher, cristalisoir, silo, soliflore, vase;
     static double PRECISION_TEST, PI;

     @BeforeAll
     static void setUpBeforeClass() throws Exception {
         PRECISION_TEST = 0.001;
         PI = Math.PI;
         bidons = new ArrayList<Bidon>();
     }

     @BeforeEach
     void setUp() throws Exception {
           // cas classiques
           baril        = new Bidon(100,543, 543);  // grand recipient plein a l'origine
           becher       = new Bidon(15, 0.5, 0.4); // petit recipient presque plein
           cristalisoir = new Bidon(10, 20, 10  );  // petit moyen moyennement vide moyennement plein
           silo         = new Bidon(500,2000);      // grand recipient vide a l'origine
           // cas limites
           soliflore    = new Bidon(-10 , 1, 2 );   // le volume courant est supérieur au volume Max et une valeur est négative
           vase         = new Bidon(-10, -20);      // Les quantités sont négatives


           //Pour tracer les objets créés
           bidons.add(baril);
           bidons.add(vase);
           bidons.add(cristalisoir);
           bidons.add(silo);
           bidons.add(soliflore);
           bidons.add(becher);
     }

// TESTER LES CONSTRUCTEURS

     /*
      * Le constructeur bidon construit un bidon vide avec la précision par défaut et
      * dont les dimensions sont précisées en paramètre
      * Si une des valeurs est négative on considérera sa valeur absolue.
      * @param hauteur: la hauteur en cm;
      * @param largeur: la largeur en cm;
      */
     @Test
     void testConstructeurIntInt() {
         //cas classique
         // construit un bidon vide
         assertFalse( silo.est_plein() );
         assertTrue ( silo.est_vide()  );
         assertEquals( silo.hauteurCourante(), 0 , silo.precisionEnCm() );
         assertEquals( silo.volumeCourant(),   0 , silo.precisionEnCm3()/1000 );

         // de hauteur, largeur donc rayon connus
         assertEquals( silo.hauteur()  ,  500 , PRECISION_TEST );
         assertEquals( silo.hauteur()  ,  500 , silo.precisionEnCm() );
         assertEquals( silo.hauteur()  ,  500 , silo.precisionEnCm() );
         assertEquals( silo.largeur()  , 2000 , silo.precisionEnCm() );
         assertEquals( silo.rayon()    , 1000 , silo.precisionEnCm() );

         // de volumeMax calculé selon la formule Pi h r2
         assertEquals( silo.volumeMaxEnCm3(),         PI* 500*1000*1000, silo.precisionEnCm3() );
         assertEquals( silo.volumeMax(),              PI* 500*1000     , silo.precisionEnCm3()/1000 );

         // cas limite
         // construit un bidon vide
         assertFalse(  vase.est_plein() );
         assertTrue (  vase.est_vide()  );
         assertEquals( vase.hauteurCourante(), 0 , vase.precisionEnCm() );
         assertEquals( vase.volumeCourant()  , 0 , vase.precisionEnCm3()/1000 );

         // de hauteur largeur donc rayon connu
         assertEquals( vase.hauteur()  , 10 , PRECISION_TEST);
         assertEquals( vase.hauteur()  , 10 , vase.precisionEnCm() );
         assertEquals( vase.largeur()  , 20 , vase.precisionEnCm() );
         assertEquals( vase.rayon()    , 10 , vase.precisionEnCm() );

         //de volumeMax calculé selon la formule Pi h r2
         assertEquals( vase.volumeMaxEnCm3(),  PI * 10*10*10 ,vase.precisionEnCm3() );
         assertEquals( vase.volumeMax(),       PI           ,vase.precisionEnCm3()/1000 );
     }

      /*
      * construit un bidon avec le volume courant prédéfini à partir
      * de son volume et de sa hauteur.
      * fonctionne avec la précision par défaut.
      * Si le volume courant demandé est supérieur au volume max un bidon plein de taille volumeMax est créé.
      * @param hauteur: la hauteur en cm;
      * @param volumeMax: le volume en litre (1 litre = 1000 cm3);
      * @param volumeCourant: le volume courant prédéfini en litres
      */

     @Test
     void testConstructeurDoubleDoubleDouble() {
         // cas limite
         // construit un bidon plein
         assertTrue(   soliflore.est_plein() );
         assertFalse ( soliflore.est_vide()  );
         assertEquals( soliflore.volumeCourant()  , soliflore.volumeMax() , soliflore.precisionEnCm3()/1000 );
         assertEquals( soliflore.hauteurCourante(), soliflore.hauteur() , soliflore.precisionEnCm() );



         // de hauteur volume et volume courant fixé
         
         
         assertEquals( soliflore.hauteur()          , 10       , 0.001);
         assertEquals( soliflore.hauteur()          , 10       ,soliflore.precisionEnCm() );
         assertEquals( soliflore.volumeMax()        , 1        ,soliflore.precisionEnCm3()/1000 );
         assertEquals( soliflore.volumeMaxEnCm3()   , 1000     ,soliflore.precisionEnCm3()/1000 );
         assertEquals( soliflore.volumeCourant()    , 1        ,soliflore.precisionEnCm3() );

         //de rayon, hauteur courante et largeur à calculer
         assertEquals( soliflore.rayon()    ,Math.sqrt(1*1000/(PI*10))    ,  soliflore.precisionEnCm() );
         assertEquals( soliflore.largeur()  ,2*Math.sqrt(1*1000/(PI*10))  , soliflore.precisionEnCm() );
         assertEquals( soliflore.hauteurCourante(), 10 ,soliflore.precisionEnCm() );


         //cas classique
         // construit un bidon plein
         assertTrue(   baril.est_plein() );
         assertFalse ( baril.est_vide()  );
         assertEquals( baril.hauteur() , baril.hauteurCourante() , baril.precisionEnCm() );
         assertEquals( baril.volumeMax() , baril.volumeCourant() , baril.precisionEnCm3()/1000 );


         // de hauteur volume et volume courant fixé
         assertEquals( baril.hauteur()          , 100  , PRECISION_TEST);
         assertEquals( baril.hauteur()          , 100  , baril.precisionEnCm() );
         assertEquals( baril.volumeMax        (), 543  , baril.precisionEnCm3()/1000 );
         assertEquals( baril.volumeMaxEnCm3()   , 543*1000 , baril.precisionEnCm3() );
         assertEquals( baril.volumeCourant()    , 543  , baril.precisionEnCm3() );


         //de rayon, hauteur courante et largeur à calculer
         //r= racineCarre (v/hPI)
         assertEquals( baril.rayon()    , Math.sqrt(543*1000/(3.14*100))  , baril.precisionEnCm() );
         assertEquals( baril.largeur()  , 2*Math.sqrt(543*1000/(3.14*100))  , baril.precisionEnCm() );
         assertEquals( baril.hauteurCourante()  ,100                       , baril.precisionEnCm() );


         //cas classique
         //petit recipient presque plein
         assertFalse(  becher.est_plein() );
         assertFalse ( becher.est_vide()  );

         // de hauteur volume et volume courant fixé
         assertEquals( becher.hauteur()          , 15  , PRECISION_TEST);
         assertEquals( becher.hauteur()          , 15  , becher.precisionEnCm() );
         assertEquals( becher.volumeMax()        , 0.5 , becher.precisionEnCm3()/1000 );
         assertEquals( becher.volumeMaxEnCm3()   , 500 , becher.precisionEnCm3() );
         assertEquals( becher.volumeCourant()    , 0.4 , becher.precisionEnCm3() );


         //de rayon , hauteur courante et largeur à calculer
         assertEquals( becher.rayon()    , Math.sqrt(0.5*1000/(PI*15))    , becher.precisionEnCm() );
         assertEquals( becher.largeur()  , 2*Math.sqrt(0.5*1000/(PI*15))  , becher.precisionEnCm() );
         assertEquals( becher.hauteurCourante()  , 0.4*1000/(0.5*1000/15)   , becher.precisionEnCm() );


         //cas classique
          cristalisoir = new Bidon(10, 20, 10  );  // petit recipient presque vide
         //petit recipient presque vide
         //assertFalse(  fiole.est_plein() );
         assertFalse ( cristalisoir.est_vide()  );

         // de hauteur volume et volume courant fixé
         assertEquals(      10, cristalisoir.hauteur()          ,
PRECISION_TEST);
         assertEquals(      10, cristalisoir.hauteur()          ,
cristalisoir.precisionEnCm() );
         assertEquals(      20, cristalisoir.volumeMax()        ,
cristalisoir.precisionEnCm3()/1000 );
         assertEquals( 20*1000, cristalisoir.volumeMaxEnCm3()   ,
cristalisoir.precisionEnCm3() );
         assertEquals( 10, cristalisoir.volumeCourant()         ,
cristalisoir.precisionEnCm3() );


         //de rayon , hauteur courante et largeur à calculer
         assertEquals(    Math.sqrt(20*1000/(PI*10)) ,
cristalisoir.rayon()            , cristalisoir.precisionEnCm() );
         assertEquals(  2*Math.sqrt(20*1000/(PI*10)) ,
cristalisoir.largeur()          , cristalisoir.precisionEnCm() );
         assertEquals(            10*1000/(20*1000/10) ,
cristalisoir.hauteurCourante()  , cristalisoir.precisionEnCm() );

     }



// DEFINIR LE TEST DES INVARIANTS

     private void invariants (Bidon b) {
         assertEquals( b.largeur()       , 2*b.rayon(), b.precisionEnCm());
         assertEquals( b.largeur()       , 2*b.rayon(), PRECISION_TEST);
         assertEquals( b.volumeMaxEnCm3()     ,1000*b.volumeMax(), PRECISION_TEST );
         assertEquals( b.volumeCourant() ,b.hauteurCourante()*PI*b.rayon()*b.rayon()/1000 , b.precisionEnCm3()/1000);
         assertEquals( b.volumeMaxEnCm3()     ,b.hauteur()*PI*b.rayon()*b.rayon() , b.precisionEnCm3());
     }

     @Test
     void testInvariants() {
         for (Bidon existant: bidons){
             invariants(existant);
             //Non il ne faut pas faire d'affichage dans un test mais ceci
             //est  juste pour montrer aux étudiants le nombre d'objets crées
             //System.out.println("verification des invariants de "+existant);
         }
//System.out.println("-----------------------------------------------------------------------------------");
     }


// TESTER LES MODIFICATEURS


     /*  AJOUTER
      *  tente d'ajouter volume litres de liquide et retourne la
      *  valeur effectivement ajoutée en litres.
      *  Le cas d'ajout d'un quantité négative est résolu par le bidon inchangé.
     */
     @Test
     void testAjouterQuantitePossible() {
         assertEquals(5, cristalisoir.ajouter(5) , cristalisoir.precisionEnCm3()/1000 );
         assertEquals(5, silo.ajouter(5)  , silo.precisionEnCm3()/1000 );
         testInvariants() ;
     }

     @Test
     void testAjouterQuantiteTropPetite() {
         assertEquals(0, cristalisoir.ajouter(-5) ,
cristalisoir.precisionEnCm3()/1000 );
         assertEquals(0, silo.ajouter(-5)  , silo.precisionEnCm3() );
         testInvariants() ;
     }

     @Test
     void testAjouterQuantiteTropGrande() {
         assertEquals(10, cristalisoir.ajouter(12) , cristalisoir.precisionEnCm3()/1000 );
         //Oui je sais, c'est tentant mais il ne faut pas le faire car les erreurs peuvent venir de VolumeMax
         //assertEquals(silo.volumeMax(), silo.ajouter(silo.volumeMax()+3) , silo.precisionEnCm3() );
         //mieux vaut faire ceci
         assertEquals(1570800, silo.ajouter(2000000), silo.precisionEnCm3()/1000 );
         testInvariants() ;
     }

     /*  Ajoute1LitreSiPossible
      *  ajoute 1 litre si possible et renvoie vrai si le litre a été ajouté
      * sinon fait rien et renvoie faux.
      *
      */

     @Test
     void testAjouter1LitreSiPossibleCasPossible() {
         double initialBaril = silo.volumeCourant();
         assertTrue(silo.ajouter1LitreSiPossible());
assertEquals(initialBaril+1,silo.volumeCourant(),silo.precisionEnCm3()/1000);
         testInvariants() ;
     }
     @Test
     void testAjouter1LitreSiPossibleCasImpossible() {
         double initialVerre = becher.volumeCourant();
         assertFalse(becher.ajouter1LitreSiPossible());
         assertEquals(initialVerre, becher.volumeCourant(),
becher.precisionEnCm3()/1000);
         testInvariants() ;
     }


     /* tente d'ajouter nombreCm de hauteur de liquide et retourne
      * la valeur effectivement ajoutée.
     */
     @Test
     void testAjouterHauteurToutAjouter() {
         assertEquals( 0, vase.hauteurCourante() , vase.precisionEnCm());
         assertEquals(5, vase.ajouterHauteur(5), vase.precisionEnCm());
         assertEquals(5, vase.hauteurCourante() , vase.precisionEnCm());
         testInvariants() ;
     }
     @Test
     void testAjouterHauteurAjouterUnPeu() {
         assertEquals( 0, vase.hauteurCourante() , vase.precisionEnCm());
         assertEquals(10, vase.ajouterHauteur(30), vase.precisionEnCm());
         assertEquals(10, vase.hauteurCourante() , vase.precisionEnCm());
         testInvariants() ;
     }
     @Test
     void testAjouterHauteurNeRienAjouter() {
         assertEquals(0, baril.ajouterHauteur(30000000),
baril.precisionEnCm());
         testInvariants() ;
     }

     /* ajoute 1 M3 si possible et renvoie vrai si le m3 a été ajouté en entier
      * sinon ne rien faire et renvoyer faux.
      *
      */
     @Test
     void testAjouterM3SiPossibleCasPossible() {
         double niveau = silo.volumeCourant();
         assertTrue(silo.ajouterM3SiPossible());
         assertEquals(niveau+1000, silo.volumeCourant(), silo.precisionEnCm3()/1000);
         testInvariants() ;
     }
     @Test
     void testAjouterM3SiPossibleCasImpossible() {
         double niveau = soliflore.volumeCourant();
         assertFalse(soliflore.ajouterM3SiPossible());
         assertEquals(niveau, soliflore.volumeCourant(),
soliflore.precisionEnCm3()/1000);
         testInvariants() ;
     }

     /* change la précision des calculs
     */
     @Test
     void testChangePrecision() {
         double nouvellePrecision = 0.0000000000000000000000000000000000000000000000000000000000000000001;
         baril.changePrecision(nouvellePrecision);
         assertEquals(nouvellePrecision           , baril.precisionEnCm3() , nouvellePrecision);
         assertEquals(Math.cbrt(nouvellePrecision), baril.precisionEnCm()  , nouvellePrecision);
         testInvariants() ;
     }

     /*diminue la hauteur de liquide et renvoie la hauteur de Liquide
qui a effectivement été retirée du bidon
      * Si la hauteur est négative cela considère qu'on veut retirer la
valeur absolue de celle çi
      * @param hauteurEnCm la hauteur de liquide qu'on veut retirer
      * @return la hauteur effectivement retirée
      */

     @Test
     void testDiminuerHauteurToutRetirer(){
         assertEquals(1,becher.diminuerHauteur(1), becher.precisionEnCm() );
         testInvariants() ;
     }
     @Test
     void testDiminuerHauteurRetirerUnPeu(){
         assertEquals(12,becher.diminuerHauteur(13), becher.precisionEnCm() );
         testInvariants() ;
     }
     @Test
     void testDiminuerHauteurNeRienRetirer(){ assertEquals(0,vase.diminuerHauteur(-6),vase.precisionEnCm());
         testInvariants() ;
     }

     /**
      * remplir à précision près
      */
     @Test
         void testRemplirDejaPlein() {
         baril.remplir();
         assertTrue(baril.est_plein());
         testInvariants() ;
}

     @Test
     void testRemplir() {
         soliflore.remplir();
         assertTrue(soliflore.est_plein());
         testInvariants() ;
     }

     /*
      * retirer l'ensemble de liquide du bidon
      */
     @Test
     void testVider() {
         soliflore.vider();
         assertTrue(soliflore.est_vide());
         testInvariants() ;
     }


     @Test
     void testRetirer() {
         assertEquals(543,baril.retirer(-555), baril.precisionEnCm3()/1000 );
         testInvariants() ;
     }

     /*
      * verser doucement le contenu du bidon dans le recipient de destination
      * et renvoie le volume du liquide effectivement retiré du bidon
      */
     @Test
     void testVerser() {
         assertEquals(0, vase.verser(becher), Math.max(becher.precisionEnCm3()/1000, vase.precisionEnCm3()/100) );
         testInvariants() ;
     }

     /*
      * tenter de retirer hauteurEnCm de liquide du bidon et
      * renvoie le volume de liquide effectivement transvaser.
      */
     @Test
     void testTransvaser() {
         assertEquals(0.4, becher.transvaser(3, cristalisoir), becher.precisionEnCm3()/1000);
         testInvariants() ;
     }
     @Test
     void testTransvaserImpossible() {
         assertEquals(0, becher.transvaser(3, baril), becher.precisionEnCm3()/1000);
         testInvariants() ;
     }


}