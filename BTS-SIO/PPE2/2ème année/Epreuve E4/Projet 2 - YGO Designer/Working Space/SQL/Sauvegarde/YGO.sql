-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 05 nov. 2020 à 22:03
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `ygo`
--
CREATE DATABASE IF NOT EXISTS `ygo` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `ygo`;

-- --------------------------------------------------------

--
-- Structure de la table `attribut_carte`
--

DROP TABLE IF EXISTS `attribut_carte`;
CREATE TABLE IF NOT EXISTS `attribut_carte` (
  `CODE_ATTR_CARTE` varchar(12) NOT NULL,
  `NOM_ATTR_CARTE` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CODE_ATTR_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `attribut_monstre`
--

DROP TABLE IF EXISTS `attribut_monstre`;
CREATE TABLE IF NOT EXISTS `attribut_monstre` (
  `CODE_ATTR_MO` char(32) NOT NULL,
  `NOM_ATTR_MO` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_ATTR_MO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `carte`
--

DROP TABLE IF EXISTS `carte`;
CREATE TABLE IF NOT EXISTS `carte` (
  `NO_CARTE` bigint(12) NOT NULL,
  `CODE_TYPE_PIEGE` char(32) NOT NULL,
  `CODE_TYPE_MAGIE` varchar(15) NOT NULL,
  `CODE_ATTR_CARTE` varchar(12) NOT NULL,
  `CODE_ATTR_MO` char(32) NOT NULL,
  `CODE_TYPE_MONSTRE_HER` varchar(30) NOT NULL,
  `NOM` varchar(100) DEFAULT NULL,
  `DESCRIPTION` text,
  `TYPE_CARTE` char(2) DEFAULT NULL,
  `CODE_TYPE_MONSTRE` varchar(30) DEFAULT NULL,
  `NBRE_ETOILE` smallint(2) DEFAULT NULL,
  `EST_EFFET` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`NO_CARTE`),
  KEY `FK_CARTE_TYPE_PIEGE` (`CODE_TYPE_PIEGE`),
  KEY `FK_CARTE_TYPE_MAGIE` (`CODE_TYPE_MAGIE`),
  KEY `FK_CARTE_ATTRIBUT_CARTE` (`CODE_ATTR_CARTE`),
  KEY `FK_CARTE_ATTRIBUT_MONSTRE` (`CODE_ATTR_MO`),
  KEY `FK_MONSTRE_TYPE_MONSTRE_2` (`CODE_TYPE_MONSTRE_HER`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `deck`
--

DROP TABLE IF EXISTS `deck`;
CREATE TABLE IF NOT EXISTS `deck` (
  `NO_DECK` int(5) NOT NULL,
  `USER` char(32) NOT NULL,
  `NOM_DECK` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`NO_DECK`),
  KEY `FK_DECK_UTILISATEUR` (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `effet`
--

DROP TABLE IF EXISTS `effet`;
CREATE TABLE IF NOT EXISTS `effet` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `NOM_EFFET` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`CODE_EFFET`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `effet_carte`
--

DROP TABLE IF EXISTS `effet_carte`;
CREATE TABLE IF NOT EXISTS `effet_carte` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `NO_CARTE` bigint(12) NOT NULL,
  PRIMARY KEY (`CODE_EFFET`,`NO_CARTE`),
  KEY `FK_EFFET_CARTE_CARTE` (`NO_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `effet_meca`
--

DROP TABLE IF EXISTS `effet_meca`;
CREATE TABLE IF NOT EXISTS `effet_meca` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `CODE_STRAT` varchar(12) NOT NULL,
  PRIMARY KEY (`CODE_EFFET`,`CODE_STRAT`),
  KEY `FK_EFFET_MECA_STRATEGIE` (`CODE_STRAT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `inclus`
--

DROP TABLE IF EXISTS `inclus`;
CREATE TABLE IF NOT EXISTS `inclus` (
  `NO_DECK` int(5) NOT NULL,
  `NO_CARTE` bigint(12) NOT NULL,
  PRIMARY KEY (`NO_DECK`,`NO_CARTE`),
  KEY `FK_INCLUS_CARTE` (`NO_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `strategie`
--

DROP TABLE IF EXISTS `strategie`;
CREATE TABLE IF NOT EXISTS `strategie` (
  `CODE_STRAT` varchar(12) NOT NULL,
  `NOM_STRAT` varchar(30) DEFAULT NULL,
  `RATIO_MONSTRE_STRAT` decimal(2,2) DEFAULT NULL,
  `RATIO_MAGIE_STRAT` decimal(2,2) DEFAULT NULL,
  `RATIO_PIEGE_STRAT` decimal(2,2) DEFAULT NULL,
  PRIMARY KEY (`CODE_STRAT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `type_magie`
--

DROP TABLE IF EXISTS `type_magie`;
CREATE TABLE IF NOT EXISTS `type_magie` (
  `CODE_TYPE_MAGIE` varchar(15) NOT NULL,
  `NOM_TYPE_MAGIE` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CODE_TYPE_MAGIE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `type_monstre`
--

DROP TABLE IF EXISTS `type_monstre`;
CREATE TABLE IF NOT EXISTS `type_monstre` (
  `CODE_TYPE_MONSTRE` varchar(30) NOT NULL,
  `NOM_TYPE_MONSTRE` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`CODE_TYPE_MONSTRE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `type_piege`
--

DROP TABLE IF EXISTS `type_piege`;
CREATE TABLE IF NOT EXISTS `type_piege` (
  `CODE_TYPE_PIEGE` char(32) NOT NULL,
  `NOM_TYPE_PIEGE` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_TYPE_PIEGE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `USER` char(32) NOT NULL,
  `MDP` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `carte`
--
ALTER TABLE `carte`
  ADD CONSTRAINT `carte_ibfk_1` FOREIGN KEY (`CODE_TYPE_PIEGE`) REFERENCES `type_piege` (`CODE_TYPE_PIEGE`),
  ADD CONSTRAINT `carte_ibfk_10` FOREIGN KEY (`CODE_TYPE_MONSTRE_HER`) REFERENCES `type_monstre` (`CODE_TYPE_MONSTRE`),
  ADD CONSTRAINT `carte_ibfk_11` FOREIGN KEY (`CODE_TYPE_PIEGE`) REFERENCES `type_piege` (`CODE_TYPE_PIEGE`),
  ADD CONSTRAINT `carte_ibfk_12` FOREIGN KEY (`CODE_TYPE_MAGIE`) REFERENCES `type_magie` (`CODE_TYPE_MAGIE`),
  ADD CONSTRAINT `carte_ibfk_13` FOREIGN KEY (`CODE_ATTR_CARTE`) REFERENCES `attribut_carte` (`CODE_ATTR_CARTE`),
  ADD CONSTRAINT `carte_ibfk_14` FOREIGN KEY (`CODE_ATTR_MO`) REFERENCES `attribut_monstre` (`CODE_ATTR_MO`),
  ADD CONSTRAINT `carte_ibfk_15` FOREIGN KEY (`CODE_TYPE_MONSTRE_HER`) REFERENCES `type_monstre` (`CODE_TYPE_MONSTRE`),
  ADD CONSTRAINT `carte_ibfk_16` FOREIGN KEY (`CODE_TYPE_PIEGE`) REFERENCES `type_piege` (`CODE_TYPE_PIEGE`),
  ADD CONSTRAINT `carte_ibfk_17` FOREIGN KEY (`CODE_TYPE_MAGIE`) REFERENCES `type_magie` (`CODE_TYPE_MAGIE`),
  ADD CONSTRAINT `carte_ibfk_18` FOREIGN KEY (`CODE_ATTR_CARTE`) REFERENCES `attribut_carte` (`CODE_ATTR_CARTE`),
  ADD CONSTRAINT `carte_ibfk_19` FOREIGN KEY (`CODE_ATTR_MO`) REFERENCES `attribut_monstre` (`CODE_ATTR_MO`),
  ADD CONSTRAINT `carte_ibfk_2` FOREIGN KEY (`CODE_TYPE_MAGIE`) REFERENCES `type_magie` (`CODE_TYPE_MAGIE`),
  ADD CONSTRAINT `carte_ibfk_20` FOREIGN KEY (`CODE_TYPE_MONSTRE_HER`) REFERENCES `type_monstre` (`CODE_TYPE_MONSTRE`),
  ADD CONSTRAINT `carte_ibfk_3` FOREIGN KEY (`CODE_ATTR_CARTE`) REFERENCES `attribut_carte` (`CODE_ATTR_CARTE`),
  ADD CONSTRAINT `carte_ibfk_4` FOREIGN KEY (`CODE_ATTR_MO`) REFERENCES `attribut_monstre` (`CODE_ATTR_MO`),
  ADD CONSTRAINT `carte_ibfk_5` FOREIGN KEY (`CODE_TYPE_MONSTRE_HER`) REFERENCES `type_monstre` (`CODE_TYPE_MONSTRE`),
  ADD CONSTRAINT `carte_ibfk_6` FOREIGN KEY (`CODE_TYPE_PIEGE`) REFERENCES `type_piege` (`CODE_TYPE_PIEGE`),
  ADD CONSTRAINT `carte_ibfk_7` FOREIGN KEY (`CODE_TYPE_MAGIE`) REFERENCES `type_magie` (`CODE_TYPE_MAGIE`),
  ADD CONSTRAINT `carte_ibfk_8` FOREIGN KEY (`CODE_ATTR_CARTE`) REFERENCES `attribut_carte` (`CODE_ATTR_CARTE`),
  ADD CONSTRAINT `carte_ibfk_9` FOREIGN KEY (`CODE_ATTR_MO`) REFERENCES `attribut_monstre` (`CODE_ATTR_MO`);

--
-- Contraintes pour la table `deck`
--
ALTER TABLE `deck`
  ADD CONSTRAINT `deck_ibfk_1` FOREIGN KEY (`USER`) REFERENCES `utilisateur` (`USER`),
  ADD CONSTRAINT `deck_ibfk_2` FOREIGN KEY (`USER`) REFERENCES `utilisateur` (`USER`),
  ADD CONSTRAINT `deck_ibfk_3` FOREIGN KEY (`USER`) REFERENCES `utilisateur` (`USER`),
  ADD CONSTRAINT `deck_ibfk_4` FOREIGN KEY (`USER`) REFERENCES `utilisateur` (`USER`);

--
-- Contraintes pour la table `effet_carte`
--
ALTER TABLE `effet_carte`
  ADD CONSTRAINT `effet_carte_ibfk_1` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_carte_ibfk_2` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`),
  ADD CONSTRAINT `effet_carte_ibfk_3` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_carte_ibfk_4` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`),
  ADD CONSTRAINT `effet_carte_ibfk_5` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_carte_ibfk_6` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`),
  ADD CONSTRAINT `effet_carte_ibfk_7` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_carte_ibfk_8` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`);

--
-- Contraintes pour la table `effet_meca`
--
ALTER TABLE `effet_meca`
  ADD CONSTRAINT `effet_meca_ibfk_1` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_meca_ibfk_2` FOREIGN KEY (`CODE_STRAT`) REFERENCES `strategie` (`CODE_STRAT`),
  ADD CONSTRAINT `effet_meca_ibfk_3` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_meca_ibfk_4` FOREIGN KEY (`CODE_STRAT`) REFERENCES `strategie` (`CODE_STRAT`),
  ADD CONSTRAINT `effet_meca_ibfk_5` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_meca_ibfk_6` FOREIGN KEY (`CODE_STRAT`) REFERENCES `strategie` (`CODE_STRAT`),
  ADD CONSTRAINT `effet_meca_ibfk_7` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_meca_ibfk_8` FOREIGN KEY (`CODE_STRAT`) REFERENCES `strategie` (`CODE_STRAT`);

--
-- Contraintes pour la table `inclus`
--
ALTER TABLE `inclus`
  ADD CONSTRAINT `inclus_ibfk_1` FOREIGN KEY (`NO_DECK`) REFERENCES `deck` (`NO_DECK`),
  ADD CONSTRAINT `inclus_ibfk_2` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`),
  ADD CONSTRAINT `inclus_ibfk_3` FOREIGN KEY (`NO_DECK`) REFERENCES `deck` (`NO_DECK`),
  ADD CONSTRAINT `inclus_ibfk_4` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`),
  ADD CONSTRAINT `inclus_ibfk_5` FOREIGN KEY (`NO_DECK`) REFERENCES `deck` (`NO_DECK`),
  ADD CONSTRAINT `inclus_ibfk_6` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`),
  ADD CONSTRAINT `inclus_ibfk_7` FOREIGN KEY (`NO_DECK`) REFERENCES `deck` (`NO_DECK`),
  ADD CONSTRAINT `inclus_ibfk_8` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
