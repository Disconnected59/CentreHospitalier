-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 12 mars 2019 à 15:01
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bddgestionrdv`
--
CREATE DATABASE IF NOT EXISTS `bddgestionrdv` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `bddgestionrdv`;

-- --------------------------------------------------------

--
-- Structure de la table `assistant`
--

DROP TABLE IF EXISTS `assistant`;
CREATE TABLE IF NOT EXISTS `assistant` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_service_id` int(11) DEFAULT NULL,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_C2997CD148D62931` (`id_service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `assistant`
--

INSERT INTO `assistant` (`id`, `id_service_id`, `nom`, `prenom`) VALUES
(1, 1, 'Lombroi', 'Kevin'),
(2, 2, 'Casse', 'Laure'),
(3, 3, 'Decheval', 'Adam'),
(4, 4, 'Douminos', 'Zineb'),
(5, 5, 'Bearez', 'Antoine'),
(6, 6, 'Lendore', 'Theophile'),
(7, 7, 'Enair', 'Jessie'),
(8, 8, 'Lavale', 'Pierre'),
(9, 9, 'Rubine', 'Claudine'),
(10, 10, 'Jubile', 'Jean'),
(11, 11, 'Chong', 'Chin\r\n'),
(12, 12, 'Poly', 'Karene'),
(13, 13, 'Loukir', 'Paul'),
(14, 14, 'Jesus', 'Joseph'),
(15, 15, 'Artoung', 'Bertrand');

-- --------------------------------------------------------

--
-- Structure de la table `consultation`
--

DROP TABLE IF EXISTS `consultation`;
CREATE TABLE IF NOT EXISTS `consultation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_medecin_id` int(11) NOT NULL,
  `id_patient_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `heure` time NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_964685A6A1799A53` (`id_medecin_id`),
  KEY `IDX_964685A6CE0312AE` (`id_patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `id_service`
--

DROP TABLE IF EXISTS `id_service`;
CREATE TABLE IF NOT EXISTS `id_service` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
CREATE TABLE IF NOT EXISTS `medecin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `service_id` int(11) NOT NULL,
  `login` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `motdepasse` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `adresse` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nom` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `photo` varchar(1000) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_1BDA53C6ED5CA9E6` (`service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`id`, `service_id`, `login`, `motdepasse`, `email`, `adresse`, `nom`, `prenom`, `photo`) VALUES
(1, 1, 'antoine.bearez', 'bearez', 'antoine.bearez@chu-lille.fr', 'cysoing', 'bearez', 'antoine', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/telephone.png?raw=true'),
(2, 2, 'quentin.lecompte', 'lecompte', 'quentin.Lecompte@chu-lille.fr', 'leers', 'lecompte', 'quentin', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc1.jpg?raw=true'),
(3, 3, 'aydogdu', 'bekir', 'bekir.aydogdu@chu-lille.fr', 'roubaix', 'aydogdu', 'bekir', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc4.jpg?raw=true'),
(4, 4, 'tom.jablonski', 'jablonski', 'tom.jablonski@chu-lille.fr', 'mons', 'jablonski', 'tom', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc3.jpg?raw=true'),
(5, 11, 'nucleardoctor', 'nucleardoctor', 'nucleardoctor@random.com', '25 rue Fukushima', 'Chin', 'Chan', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc1.jpg?raw=true'),
(6, 6, 'Jesenspurien', 'Jesenspurien', 'Anesthesiehopital@random.com', '42 rue Pamal', 'Narcisse', 'Paul', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc1.jpg?raw=true'),
(7, 6, 'Kevinlepape', 'flan', 'kevinlepape@random.com', '26 rue Gato', 'Lepape', 'Kevin', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc1.jpg?raw=true');

-- --------------------------------------------------------

--
-- Structure de la table `migration_versions`
--

DROP TABLE IF EXISTS `migration_versions`;
CREATE TABLE IF NOT EXISTS `migration_versions` (
  `version` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`version`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `migration_versions`
--

INSERT INTO `migration_versions` (`version`) VALUES
('20190312144757');

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `motdepasse` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `adresse` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `nom` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id`, `login`, `motdepasse`, `email`, `adresse`, `nom`, `prenom`) VALUES
(1, 'oui', 'oui', 'oui', 'oui', 'Bernard', 'Patate'),
(2, 'non', 'non', 'non', 'non', 'Poudlard', 'Harry'),
(3, 'Peutetre', 'Peutetre', 'Peutetre', 'Peutetre', 'Lolita', 'Jessica'),
(4, 'Ouio', 'Ouio', 'Ouio', 'Ouio', 'Kadjiski', 'Bertrand'),
(5, 'Nonoui', 'Nonoui', 'Nonoui', 'Nonoui', 'Bliatsuki', 'Jacob');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`id`, `libelle`) VALUES
(1, 'Cardiologie'),
(2, 'Neurologie'),
(3, 'Orthodontie'),
(4, 'Pediatrie'),
(5, 'Douleur'),
(6, 'Anesthesie'),
(7, 'Chirurgie cardiaque'),
(8, 'Pneumologie'),
(9, 'Gynécologie'),
(10, 'Gérontologie'),
(11, 'Medecine nucléaire'),
(12, 'Clinique médicale'),
(13, 'Rhumatologie'),
(14, 'Réanimation'),
(15, 'Odontologie');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(180) COLLATE utf8mb4_unicode_ci NOT NULL,
  `roles` json NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_8D93D649F85E0677` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `username`, `roles`, `password`, `nom`, `prenom`) VALUES
(1, 'bekir', '[\"ROLE_USER\", \"ROLE_MEDECIN\"]', '$2y$10$7pwzZ4aIdsrmKgGGa0Eqrev116T4lOfYfevfMai3sZzdFnf2IOtd.', 'Aydogdu', 'Bekir\r\n'),
(2, 'antoine', '[\"ROLE_USER\", \"ROLE_MEDECIN\"]', '$2y$10$Wd1l0PVJsr7P.MV7o11HmeUfuBN2ihY65YMVh6oUSrCvyXd3ImySS', 'Bearez', 'Antoine'),
(3, 'quentin', '[\"ROLE_USER\", \"ROLE_ASSISTANT\"]', '$2y$10$z5mFEE.Oa87YC2Cc0eocAexViZxaTMHD0oK.sL.iCSBJGAOs2IzFK', 'Lecompte', 'Quentin'),
(4, 'test', '[\"ROLE_USER\"]', '$2y$10$Vbjae/GIkTFe5v6XnF.4WOnJ6iqNxAmc5QTRfERiCoqWzHCoH8aRG', 'Test', 'Test\r\n');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `assistant`
--
ALTER TABLE `assistant`
  ADD CONSTRAINT `FK_C2997CD148D62931` FOREIGN KEY (`id_service_id`) REFERENCES `service` (`id`);

--
-- Contraintes pour la table `consultation`
--
ALTER TABLE `consultation`
  ADD CONSTRAINT `FK_964685A6A1799A53` FOREIGN KEY (`id_medecin_id`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `FK_964685A6CE0312AE` FOREIGN KEY (`id_patient_id`) REFERENCES `patient` (`id`);

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `FK_1BDA53C6ED5CA9E6` FOREIGN KEY (`service_id`) REFERENCES `service` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
