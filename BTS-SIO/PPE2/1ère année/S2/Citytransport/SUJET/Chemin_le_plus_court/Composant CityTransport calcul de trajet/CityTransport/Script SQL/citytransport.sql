
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `citytransport`
--



--
-- Structure de la table `ligne`
--

DROP TABLE IF EXISTS `ligne`;
CREATE TABLE IF NOT EXISTS `ligne` (
  `nom_ligne` varchar(10) NOT NULL,
  PRIMARY KEY (`nom_ligne`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `ligne`
--

INSERT INTO `ligne` (`nom_ligne`) VALUES
('A'),
('B'),
('C'),
('D');

-- --------------------------------------------------------


--
-- Structure de la table `parcourirs`
--

DROP TABLE IF EXISTS `parcourirs`;
CREATE TABLE IF NOT EXISTS `parcourirs` (
  `nom_ligne` varchar(1) NOT NULL,
  `id` int(11) NOT NULL,
  PRIMARY KEY (`nom_ligne`,`id`),
  KEY `id` (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `parcourirs`
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
-- Structure de la table `reliers`
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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `reliers`
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
-- Structure de la table `stations`
--

DROP TABLE IF EXISTS `stations`;
CREATE TABLE IF NOT EXISTS `stations` (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nom_station` varchar(255) DEFAULT NULL,
  `type` varchar(255) DEFAULT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=41 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `stations`
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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
