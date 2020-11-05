DROP TABLE IF EXISTS UTILISATEUR;

DROP TABLE IF EXISTS ATTRIBUT_MONSTRE;

DROP TABLE IF EXISTS TYPE_MONSTRE;

DROP TABLE IF EXISTS MAGIE;

DROP TABLE IF EXISTS MONSTRE;

DROP TABLE IF EXISTS TYPE_MAGIE;

DROP TABLE IF EXISTS EFFET;

DROP TABLE IF EXISTS EFFET_PIEGE;

DROP TABLE IF EXISTS MECANIQUE;

DROP TABLE IF EXISTS CARTE;

DROP TABLE IF EXISTS ATTRIBUT_CARTE;

DROP TABLE IF EXISTS DECK;

DROP TABLE IF EXISTS PIEGE;

DROP TABLE IF EXISTS EFFETS_CARTE;

DROP TABLE IF EXISTS EFFETS_MECANIQUE;

DROP TABLE IF EXISTS INCLUS;

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEUR
 (
   USER CHAR(32) NOT NULL  ,
   MDP VARCHAR(128) NULL
   , PRIMARY KEY (USER)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ATTRIBUT_MONSTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ATTRIBUT_MONSTRE
 (
   CODE_ATTR CHAR(32) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_ATTR CHAR(32) NULL
   , PRIMARY KEY (CODE_ATTR)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ATTRIBUT_MONSTRE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ATTRIBUT_MONSTRE_MONSTRE
     ON ATTRIBUT_MONSTRE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : TYPE_MONSTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_MONSTRE
 (
   CODE_TYPE_MONSTRE VARCHAR(30) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_TYPE_MONSTRE VARCHAR(30) NULL
   , PRIMARY KEY (CODE_TYPE_MONSTRE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TYPE_MONSTRE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TYPE_MONSTRE_MONSTRE
     ON TYPE_MONSTRE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : MAGIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MAGIE
 (
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_TYPE_MAGIE VARCHAR(15) NULL  ,
   NOM VARCHAR(100) NULL  ,
   DESCRIPTION TEXT NULL  ,
   ATTRIBUT VARCHAR(15) NULL
   , PRIMARY KEY (NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : MONSTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MONSTRE
 (
   NO_CARTE BIGINT(12) NOT NULL  ,
   CATEGORIE_MONSTRE VARCHAR(30) NULL  ,
   ATTRIBUT_MONSTRE VARCHAR(15) NULL  ,
   NBRE_ETOILE SMALLINT(2) NULL  ,
   EST_EFFET BOOL NULL  ,
   NOM VARCHAR(100) NULL  ,
   DESCRIPTION TEXT NULL  ,
   ATTRIBUT VARCHAR(15) NULL
   , PRIMARY KEY (NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TYPE_MAGIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_MAGIE
 (
   CODE_TYPE_MAGIE VARCHAR(15) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_TYPE_MAG VARCHAR(15) NULL
   , PRIMARY KEY (CODE_TYPE_MAGIE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TYPE_MAGIE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TYPE_MAGIE_MAGIE
     ON TYPE_MAGIE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : EFFET
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EFFET
 (
   CODE_EFFET VARCHAR(12) NOT NULL  ,
   NOM_EFFET VARCHAR(30) NULL
   , PRIMARY KEY (CODE_EFFET)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : EFFET_PIEGE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EFFET_PIEGE
 (
   CODE_EFFET_PIEGE CHAR(32) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_EFFET_PIEGE CHAR(32) NULL
   , PRIMARY KEY (CODE_EFFET_PIEGE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE EFFET_PIEGE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_EFFET_PIEGE_PIEGE
     ON EFFET_PIEGE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : MECANIQUE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MECANIQUE
 (
   CODE_MECA VARCHAR(12) NOT NULL  ,
   NOM_MECA VARCHAR(30) NULL  ,
   RATIO_MONSTRE DECIMAL(2,2) NULL  ,
   RATIO_MAGIE DECIMAL(2,2) NULL  ,
   RATIO_PIEGE DECIMAL(2,2) NULL
   , PRIMARY KEY (CODE_MECA)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CARTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CARTE
 (
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM VARCHAR(100) NULL  ,
   DESCRIPTION TEXT NULL  ,
   ATTRIBUT VARCHAR(15) NULL
   , PRIMARY KEY (NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ATTRIBUT_CARTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ATTRIBUT_CARTE
 (
   CODE_ATTR VARCHAR(12) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_ATTR VARCHAR(15) NULL
   , PRIMARY KEY (CODE_ATTR)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ATTRIBUT_CARTE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ATTRIBUT_CARTE_CARTE
     ON ATTRIBUT_CARTE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : DECK
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DECK
 (
   NO_DECK INTEGER(5) NOT NULL  ,
   USER CHAR(32) NOT NULL  ,
   NOM_USER VARCHAR(30) NULL  ,
   NOM VARCHAR(30) NULL
   , PRIMARY KEY (NO_DECK)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE DECK
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_DECK_UTILISATEUR
     ON DECK (USER ASC);

# -----------------------------------------------------------------------------
#       TABLE : PIEGE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PIEGE
 (
   NO_CARTE BIGINT(12) NOT NULL  ,
   NOM_TYPE_PIEGE VARCHAR(30) NULL  ,
   NOM VARCHAR(100) NULL  ,
   DESCRIPTION TEXT NULL  ,
   ATTRIBUT VARCHAR(15) NULL
   , PRIMARY KEY (NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : EFFETS_CARTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EFFETS_CARTE
 (
   CODE_EFFET VARCHAR(12) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL
   , PRIMARY KEY (CODE_EFFET,NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE EFFETS_CARTE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_EFFETS_CARTE_EFFET
     ON EFFETS_CARTE (CODE_EFFET ASC);

CREATE  INDEX I_FK_EFFETS_CARTE_CARTE
     ON EFFETS_CARTE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : EFFETS_MECANIQUE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EFFETS_MECANIQUE
 (
   CODE_EFFET VARCHAR(12) NOT NULL  ,
   CODE_MECA VARCHAR(12) NOT NULL
   , PRIMARY KEY (CODE_EFFET,CODE_MECA)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE EFFETS_MECANIQUE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_EFFETS_MECANIQUE_EFFET
     ON EFFETS_MECANIQUE (CODE_EFFET ASC);

CREATE  INDEX I_FK_EFFETS_MECANIQUE_MECANIQUE
     ON EFFETS_MECANIQUE (CODE_MECA ASC);

# -----------------------------------------------------------------------------
#       TABLE : INCLUS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS INCLUS
 (
   NO_DECK INTEGER(5) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL
   , PRIMARY KEY (NO_DECK,NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE INCLUS
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_INCLUS_DECK
     ON INCLUS (NO_DECK ASC);

CREATE  INDEX I_FK_INCLUS_CARTE
     ON INCLUS (NO_CARTE ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE ATTRIBUT_MONSTRE
  ADD FOREIGN KEY FK_ATTRIBUT_MONSTRE_MONSTRE (NO_CARTE)
      REFERENCES MONSTRE (NO_CARTE) ;


ALTER TABLE TYPE_MONSTRE
  ADD FOREIGN KEY FK_TYPE_MONSTRE_MONSTRE (NO_CARTE)
      REFERENCES MONSTRE (NO_CARTE) ;


ALTER TABLE MAGIE
  ADD FOREIGN KEY FK_MAGIE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE MONSTRE
  ADD FOREIGN KEY FK_MONSTRE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE TYPE_MAGIE
  ADD FOREIGN KEY FK_TYPE_MAGIE_MAGIE (NO_CARTE)
      REFERENCES MAGIE (NO_CARTE) ;


ALTER TABLE EFFET_PIEGE
  ADD FOREIGN KEY FK_EFFET_PIEGE_PIEGE (NO_CARTE)
      REFERENCES PIEGE (NO_CARTE) ;


ALTER TABLE ATTRIBUT_CARTE
  ADD FOREIGN KEY FK_ATTRIBUT_CARTE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE DECK
  ADD FOREIGN KEY FK_DECK_UTILISATEUR (USER)
      REFERENCES UTILISATEUR (USER) ;


ALTER TABLE PIEGE
  ADD FOREIGN KEY FK_PIEGE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE EFFETS_CARTE
  ADD FOREIGN KEY FK_EFFETS_CARTE_EFFET (CODE_EFFET)
      REFERENCES EFFET (CODE_EFFET) ;


ALTER TABLE EFFETS_CARTE
  ADD FOREIGN KEY FK_EFFETS_CARTE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE EFFETS_MECANIQUE
  ADD FOREIGN KEY FK_EFFETS_MECANIQUE_EFFET (CODE_EFFET)
      REFERENCES EFFET (CODE_EFFET) ;


ALTER TABLE EFFETS_MECANIQUE
  ADD FOREIGN KEY FK_EFFETS_MECANIQUE_MECANIQUE (CODE_MECA)
      REFERENCES MECANIQUE (CODE_MECA) ;


ALTER TABLE INCLUS
  ADD FOREIGN KEY FK_INCLUS_DECK (NO_DECK)
      REFERENCES DECK (NO_DECK) ;


ALTER TABLE INCLUS
  ADD FOREIGN KEY FK_INCLUS_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;
