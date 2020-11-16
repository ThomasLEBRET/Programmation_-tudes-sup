-- phpMyAdmin SQL Dump
-- version 3.5.8.1
-- http://www.phpmyadmin.net
--
-- Client: 127.0.0.1
-- Généré le: Dim 06 Janvier 2019 à 18:37
-- Version du serveur: 5.6.11-log
-- Version de PHP: 5.4.14

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `ndfgestion`
--

CREATE DATABASE `ndfgestion` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `ndfgestion`;

-- --------------------------------------------------------

--
-- Structure de la table `depense`
--

CREATE TABLE IF NOT EXISTS `depense` (
  `numDep` int(6) NOT NULL AUTO_INCREMENT,
  `libelleDep` varchar(50) NOT NULL,
  `montantDep` decimal(10,0) NOT NULL,
  `numNDF` int(4) NOT NULL,
  PRIMARY KEY (`numDep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `etat_ndf`
--

CREATE TABLE IF NOT EXISTS `etat_ndf` (
  `numEN` int(1) NOT NULL AUTO_INCREMENT,
  `nomEN` varchar(20) NOT NULL,
  PRIMARY KEY (`numEN`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `etat_ndf`
--

INSERT INTO `etat_ndf` (`numEN`, `nomEN`) VALUES
(1, 'Créée'),
(2, 'Validée'),
(3, 'Refusée'),
(4, 'Remboursée');

-- --------------------------------------------------------

--
-- Structure de la table `note_de_frais`
--

CREATE TABLE IF NOT EXISTS `note_de_frais` (
  `numNDF` int(4) NOT NULL AUTO_INCREMENT,
  `dateNDF` date NOT NULL,
  `loginUser` varchar(10) NOT NULL,
  `numEN` int(1) NOT NULL,
  PRIMARY KEY (`numNDF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE IF NOT EXISTS `service` (
  `numService` int(2) NOT NULL AUTO_INCREMENT,
  `nomService` varchar(20) NOT NULL,
  PRIMARY KEY (`numService`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `service`
--

INSERT INTO `service` (`numService`, `nomService`) VALUES
(1, 'Informatique'),
(2, 'Comptabilité');

-- --------------------------------------------------------

--
-- Structure de la table `type_compte`
--

CREATE TABLE IF NOT EXISTS `type_compte` (
  `numTC` int(1) NOT NULL AUTO_INCREMENT,
  `nomTC` varchar(20) NOT NULL,
  PRIMARY KEY (`numTC`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `type_compte`
--

INSERT INTO `type_compte` (`numTC`, `nomTC`) VALUES
(1, 'Employé'),
(2, 'Gestionnaire');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `loginUser` varchar(10) NOT NULL,
  `mdpUser` varchar(20) NOT NULL,
  `nomUser` varchar(30) NOT NULL,
  `prenomUser` varchar(30) NOT NULL,
  `numTC` int(2) NOT NULL,
  `numService` int(2) NOT NULL,
  PRIMARY KEY (`loginUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`loginUser`, `mdpUser`, `nomUser`, `prenomUser`, `numTC`, `numService`) VALUES
('a.compemp', 'mdp12', '', '', 1, 2),
('a.compgest', 'mdp22', '', '', 2, 2),
('a.infoemp', 'mdp11', '', '', 1, 1),
('a.infogest', 'mdp21', '', '', 2, 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
