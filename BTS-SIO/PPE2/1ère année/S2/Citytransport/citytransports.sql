-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 06, 2020 at 11:03 AM
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `citytransports`
--

-- --------------------------------------------------------

--
-- Table structure for table `historique_voyage`
--

DROP TABLE IF EXISTS `historique_voyage`;
CREATE TABLE IF NOT EXISTS `historique_voyage` (
  `id_voyage` int(11) NOT NULL AUTO_INCREMENT,
  `station_depart` varchar(255) DEFAULT NULL,
  `station_arrivee` varchar(255) DEFAULT NULL,
  `date_voyage` date DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_voyage`),
  KEY `FK1_historique_voyage` (`email`)
)AUTO_INCREMENT=5;

--
-- Dumping data for table `historique_voyage`
--

INSERT INTO `historique_voyage` (`id_voyage`, `station_depart`, `station_arrivee`, `date_voyage`, `email`) VALUES
(3, 'Cusset', 'MassÃ©na', '2020-03-31', 'th.lebret@outlook.fr'),
(4, 'Foch', 'Parilly', '2020-03-31', 'th.lebret@outlook.fr');

-- --------------------------------------------------------

--
-- Table structure for table `incident`
--

DROP TABLE IF EXISTS `incident`;
CREATE TABLE IF NOT EXISTS `incident` (
  `id_incident` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(255) DEFAULT NULL,
  `cd_incident` varchar(255) DEFAULT NULL,
  `dt_deb_inc` date NOT NULL,
  `dt_fin_inc` date DEFAULT NULL,
  `importance` varchar(10) NOT NULL,
  PRIMARY KEY (`id_incident`),
  KEY `cd_incident` (`cd_incident`)
)  AUTO_INCREMENT=4;

--
-- Dumping data for table `incident`
--

INSERT INTO `incident` (`id_incident`, `description`, `cd_incident`, `dt_deb_inc`, `dt_fin_inc`, `importance`) VALUES
(1, 'Panne sur la ligne', 'PAN', '2020-03-17', NULL, 'GRAND'),
(2, 'Fortes intemperies sur les lignes', 'MET', '2020-01-02', NULL, 'PETIT'),
(3, 'Travaux sur une ligne', 'TRA', '2020-02-07', '2020-03-17', 'PETIT');

-- --------------------------------------------------------

--
-- Table structure for table `ligne`
--

DROP TABLE IF EXISTS `ligne`;
CREATE TABLE IF NOT EXISTS `ligne` (
  `nom_ligne` varchar(10) NOT NULL,
  PRIMARY KEY (`nom_ligne`)
);

--
-- Dumping data for table `ligne`
--

INSERT INTO `ligne` (`nom_ligne`) VALUES
('A'),
('B'),
('C'),
('D');

-- --------------------------------------------------------

--
-- Table structure for table `parcourirs`
--

DROP TABLE IF EXISTS `parcourirs`;
CREATE TABLE IF NOT EXISTS `parcourirs` (
  `nom_ligne` varchar(1) NOT NULL,
  `id` int(11) NOT NULL,
  PRIMARY KEY (`nom_ligne`,`id`),
  KEY `id` (`id`)
);

--
-- Dumping data for table `parcourirs`
--

INSERT INTO `parcourirs` (`nom_ligne`, `id`) VALUES
('A', 5),
('A', 20),
('A', 21),
('A', 22),
('A', 23),
('A', 24),
('A', 25),
('A', 26),
('A', 27),
('A', 28),
('A', 29),
('A', 30),
('A', 31),
('A', 32),
('B', 7),
('B', 32),
('B', 33),
('B', 34),
('B', 35),
('B', 36),
('B', 37),
('B', 38),
('B', 39),
('B', 40),
('C', 16),
('C', 17),
('C', 18),
('C', 19),
('C', 20),
('D', 1),
('D', 2),
('D', 3),
('D', 4),
('D', 5),
('D', 6),
('D', 7),
('D', 8),
('D', 9),
('D', 10),
('D', 11),
('D', 12),
('D', 13),
('D', 14),
('D', 15);

-- --------------------------------------------------------

--
-- Table structure for table `reliers`
--

DROP TABLE IF EXISTS `reliers`;
CREATE TABLE IF NOT EXISTS `reliers` (
  `station_depart` int(11) NOT NULL,
  `station_destination` int(11) NOT NULL,
  `duree_trajet` int(11) DEFAULT NULL,
  `distance` double DEFAULT NULL,
  `nom_ligne` varchar(1) DEFAULT NULL,
  `nom_station_depart` varchar(255) DEFAULT NULL,
  `nom_station_destination` varchar(255) DEFAULT NULL,
  `direction` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`station_depart`,`station_destination`),
  KEY `station_destination` (`station_destination`),
  KEY `fk2` (`nom_ligne`)
);

--
-- Dumping data for table `reliers`
--

INSERT INTO `reliers` (`station_depart`, `station_destination`, `duree_trajet`, `distance`, `nom_ligne`, `nom_station_depart`, `nom_station_destination`, `direction`) VALUES
(1, 2, 2, 1000, 'D', 'Gare de Vaise', 'Valmy', 'Gare de Vénissieux'),
(2, 3, 3, 1900, 'D', 'Valmy', 'Gorge de Loup', 'Gare de Vénissieux'),
(3, 4, 4, 3000, 'D', 'Gorge de Loup', 'Vieux Lyon', 'Gare de Vénissieux'),
(4, 5, 1, 800, 'D', 'Vieux Lyon', 'Bellecour', 'Gare de Vénissieux'),
(5, 6, 2, 1200, 'D', 'Bellecour', 'Guillotière', 'Gare de Vénissieux'),
(6, 7, 1, 500, 'D', 'Guillotière', 'Gambetta', 'Gare de Vénissieux'),
(7, 8, 2, 1300, 'D', 'Gambetta', 'Garibaldi', 'Gare de Vénissieux'),
(8, 9, 3, 2000, 'D', 'Garibaldi', 'sans-souci', 'Gare de Vénissieux'),
(9, 10, 2, 900, 'D', 'sans-souci', 'Monplaisir - Lumière', 'Gare de Vénissieux'),
(10, 11, 3, 2000, 'D', 'Monplaisir - Lumière', 'Grange Blanche', 'Gare de Vénissieux'),
(11, 12, 2, 1100, 'D', 'Grange Blanche', 'Laënnec', 'Gare de Vénissieux'),
(12, 13, 4, 3500, 'D', 'Laënnec', 'Mermoz Pinel', 'Gare de Vénissieux'),
(13, 14, 3, 2500, 'D', 'Mermoz Pinel', 'Parilly', 'Gare de Vénissieux'),
(14, 15, 6, 4500, 'D', 'Parilly', 'Gare de Vénissieux', 'Gare de Vénissieux'),
(16, 17, 3, 2000, 'C', 'Cuire', 'Hénon', 'Hôtel de Ville'),
(17, 18, 2, 1300, 'C', 'Hénon', 'Croix-Rousse', 'Hôtel de Ville'),
(18, 19, 2, 1000, 'C', 'Croix-Rousse', 'Croix-Paquet', 'Hôtel de Ville'),
(19, 20, 1, 600, 'C', 'Croix-Paquet', 'Hôtel de Ville', 'Hôtel de Ville'),
(21, 22, 2, 1100, 'A', 'Perrache', 'Ampère Victor Hugo', 'Vaulx-en-velin La Soie'),
(22, 5, 3, 1500, 'A', 'Ampère Victor Hugo', 'Bellecour', 'Vaulx-en-velin La Soie'),
(5, 23, 3, 3000, 'A', 'Bellecour', 'Cordeliers', 'Vaulx-en-velin La Soie'),
(23, 20, 2, 1000, 'A', 'Cordeliers', 'Hôtel de Ville', 'Vaulx-en-velin La Soie'),
(20, 24, 2, 1200, 'A', 'Hôtel de Ville', 'Foch', 'Vaulx-en-velin La Soie'),
(24, 25, 2, 1200, 'A', 'Foch', 'Masséna', 'Vaulx-en-velin La Soie'),
(25, 32, 1, 700, 'A', 'Masséna', 'Charpennes Charles Hernu', 'Vaulx-en-velin La Soie'),
(32, 26, 4, 3000, 'A', 'Charpennes Charles Hernu', 'République Villeurbanne', 'Vaulx-en-velin La Soie'),
(26, 27, 2, 1300, 'A', 'République Villeurbanne', 'Gratte-ciel', 'Vaulx-en-velin La Soie'),
(27, 28, 2, 1400, 'A', 'Gratte-ciel', 'Flachet', 'Vaulx-en-velin La Soie'),
(28, 29, 2, 1400, 'A', 'Flachet', 'Cusset', 'Vaulx-en-velin La Soie'),
(29, 30, 2, 1500, 'A', 'Cusset', 'Laurent Bonnevay Astroballe', 'Vaulx-en-velin La Soie'),
(30, 31, 5, 4000, 'A', 'Laurent Bonnevay Astroballe', 'Vaulx-en-velin La Soie', 'Vaulx-en-velin La Soie'),
(32, 33, 1, 500, 'B', 'Charpennes Charles Hernu', 'Brotteaux', 'Oullins Gare'),
(33, 34, 2, 1200, 'B', 'Brotteaux', 'Gare Part-Dieu', 'Oullins Gare'),
(34, 35, 3, 1700, 'B', 'Gare Part-Dieu', 'Place Guichard', 'Oullins Gare'),
(35, 7, 1, 800, 'B', 'Place Guichard', 'Gambetta', 'Oullins Gare'),
(7, 36, 3, 2300, 'B', 'Gambetta', 'Jean Macé', 'Oullins Gare'),
(36, 37, 2, 1300, 'B', 'Jean Macé', 'Place Jean Jaurès', 'Oullins Gare'),
(37, 38, 4, 3000, 'B', 'Place Jean Jaurès', 'Debourg', 'Oullins Gare'),
(38, 39, 2, 1500, 'B', 'Debourg', 'Stade de Gerland', 'Oullins Gare'),
(39, 40, 6, 5127, 'B', 'Stade de Gerland', 'Oullins Gare', 'Oullins Gare'),
(2, 1, 2, 1000, 'D', 'Valmy', 'Gare de Vaise', 'Gare de Vaise'),
(3, 2, 3, 1900, 'D', 'Gorge de Loup', 'Valmy', 'Gare de Vaise'),
(4, 3, 4, 3000, 'D', 'Vieux Lyon', 'Gorge de Loup', 'Gare de Vaise'),
(5, 4, 1, 800, 'D', 'Bellecour', 'Vieux Lyon', 'Gare de Vaise'),
(6, 5, 2, 1200, 'D', 'Guillotière', 'Bellecour', 'Gare de Vaise'),
(7, 6, 1, 500, 'D', 'Gambetta', 'Guillotière', 'Gare de Vaise'),
(8, 7, 2, 1300, 'D', 'Garibaldi', 'Gambetta', 'Gare de Vaise'),
(9, 8, 3, 2000, 'D', 'sans-souci', 'Garibaldi', 'Gare de Vaise'),
(10, 9, 2, 900, 'D', 'Monplaisir - Lumière', 'sans-souci', 'Gare de Vaise'),
(11, 10, 3, 2000, 'D', 'Grange Blanche', 'Monplaisir - Lumière', 'Gare de Vaise'),
(12, 11, 2, 1100, 'D', 'Laënnec', 'Grange Blanche', 'Gare de Vaise'),
(13, 12, 4, 3500, 'D', 'Mermoz Pinel', 'Laënnec', 'Gare de Vaise'),
(14, 13, 3, 2500, 'D', 'Parilly', 'Mermoz Pinel', 'Gare de Vaise'),
(15, 14, 6, 4500, 'D', 'Gare de Vénissieux', 'Parilly', 'Gare de Vaise'),
(17, 16, 3, 2000, 'C', 'Hénon', 'Cuire', 'Cuire'),
(18, 17, 2, 1300, 'C', 'Croix-Rousse', 'Hénon', 'Cuire'),
(19, 18, 2, 1000, 'C', 'Croix-Paquet', 'Croix-Rousse', 'Cuire'),
(20, 19, 1, 600, 'C', 'Hôtel de Ville', 'Croix-Paquet', 'Cuire'),
(22, 21, 2, 1100, 'A', 'Ampère Victor Hugo', 'Perrache', 'Perrache'),
(5, 22, 3, 1500, 'A', 'Bellecour', 'Ampère Victor Hugo', 'Perrache'),
(23, 5, 3, 3000, 'A', 'Cordeliers', 'Bellecour', 'Perrache'),
(20, 23, 2, 1000, 'A', 'Hôtel de Ville', 'Cordeliers', 'Perrache'),
(24, 20, 2, 1200, 'A', 'Foch', 'Hôtel de Ville', 'Perrache'),
(25, 24, 2, 1200, 'A', 'Masséna', 'Foch', 'Perrache'),
(32, 25, 1, 700, 'A', 'Charpennes Charles Hernu', 'Masséna', 'Perrache'),
(26, 32, 4, 3000, 'A', 'République Villeurbanne', 'Charpennes Charles Hernu', 'Perrache'),
(27, 26, 2, 1300, 'A', 'Gratte-ciel', 'République Villeurbanne', 'Perrache'),
(28, 27, 2, 1400, 'A', 'Flachet', 'Gratte-ciel', 'Perrache'),
(29, 28, 2, 1400, 'A', 'Cusset', 'Flachet', 'Perrache'),
(30, 29, 2, 1500, 'A', 'Laurent Bonnevay Astroballe', 'Cusset', 'Perrache'),
(31, 30, 5, 4000, 'A', 'Vaulx-en-velin La Soie', 'Laurent Bonnevay Astroballe', 'Perrache'),
(33, 32, 1, 500, 'B', 'Brotteaux', 'Charpennes Charles Hernu', 'Charpennes Charles Hernu'),
(34, 33, 2, 1200, 'B', 'Gare Part-Dieu', 'Brotteaux', 'Charpennes Charles Hernu'),
(35, 34, 3, 1700, 'B', 'Place Guichard', 'Gare Part-Dieu', 'Charpennes Charles Hernu'),
(7, 35, 1, 800, 'B', 'Gambetta', 'Place Guichard', 'Charpennes Charles Hernu'),
(36, 7, 3, 2300, 'B', 'Jean Macé', 'Gambetta', 'Charpennes Charles Hernu'),
(37, 36, 2, 1300, 'B', 'Place Jean Jaurès', 'Jean Macé', 'Charpennes Charles Hernu'),
(38, 37, 4, 3000, 'B', 'Debourg', 'Place Jean Jaurès', 'Charpennes Charles Hernu'),
(39, 38, 2, 1500, 'B', 'Stade de Gerland', 'Debourg', 'Charpennes Charles Hernu'),
(40, 39, 6, 5127, 'B', 'Oullins Gare', 'Stade de Gerland', 'Charpennes Charles Hernu');

-- --------------------------------------------------------

--
-- Table structure for table `stations`
--

DROP TABLE IF EXISTS `stations`;
CREATE TABLE IF NOT EXISTS `stations` (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nom_station` varchar(255) DEFAULT NULL,
  `type` varchar(255) DEFAULT NULL,
  UNIQUE KEY `id` (`id`)
)  AUTO_INCREMENT=41;

--
-- Dumping data for table `stations`
--

INSERT INTO `stations` (`id`, `nom_station`, `type`) VALUES
(1, 'Gare de Vaise', 'sous-sol'),
(2, 'Valmy', 'sous-sol'),
(3, 'Gorge de Loup', 'sous-sol'),
(4, 'Vieux Lyon', 'sous-sol'),
(5, 'Bellecour', 'sous-sol'),
(6, 'Guillotière', 'sous-sol'),
(7, 'Gambetta', 'sous-sol'),
(8, 'Garibaldi', 'sous-sol'),
(9, 'sans-souci', 'sous-sol'),
(10, 'Monplaisir - Lumière', 'sous-sol'),
(11, 'Grange Blanche', 'sous-sol'),
(12, 'Laënnec', 'sous-sol'),
(13, 'Mermoz Pinel', 'sous-sol'),
(14, 'Parilly', 'sous-sol'),
(15, 'Gare de Vénissieux', 'sous-sol'),
(16, 'Cuire', 'sous-sol'),
(17, 'Hénon', 'sous-sol'),
(18, 'Croix-Rousse', 'sous-sol'),
(19, 'Croix-Paquet', 'sous-sol'),
(20, 'Hôtel de Ville', 'sous-sol'),
(21, 'Perrache', 'sous-sol'),
(22, 'Ampère Victor Hugo', 'sous-sol'),
(23, 'Cordeliers', 'sous-sol'),
(24, 'Foch', 'sous-sol'),
(25, 'Masséna', 'sous-sol'),
(26, 'République Villeurbanne', 'sous-sol'),
(27, 'Gratte-ciel', 'sous-sol'),
(28, 'Flachet', 'sous-sol'),
(29, 'Cusset', 'sous-sol'),
(30, 'Laurent Bonnevay Astroballe', 'sous-sol'),
(31, 'Vaulx-en-velin La Soie', 'sous-sol'),
(32, 'Charpennes Charles Hernu', 'sous-sol'),
(33, 'Brotteaux', 'sous-sol'),
(34, 'Gare Part-Dieu', 'sous-sol'),
(35, 'Place Guichard', 'sous-sol'),
(36, 'Jean Macé', 'sous-sol'),
(37, 'Place Jean Jaurès', 'sous-sol'),
(38, 'Debourg', 'sous-sol'),
(39, 'Stade de Gerland', 'sous-sol'),
(40, 'Oullins Gare', 'sous-sol');

-- --------------------------------------------------------

--
-- Table structure for table `type_incident`
--

DROP TABLE IF EXISTS `type_incident`;
CREATE TABLE IF NOT EXISTS `type_incident` (
  `cd_incident` varchar(20) NOT NULL,
  `lib_incident` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cd_incident`)
);

--
-- Dumping data for table `type_incident`
--

INSERT INTO `type_incident` (`cd_incident`, `lib_incident`) VALUES
('RET', 'Retard'),
('PAN', 'Panne'),
('GRE', 'Greve'),
('TRA', 'Travaux'),
('MET', 'Meteo');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `email` varchar(255) NOT NULL,
  `sexe` varchar(1) DEFAULT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `prenom` varchar(255) DEFAULT NULL,
  `date_de_naissance` date DEFAULT NULL,
  `rue` varchar(255) DEFAULT NULL,
  `code_postal` int(5) DEFAULT NULL,
  `sel` varchar(255) DEFAULT NULL,
  `ville` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `connexion_recente` date DEFAULT NULL,
  `derniere_connexion` date DEFAULT NULL,
  `derniere_ip_connue` varchar(15) DEFAULT NULL,
  `solde` int(11) DEFAULT NULL,
  PRIMARY KEY (`email`)
);

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`email`, `sexe`, `nom`, `prenom`, `date_de_naissance`, `rue`, `code_postal`, `sel`, `ville`, `password`, `connexion_recente`, `derniere_connexion`, `derniere_ip_connue`, `solde`) VALUES
('th.lebret@outlook.fr', 'H', 'LEBRET', 'Thomas', '2000-02-03', '5 Square Piscatory', 37330, '^575e6bU', 'ChÃ¢teau la ValliÃ¨re', '$2y$10$cWI7n.JfgX7gvZN.ZXmHPOGhWpi05Ig460eXEFa0A90S4jAAw8AFW', '2020-04-02', '2020-04-02', '77.133.167.112', 0),
('thomas.lebret91@gmail.com', 'H', 'LEBRET', 'Thomas', '2000-02-03', '91410, La Foret Le Roi', 91410, '}025e8bP', 'La ForÃªt-le-Roi', '$2y$10$hIVij0ZvoC58fRMKIT8Jau6rkYAv4TqVRXjF8Q/oy3B59tlavC4US', '2020-04-06', '2020-04-06', '77.133.167.112', 0);

-- --------------------------------------------------------

--
-- Table structure for table `verification`
--

DROP TABLE IF EXISTS `verification`;
CREATE TABLE IF NOT EXISTS `verification` (
  `email` varchar(255) NOT NULL,
  `token` varchar(255) NOT NULL,
  `dt_enregistrement` date NOT NULL,
  `verifie` int(1) NOT NULL,
  PRIMARY KEY (`email`)
);

--
-- Dumping data for table `verification`
--

INSERT INTO `verification` (`email`, `token`, `dt_enregistrement`, `verifie`) VALUES
('th.lebret@outlook.fr', '123456', '2020-04-02', 1),
('thomas.lebret91@gmail.com', '15154145785e8b0beef1f897.63458826', '2020-04-06', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
