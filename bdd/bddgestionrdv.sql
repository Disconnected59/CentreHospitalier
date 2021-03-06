-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 02 avr. 2019 à 11:55
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
  KEY `IDX_C2997CD148D62931` (`id_service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `assistant`
--

INSERT INTO `assistant` (`id`, `id_service_id`, `nom`, `prenom`) VALUES
(1, 1, 'Lombroi', 'Kevin'),
(2, 2, 'Casse', 'Laure'),
(3, 3, 'Bertrand', 'Jacob'),
(4, 4, 'Douminos', 'Zineb'),
(5, 1, 'Lecompte', 'Quentin'),
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
  `date` date NOT NULL,
  `heure` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `est_validee` tinyint(1) DEFAULT NULL,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patient_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_964685A6A1799A53` (`id_medecin_id`),
  KEY `IDX_964685A66B899279` (`patient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `consultation`
--

INSERT INTO `consultation` (`id`, `id_medecin_id`, `date`, `heure`, `est_validee`, `nom`, `prenom`, `patient_id`) VALUES
(1, 4, '2019-03-15', '12', 1, 'Test', 'Test\r\n', 5),
(2, 1, '2019-03-20', '10', 1, 'fg', 'f', 3),
(3, 6, '2019-02-04', '11', 1, 'Jean', 'Patate', 2),
(4, 8, '2019-03-21', '12', 1, 'dggd', 'grdgd', 4),
(5, 1, '2019-03-22', '14', 1, 'Poudlard', 'Harry', 2),
(6, 6, '2019-03-31', '15', 1, 'Poudlard', 'Harry', 2),
(7, 1, '2019-08-16', '10', 1, 'Poudlard', 'Harry', 2),
(8, 3, '2019-04-02', '9', 1, 'Bliatsuki', 'Jacob', 5);

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
(7, 6, 'Kevinlepape', 'flan', 'kevinlepape@random.com', '26 rue Gato', 'Lepape', 'Kevin', 'https://github.com/Disconnected59/CentreHospitalier/blob/master/GestionRendezVous/images/doc1.jpg?raw=true'),
(8, 5, 'antoinetest', 'antoinetest', 'dfgrgdr', 'rfd', 'antoinetest', 'antoinetest', NULL);

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
('20190312144757'),
('20190314130538'),
('20190314142511'),
('20190314152016'),
('20190314154118'),
('20190318093139'),
('20190318094314'),
('20190318094448'),
('20190318095926'),
('20190322101040');

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `adresse` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `nom` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id`, `email`, `adresse`, `nom`, `prenom`) VALUES
(1, 'oui', 'oui', 'Bernard', 'Patate'),
(2, 'non', 'non', 'Poudlard', 'Harry'),
(3, 'Peutetre', 'Peutetre', 'Lolita', 'Jessica'),
(4, 'Ouio', 'Ouio', 'Kadjiski', 'Bertrand'),
(5, 'Nonoui', 'Nonoui', 'Bliatsuki', 'Jacob');

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
  `id_medecin_id` int(11) DEFAULT NULL,
  `id_assistant_id` int(11) DEFAULT NULL,
  `patient_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_8D93D649F85E0677` (`username`),
  UNIQUE KEY `UNIQ_8D93D649A1799A53` (`id_medecin_id`),
  UNIQUE KEY `UNIQ_8D93D649C392F29D` (`id_assistant_id`),
  UNIQUE KEY `UNIQ_8D93D6496B899279` (`patient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `username`, `roles`, `password`, `nom`, `prenom`, `id_medecin_id`, `id_assistant_id`, `patient_id`) VALUES
(1, 'bekir', '[\"ROLE_USER\", \"ROLE_MEDECIN\"]', '$2y$10$7pwzZ4aIdsrmKgGGa0Eqrev116T4lOfYfevfMai3sZzdFnf2IOtd.', 'Aydogdu', 'Bekir\r\n', 3, NULL, NULL),
(2, 'antoine', '[\"ROLE_USER\", \"ROLE_MEDECIN\"]', '$2y$10$Wd1l0PVJsr7P.MV7o11HmeUfuBN2ihY65YMVh6oUSrCvyXd3ImySS', 'Bearez', 'Antoine', 1, NULL, NULL),
(3, 'quentin', '[\"ROLE_USER\", \"ROLE_ASSISTANT\"]', '$2y$10$z5mFEE.Oa87YC2Cc0eocAexViZxaTMHD0oK.sL.iCSBJGAOs2IzFK', 'Lecompte', 'Quentin', NULL, 5, NULL),
(4, 'test', '[\"ROLE_USER\"]', '$2y$10$Vbjae/GIkTFe5v6XnF.4WOnJ6iqNxAmc5QTRfERiCoqWzHCoH8aRG', 'Test', 'Test\r\n', NULL, NULL, 2),
(5, 'bliatsuki', '[\"ROLE_USER\"]', '$2y$10$E3AUjsbHWHNjjtcf2LZSAuF5u5gIAe1VHAJ5GE9sfYoM.5mhyt4.y', 'Bliatsuki', 'Jacob', NULL, NULL, 5),
(6, 'Jacob', '[\"ROLE_USER\", \"ROLE_ASSISTANT\"]', '$2y$10$zUEQWGCZoAkO2hYsDw0OaOSJGpsxajxGes2x/kERFyBnRp8Tz1LLe', 'Jacob', 'Bertrand', NULL, 3, NULL);

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
  ADD CONSTRAINT `FK_964685A66B899279` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`),
  ADD CONSTRAINT `FK_964685A6A1799A53` FOREIGN KEY (`id_medecin_id`) REFERENCES `medecin` (`id`);

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `FK_1BDA53C6ED5CA9E6` FOREIGN KEY (`service_id`) REFERENCES `service` (`id`);

--
-- Contraintes pour la table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `FK_8D93D6496B899279` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`),
  ADD CONSTRAINT `FK_8D93D649A1799A53` FOREIGN KEY (`id_medecin_id`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `FK_8D93D649C392F29D` FOREIGN KEY (`id_assistant_id`) REFERENCES `assistant` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
