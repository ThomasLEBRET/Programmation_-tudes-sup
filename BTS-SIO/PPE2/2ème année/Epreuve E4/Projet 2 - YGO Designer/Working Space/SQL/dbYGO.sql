-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 13, 2020 at 10:11 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ygo`
--

-- --------------------------------------------------------

--
-- Table structure for table `attribut_carte`
--

DROP TABLE IF EXISTS `attribut_carte`;
CREATE TABLE IF NOT EXISTS `attribut_carte` (
  `CODE_ATTR_CARTE` varchar(12) NOT NULL,
  `NOM_ATTR_CARTE` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CODE_ATTR_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `attribut_carte`
--

INSERT INTO `attribut_carte` (`CODE_ATTR_CARTE`, `NOM_ATTR_CARTE`) VALUES
('MAG', 'Magie'),
('MON', 'Monstre'),
('PIE', 'Piège');

-- --------------------------------------------------------

--
-- Table structure for table `carte`
--

DROP TABLE IF EXISTS `carte`;
CREATE TABLE IF NOT EXISTS `carte` (
  `NO_CARTE` bigint(12) NOT NULL,
  `CODE_ATTR_CARTE` varchar(12) NOT NULL,
  `NOM` varchar(100) DEFAULT NULL,
  `DESCRIPTION` text,
  `TYPE_MO` varchar(128) DEFAULT NULL,
  `ATTR_MO` varchar(128) DEFAULT NULL,
  `NIVEAU_MO` smallint(6) DEFAULT NULL,
  `ATK` int(4) NOT NULL,
  `DEF` int(4) NOT NULL,
  `TYPE_MA` varchar(128) DEFAULT NULL,
  `TYPE_PI` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`NO_CARTE`),
  KEY `I_FK_CARTE_ATTRIBUT_CARTE` (`CODE_ATTR_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `deck`
--

DROP TABLE IF EXISTS `deck`;
CREATE TABLE IF NOT EXISTS `deck` (
  `NO_DECK` int(11) NOT NULL,
  `USER` char(32) NOT NULL,
  `NOM_DECK` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`NO_DECK`),
  KEY `I_FK_DECK_UTILISATEUR` (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `effet`
--

DROP TABLE IF EXISTS `effet`;
CREATE TABLE IF NOT EXISTS `effet` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `NOM_EFFET` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CODE_EFFET`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `effet`
--

INSERT INTO `effet` (`CODE_EFFET`, `NOM_EFFET`) VALUES
('BAN', 'Bannir'),
('CHPOSCOM', 'Changement de position de combat'),
('DESMON', 'Destruction de monstres'),
('DESMP', 'Destruction de Magie/Piège'),
('DMGEFC', 'Dommages d\'effet'),
('FUS', 'Fusion/Liée aux fusions'),
('GEM', 'Gémeau'),
('INVSPE', 'Invocation Spéciale'),
('NORMON', 'Monstre Normal/Liée aux monstres normaux'),
('PAR', '¨Pari'),
('PIO', 'Pioche'),
('RIT', 'Rituel/Liée aux rituels'),
('SPI', 'Spirit'),
('SYNCHRO', 'Synchro/Liée aux Monstres Synchro'),
('SYNTO', 'Syntoniseur'),
('TERTOCIM', 'Du Cimetière vers la Main/le Terrain'),
('TOK', 'Jeton'),
('TOON', 'Toon'),
('UNI', 'Union'),
('UPLP', 'Augmentation des LP'),
('VARATKDEF', 'Augmenter/Diminuer ATK/DEF'),
('XYZ', 'Liée à Xyz');

-- --------------------------------------------------------

--
-- Table structure for table `effet_carte`
--

DROP TABLE IF EXISTS `effet_carte`;
CREATE TABLE IF NOT EXISTS `effet_carte` (
  `CODE_EFFET` varchar(50) NOT NULL,
  `NO_CARTE` bigint(12) NOT NULL,
  PRIMARY KEY (`CODE_EFFET`,`NO_CARTE`),
  KEY `I_FK_EFFET_CARTE_EFFET` (`CODE_EFFET`),
  KEY `I_FK_EFFET_CARTE_CARTE` (`NO_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `effet_meca`
--

DROP TABLE IF EXISTS `effet_meca`;
CREATE TABLE IF NOT EXISTS `effet_meca` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `CODE_STRAT` varchar(12) NOT NULL,
  PRIMARY KEY (`CODE_EFFET`,`CODE_STRAT`),
  KEY `I_FK_EFFET_MECA_EFFET` (`CODE_EFFET`),
  KEY `I_FK_EFFET_MECA_STRATEGIE` (`CODE_STRAT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `inclus`
--

DROP TABLE IF EXISTS `inclus`;
CREATE TABLE IF NOT EXISTS `inclus` (
  `NO_DECK` int(11) NOT NULL,
  `NO_CARTE` bigint(12) NOT NULL,
  PRIMARY KEY (`NO_DECK`,`NO_CARTE`),
  KEY `I_FK_INCLUS_DECK` (`NO_DECK`),
  KEY `I_FK_INCLUS_CARTE` (`NO_CARTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `strategie`
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
-- Table structure for table `type_user`
--

DROP TABLE IF EXISTS `type_user`;
CREATE TABLE IF NOT EXISTS `type_user` (
  `CD_TYPE` char(32) NOT NULL,
  `NOM_TYPE` char(32) DEFAULT NULL,
  PRIMARY KEY (`CD_TYPE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `USER` char(32) NOT NULL,
  `CD_TYPE` char(32) NOT NULL,
  `MDP` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`USER`),
  KEY `I_FK_UTILISATEUR_TYPE_USER` (`CD_TYPE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `carte`
--
ALTER TABLE `carte`
  ADD CONSTRAINT `carte_ibfk_1` FOREIGN KEY (`CODE_ATTR_CARTE`) REFERENCES `attribut_carte` (`CODE_ATTR_CARTE`);

--
-- Constraints for table `deck`
--
ALTER TABLE `deck`
  ADD CONSTRAINT `deck_ibfk_1` FOREIGN KEY (`USER`) REFERENCES `utilisateur` (`USER`);

--
-- Constraints for table `effet_carte`
--
ALTER TABLE `effet_carte`
  ADD CONSTRAINT `effet_carte_ibfk_1` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_carte_ibfk_2` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`);

--
-- Constraints for table `effet_meca`
--
ALTER TABLE `effet_meca`
  ADD CONSTRAINT `effet_meca_ibfk_1` FOREIGN KEY (`CODE_EFFET`) REFERENCES `effet` (`CODE_EFFET`),
  ADD CONSTRAINT `effet_meca_ibfk_2` FOREIGN KEY (`CODE_STRAT`) REFERENCES `strategie` (`CODE_STRAT`);

--
-- Constraints for table `inclus`
--
ALTER TABLE `inclus`
  ADD CONSTRAINT `inclus_ibfk_1` FOREIGN KEY (`NO_DECK`) REFERENCES `deck` (`NO_DECK`),
  ADD CONSTRAINT `inclus_ibfk_2` FOREIGN KEY (`NO_CARTE`) REFERENCES `carte` (`NO_CARTE`);

--
-- Constraints for table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD CONSTRAINT `utilisateur_ibfk_1` FOREIGN KEY (`CD_TYPE`) REFERENCES `type_user` (`CD_TYPE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
