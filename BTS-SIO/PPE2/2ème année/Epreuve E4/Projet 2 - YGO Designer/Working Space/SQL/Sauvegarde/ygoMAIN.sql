DROP DATABASE IF EXISTS ygo;

CREATE DATABASE IF NOT EXISTS ygo;
USE ygo;
# -----------------------------------------------------------------------------
#       TABLE : ETOILE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ETOILE
 (
   NBR_ETOILE SMALLINT NOT NULL
   , PRIMARY KEY (NBR_ETOILE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEUR
 (
   USER CHAR(32) NOT NULL  ,
   CD_TYPE CHAR(32) NOT NULL  ,
   MDP VARCHAR(128) NULL
   , PRIMARY KEY (USER)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE UTILISATEUR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_UTILISATEUR_TYPE_USER
     ON UTILISATEUR (CD_TYPE ASC);

# -----------------------------------------------------------------------------
#       TABLE : STRATEGIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS STRATEGIE
 (
   CODE_STRAT VARCHAR(12) NOT NULL  ,
   NOM_STRAT VARCHAR(30) NULL  ,
   RATIO_MONSTRE_STRAT DECIMAL(2,2) NULL  ,
   RATIO_MAGIE_STRAT DECIMAL(2,2) NULL  ,
   RATIO_PIEGE_STRAT DECIMAL(2,2) NULL
   , PRIMARY KEY (CODE_STRAT)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ATTRIBUT_MONSTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ATTRIBUT_MONSTRE
 (
   CODE_ATTR_MO CHAR(32) NOT NULL  ,
   NOM_ATTR_MO CHAR(32) NULL
   , PRIMARY KEY (CODE_ATTR_MO)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TYPE_MONSTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_MONSTRE
 (
   CODE_TYPE_MONSTRE VARCHAR(30) NOT NULL  ,
   NOM_TYPE_MONSTRE VARCHAR(30) NULL
   , PRIMARY KEY (CODE_TYPE_MONSTRE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TYPE_PIEGE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_PIEGE
 (
   CODE_TYPE_PIEGE CHAR(32) NOT NULL  ,
   NOM_TYPE_PIEGE CHAR(32) NULL
   , PRIMARY KEY (CODE_TYPE_PIEGE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TYPE_MAGIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_MAGIE
 (
   CODE_TYPE_MAGIE VARCHAR(15) NOT NULL  ,
   NOM_TYPE_MAGIE VARCHAR(15) NULL
   , PRIMARY KEY (CODE_TYPE_MAGIE)
 )
 comment = "";

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
#       TABLE : CARTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CARTE
 (
   NO_CARTE BIGINT(12) NOT NULL  ,
   CODE_ATTR_CARTE VARCHAR(12) NOT NULL  ,
   NOM VARCHAR(100) NULL  ,
   DESCRIPTION TEXT NULL
   , PRIMARY KEY (NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CARTE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CARTE_ATTRIBUT_CARTE
     ON CARTE (CODE_ATTR_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : ATTRIBUT_CARTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ATTRIBUT_CARTE
 (
   CODE_ATTR_CARTE VARCHAR(12) NOT NULL  ,
   NOM_ATTR_CARTE VARCHAR(15) NULL
   , PRIMARY KEY (CODE_ATTR_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TYPE_USER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_USER
 (
   CD_TYPE CHAR(32) NOT NULL  ,
   NOM_TYPE CHAR(32) NULL
   , PRIMARY KEY (CD_TYPE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : DECK
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DECK
 (
   NO_DECK INTEGER NOT NULL  ,
   USER CHAR(32) NOT NULL  ,
   NOM_DECK VARCHAR(30) NULL
   , PRIMARY KEY (NO_DECK)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE DECK
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_DECK_UTILISATEUR
     ON DECK (USER ASC);

# -----------------------------------------------------------------------------
#       TABLE : C_MAGIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS C_MAGIE
 (
   CODE_TYPE_MAGIE VARCHAR(15) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL
   , PRIMARY KEY (CODE_TYPE_MAGIE,NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE C_MAGIE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_C_MAGIE_TYPE_MAGIE
     ON C_MAGIE (CODE_TYPE_MAGIE ASC);

CREATE  INDEX I_FK_C_MAGIE_CARTE
     ON C_MAGIE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : EFFET_MECA
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EFFET_MECA
 (
   CODE_EFFET VARCHAR(12) NOT NULL  ,
   CODE_STRAT VARCHAR(12) NOT NULL
   , PRIMARY KEY (CODE_EFFET,CODE_STRAT)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE EFFET_MECA
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_EFFET_MECA_EFFET
     ON EFFET_MECA (CODE_EFFET ASC);

CREATE  INDEX I_FK_EFFET_MECA_STRATEGIE
     ON EFFET_MECA (CODE_STRAT ASC);

# -----------------------------------------------------------------------------
#       TABLE : EFFET_CARTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EFFET_CARTE
 (
   CODE_EFFET VARCHAR(12) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL
   , PRIMARY KEY (CODE_EFFET,NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE EFFET_CARTE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_EFFET_CARTE_EFFET
     ON EFFET_CARTE (CODE_EFFET ASC);

CREATE  INDEX I_FK_EFFET_CARTE_CARTE
     ON EFFET_CARTE (NO_CARTE ASC);

# -----------------------------------------------------------------------------
#       TABLE : C_MONSTRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS C_MONSTRE
 (
   CODE_TYPE_MONSTRE VARCHAR(30) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL  ,
   CODE_ATTR_MO CHAR(32) NOT NULL  ,
   NBR_ETOILE SMALLINT NOT NULL
   , PRIMARY KEY (CODE_TYPE_MONSTRE,NO_CARTE,CODE_ATTR_MO,NBR_ETOILE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE C_MONSTRE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_C_MONSTRE_TYPE_MONSTRE
     ON C_MONSTRE (CODE_TYPE_MONSTRE ASC);

CREATE  INDEX I_FK_C_MONSTRE_CARTE
     ON C_MONSTRE (NO_CARTE ASC);

CREATE  INDEX I_FK_C_MONSTRE_ATTRIBUT_MONSTRE
     ON C_MONSTRE (CODE_ATTR_MO ASC);

CREATE  INDEX I_FK_C_MONSTRE_ETOILE
     ON C_MONSTRE (NBR_ETOILE ASC);

# -----------------------------------------------------------------------------
#       TABLE : INCLUS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS INCLUS
 (
   NO_DECK INTEGER NOT NULL  ,
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
#       TABLE : C_PIEGE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS C_PIEGE
 (
   CODE_TYPE_PIEGE CHAR(32) NOT NULL  ,
   NO_CARTE BIGINT(12) NOT NULL
   , PRIMARY KEY (CODE_TYPE_PIEGE,NO_CARTE)
 )
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE C_PIEGE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_C_PIEGE_TYPE_PIEGE
     ON C_PIEGE (CODE_TYPE_PIEGE ASC);

CREATE  INDEX I_FK_C_PIEGE_CARTE
     ON C_PIEGE (NO_CARTE ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE UTILISATEUR
  ADD FOREIGN KEY FK_UTILISATEUR_TYPE_USER (CD_TYPE)
      REFERENCES TYPE_USER (CD_TYPE) ;


ALTER TABLE CARTE
  ADD FOREIGN KEY FK_CARTE_ATTRIBUT_CARTE (CODE_ATTR_CARTE)
      REFERENCES ATTRIBUT_CARTE (CODE_ATTR_CARTE) ;


ALTER TABLE DECK
  ADD FOREIGN KEY FK_DECK_UTILISATEUR (USER)
      REFERENCES UTILISATEUR (USER) ;


ALTER TABLE C_MAGIE
  ADD FOREIGN KEY FK_C_MAGIE_TYPE_MAGIE (CODE_TYPE_MAGIE)
      REFERENCES TYPE_MAGIE (CODE_TYPE_MAGIE) ;


ALTER TABLE C_MAGIE
  ADD FOREIGN KEY FK_C_MAGIE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE EFFET_MECA
  ADD FOREIGN KEY FK_EFFET_MECA_EFFET (CODE_EFFET)
      REFERENCES EFFET (CODE_EFFET) ;


ALTER TABLE EFFET_MECA
  ADD FOREIGN KEY FK_EFFET_MECA_STRATEGIE (CODE_STRAT)
      REFERENCES STRATEGIE (CODE_STRAT) ;


ALTER TABLE EFFET_CARTE
  ADD FOREIGN KEY FK_EFFET_CARTE_EFFET (CODE_EFFET)
      REFERENCES EFFET (CODE_EFFET) ;


ALTER TABLE EFFET_CARTE
  ADD FOREIGN KEY FK_EFFET_CARTE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE C_MONSTRE
  ADD FOREIGN KEY FK_C_MONSTRE_TYPE_MONSTRE (CODE_TYPE_MONSTRE)
      REFERENCES TYPE_MONSTRE (CODE_TYPE_MONSTRE) ;


ALTER TABLE C_MONSTRE
  ADD FOREIGN KEY FK_C_MONSTRE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE C_MONSTRE
  ADD FOREIGN KEY FK_C_MONSTRE_ATTRIBUT_MONSTRE (CODE_ATTR_MO)
      REFERENCES ATTRIBUT_MONSTRE (CODE_ATTR_MO) ;


ALTER TABLE C_MONSTRE
  ADD FOREIGN KEY FK_C_MONSTRE_ETOILE (NBR_ETOILE)
      REFERENCES ETOILE (NBR_ETOILE) ;


ALTER TABLE INCLUS
  ADD FOREIGN KEY FK_INCLUS_DECK (NO_DECK)
      REFERENCES DECK (NO_DECK) ;


ALTER TABLE INCLUS
  ADD FOREIGN KEY FK_INCLUS_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;


ALTER TABLE C_PIEGE
  ADD FOREIGN KEY FK_C_PIEGE_TYPE_PIEGE (CODE_TYPE_PIEGE)
      REFERENCES TYPE_PIEGE (CODE_TYPE_PIEGE) ;


ALTER TABLE C_PIEGE
  ADD FOREIGN KEY FK_C_PIEGE_CARTE (NO_CARTE)
      REFERENCES CARTE (NO_CARTE) ;




INSERT INTO `attribut_carte` (`CODE_ATTR_CARTE`, `NOM_ATTR_CARTE`) VALUES
('MAG', 'Magie'),
('MON', 'Monstre'),
('PIE', 'Piège');

INSERT INTO `attribut_monstre` (`CODE_ATTR_MO`, `NOM_ATTR_MO`) VALUES
('BDV', 'Bête Divine'),
('EAU', 'Eau'),
('FEU', 'Feu'),
('LUM', 'Lumière'),
('TEN', 'Ténèbres'),
('TER', 'Terre'),
('VEN', 'Vent');

INSERT INTO `etoile` (`NBR_ETOILE`) VALUES
(0),
(1),
(2),
(3),
(4),
(5),
(6),
(8),
(9),
(10),
(11),
(12);


INSERT INTO `type_magie` (`CODE_TYPE_MAGIE`, `NOM_TYPE_MAGIE`) VALUES
('CTN', 'Continue'),
('EQP', 'Equipement'),
('JR', 'Jeu rapide'),
('NOR', 'Normale'),
('RIT', 'Rituelle'),
('TER', 'Terrain');

INSERT INTO `type_monstre` (`CODE_TYPE_MONSTRE`, `NOM_TYPE_MONSTRE`) VALUES
('AQU', 'Aqua'),
('BTA', 'Bête-Ailée'),
('BTD', 'Bête Divine'),
('BTE', 'Bête'),
('BTG', 'Bête-Guerrier'),
('CYB', 'Cyberse'),
('DEM', 'Démon'),
('DIN', 'Dinosaure'),
('DRA', 'Dragon'),
('ELF', 'Elfe'),
('GUE', 'Guerrier'),
('INS', 'Insect'),
('MAC', 'Machine'),
('MAG', 'Magicien'),
('PLA', 'Plante'),
('POI', 'Poisson'),
('PSY', 'Psychique'),
('PYR', 'Pyro'),
('REP', 'Reptile'),
('ROC', 'Rocher'),
('SPM', 'Serpent de mer'),
('TNR', 'Tonnerre'),
('WYR', 'Wyrm'),
('ZOM', 'Zombie');

INSERT INTO `type_piege` (`CODE_TYPE_PIEGE`, `NOM_TYPE_PIEGE`) VALUES
('CP', 'Contre-piège'),
('CTN', 'Continu'),
('NOR', 'Normal');
