-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: mysql-omuzoki.alwaysdata.net
-- Generation Time: Nov 26, 2020 at 06:42 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `omuzoki_ygodesigner`
--

-- --------------------------------------------------------

--
-- Table structure for table `attribut_carte`
--

CREATE TABLE `attribut_carte` (
  `CODE_ATTR_CARTE` varchar(12) NOT NULL,
  `NOM_ATTR_CARTE` varchar(15) DEFAULT NULL
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

CREATE TABLE `carte` (
  `NO_CARTE` bigint(12) NOT NULL,
  `CODE_ATTR_CARTE` varchar(12) NOT NULL,
  `NOM` varchar(100) DEFAULT NULL,
  `DESCRIPTION` text DEFAULT NULL,
  `TYPE_MO` varchar(128) DEFAULT NULL,
  `ATTR_MO` varchar(128) DEFAULT NULL,
  `NIVEAU_MO` smallint(6) DEFAULT NULL,
  `ATK` int(4) DEFAULT NULL,
  `DEF` int(4) DEFAULT NULL,
  `TYPES_MONSTE_CARTE` varchar(50) DEFAULT NULL,
  `TYPE_MA` varchar(128) DEFAULT NULL,
  `TYPE_PI` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `carte`
--

INSERT INTO `carte` (`NO_CARTE`, `CODE_ATTR_CARTE`, `NOM`, `DESCRIPTION`, `TYPE_MO`, `ATTR_MO`, `NIVEAU_MO`, `ATK`, `DEF`, `TYPES_MONSTE_CARTE`, `TYPE_MA`, `TYPE_PI`) VALUES
(11012154, 'MON', 'Justicia Dragarde', 'L\'avenir du Monde dépend des Dragardes nés de l\'Héritage du Monde.', 'Dragon', 'Eau', 2, 0, 2100, 'Syntoniseur', NULL, NULL),
(12580477, 'MAG', 'Raigeki', 'Détruisez tous les monstres contrôlés par votre adversaire.', NULL, NULL, NULL, NULL, NULL, NULL, 'Normale', NULL),
(84749824, 'PIE', 'Avertissement Divin', 'Lorsqu\'un ou plusieurs monstres vont être Invoqués; OU lorsqu\'un effet qui Invoque Spécialement un ou plusieurs monstres est activé : payez 2000LP ; annulez l\'Invocation ou l\'activation, et si vous le faites, détruisez-les.', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Contre_Piege'),
(89208725, 'PIE', 'Métavers', 'Prenez 1 Magie de Terrain depuis votre Deck, et soit activez-la soit ajoutez-la à votre main.', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Normale');

--
-- Triggers `carte`
--
DELIMITER $$
CREATE TRIGGER `delEffectOneCard` BEFORE DELETE ON `carte` FOR EACH ROW BEGIN
    DELETE FROM effet_carte WHERE NO_CARTE = old.NO_CARTE;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `deck`
--

CREATE TABLE `deck` (
  `NO_DECK` int(11) NOT NULL,
  `USER` char(32) NOT NULL,
  `NOM_DECK` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `deck`
--

INSERT INTO `deck` (`NO_DECK`, `USER`, `NOM_DECK`) VALUES
(1, 'Omuzoki', 'Fourre-tout '),
(2, 'Nicoelzozo V2', 'francis le deck'),
(3, 'Omuzoki', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `effet`
--

CREATE TABLE `effet` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `NOM_EFFET` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `effet`
--

INSERT INTO `effet` (`CODE_EFFET`, `NOM_EFFET`) VALUES
('BANAVECIB', 'Banni en ciblant '),
('BANSANCIB', 'Bannir sans cibler'),
('CHERTODECK', 'Chercher dans le deck '),
('CHPOSCOM', 'Changement de position de combat'),
('CIMTODEC', 'Du Cimetière au Deck'),
('CIMTOMAI', 'Du Cimetière vers la Main'),
('CIMTOTER', 'Du Cimetière au Terrain'),
('DECRATK', 'Diminuer ATK'),
('DECRDEF', 'Diminuer DEF'),
('DECRLP', 'Diminuer les points de vie'),
('DECTOCIM', 'Du Deck au Cimetière'),
('DECTOMAI', 'Du Deck à la Main'),
('DECTOTER', 'Du Deck au Terrain'),
('DESMON', 'Destruction de monstres'),
('DESMP', 'Destruction de Magie/Piège'),
('DESTRAVECIB', 'Détruit en ciblant '),
('DESUNMON', 'Destruction d\'UN monstre'),
('DMGEFC', 'Dommages d\'effet'),
('INCRATK', 'Augmenter ATK'),
('INCRDEF', 'Augmenter DEF'),
('INCRLP', 'Augmentation des points de vie'),
('INTEREFMAG', 'Interruption Effet Magie'),
('INTEREFMON', 'Interruption Effet Monstre'),
('INTEREFPIE', 'Interruption Effet Piège'),
('INTERINVOC', 'Interruption d\'invocation'),
('PAR', 'Pari'),
('PERINVCOND', 'Permet d\'être invoqué sous condition'),
('PERMINV', 'Permet d\'être invoqué spécialement'),
('PERMINVSPE', 'Permet de réaliser une Invocation Spéciale'),
('TERTOCIM', 'Du Terrain au Cimetière'),
('TERTODECJ', 'Du Terrain au Deck'),
('TERTOMAI', 'Du Terrain à la Main'),
('TOK', 'Jeton');

-- --------------------------------------------------------

--
-- Table structure for table `effet_carte`
--

CREATE TABLE `effet_carte` (
  `CODE_EFFET` varchar(50) NOT NULL,
  `NO_CARTE` bigint(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `effet_carte`
--

INSERT INTO `effet_carte` (`CODE_EFFET`, `NO_CARTE`) VALUES
('DECTOMAI', 89208725),
('DECTOTER', 89208725),
('DESMON', 12580477),
('DESMON', 84749824),
('DESMP', 84749824),
('INTEREFMAG', 84749824),
('INTEREFMON', 84749824),
('INTEREFPIE', 84749824),
('INTERINVOC', 84749824);

-- --------------------------------------------------------

--
-- Table structure for table `effet_meca`
--

CREATE TABLE `effet_meca` (
  `CODE_EFFET` varchar(12) NOT NULL,
  `CODE_STRAT` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `inclus`
--

CREATE TABLE `inclus` (
  `NO_DECK` int(11) NOT NULL,
  `NO_CARTE` bigint(12) NOT NULL,
  `NB_EXEMPLAIRE` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inclus`
--

INSERT INTO `inclus` (`NO_DECK`, `NO_CARTE`, `NB_EXEMPLAIRE`) VALUES
(1, 11012154, 3),
(1, 12580477, 3),
(1, 84749824, 3),
(1, 89208725, 3),
(2, 11012154, 3),
(2, 12580477, 3),
(2, 84749824, 3),
(2, 89208725, 3);

-- --------------------------------------------------------

--
-- Table structure for table `strategie`
--

CREATE TABLE `strategie` (
  `CODE_STRAT` varchar(12) NOT NULL,
  `NOM_STRAT` varchar(30) DEFAULT NULL,
  `RATIO_MONSTRE_STRAT` decimal(2,2) DEFAULT NULL,
  `RATIO_MAGIE_STRAT` decimal(2,2) DEFAULT NULL,
  `RATIO_PIEGE_STRAT` decimal(2,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `type_user`
--

CREATE TABLE `type_user` (
  `CD_TYPE` char(32) NOT NULL,
  `NOM_TYPE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `type_user`
--

INSERT INTO `type_user` (`CD_TYPE`, `NOM_TYPE`) VALUES
('ADM', 'Administrateur'),
('JOU', 'Joueur');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `USER` char(32) NOT NULL,
  `CD_TYPE` char(32) NOT NULL,
  `MDP` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`USER`, `CD_TYPE`, `MDP`) VALUES
('Nicoelzozo', 'JOU', 'Zozozo92'),
('Nicoelzozo V2', 'JOU', 'Zozozo92'),
('Omuzoki', 'JOU', 'omuzoki'),
('Thomas', 'ADM', 'test'),
('Yann', 'JOU', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attribut_carte`
--
ALTER TABLE `attribut_carte`
  ADD PRIMARY KEY (`CODE_ATTR_CARTE`);

--
-- Indexes for table `carte`
--
ALTER TABLE `carte`
  ADD PRIMARY KEY (`NO_CARTE`),
  ADD KEY `I_FK_CARTE_ATTRIBUT_CARTE` (`CODE_ATTR_CARTE`);

--
-- Indexes for table `deck`
--
ALTER TABLE `deck`
  ADD PRIMARY KEY (`NO_DECK`),
  ADD KEY `I_FK_DECK_UTILISATEUR` (`USER`);

--
-- Indexes for table `effet`
--
ALTER TABLE `effet`
  ADD PRIMARY KEY (`CODE_EFFET`);

--
-- Indexes for table `effet_carte`
--
ALTER TABLE `effet_carte`
  ADD PRIMARY KEY (`CODE_EFFET`,`NO_CARTE`),
  ADD KEY `I_FK_EFFET_CARTE_EFFET` (`CODE_EFFET`),
  ADD KEY `I_FK_EFFET_CARTE_CARTE` (`NO_CARTE`);

--
-- Indexes for table `effet_meca`
--
ALTER TABLE `effet_meca`
  ADD PRIMARY KEY (`CODE_EFFET`,`CODE_STRAT`),
  ADD KEY `I_FK_EFFET_MECA_EFFET` (`CODE_EFFET`),
  ADD KEY `I_FK_EFFET_MECA_STRATEGIE` (`CODE_STRAT`);

--
-- Indexes for table `inclus`
--
ALTER TABLE `inclus`
  ADD PRIMARY KEY (`NO_DECK`,`NO_CARTE`),
  ADD KEY `I_FK_INCLUS_DECK` (`NO_DECK`),
  ADD KEY `I_FK_INCLUS_CARTE` (`NO_CARTE`);

--
-- Indexes for table `strategie`
--
ALTER TABLE `strategie`
  ADD PRIMARY KEY (`CODE_STRAT`);

--
-- Indexes for table `type_user`
--
ALTER TABLE `type_user`
  ADD PRIMARY KEY (`CD_TYPE`);

--
-- Indexes for table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`USER`),
  ADD KEY `I_FK_UTILISATEUR_TYPE_USER` (`CD_TYPE`);

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
