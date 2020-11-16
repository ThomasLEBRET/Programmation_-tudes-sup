-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 16, 2020 at 07:37 AM
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
-- Database: `dbrestaurant`
--

-- --------------------------------------------------------

--
-- Table structure for table `plat`
--

DROP TABLE IF EXISTS `plat`;
CREATE TABLE IF NOT EXISTS `plat` (
  `nom` varchar(30) CHARACTER SET latin1 NOT NULL,
  `categorie` enum('Entrée','Plat','Dessert') CHARACTER SET latin1 NOT NULL,
  `prix` int(3) NOT NULL,
  `nbcalories` int(4) NOT NULL,
  `glutenFree` tinyint(1) NOT NULL,
  `vegan` tinyint(1) NOT NULL,
  PRIMARY KEY (`nom`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `plat`
--

INSERT INTO `plat` (`nom`, `categorie`, `prix`, `nbcalories`, `glutenFree`, `vegan`) VALUES
('Bol de riz', 'Plat', 2, 125, 0, 0),
('Donburi', 'Plat', 10, 200, 0, 1),
('Mochi ', 'Dessert', 3, 50, 1, 1),
('Nem', 'Entrée', 1, 25, 0, 1),
('Nom', 'Plat', 10, 10, 1, 0),
('Ramen', 'Plat', 9, 125, 0, 0),
('Soba', 'Plat', 9, 125, 0, 1),
('Takoyaki', 'Entrée', 1, 25, 0, 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
