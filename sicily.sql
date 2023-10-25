-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 25 oct. 2023 à 16:54
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `sicily`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `ID_BATEAU` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `LONGUEUR` double(5,2) DEFAULT NULL,
  `LARGEUR` double(5,2) DEFAULT NULL,
  `VITESSE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`ID_BATEAU`, `NOM`, `LONGUEUR`, `LARGEUR`, `VITESSE`) VALUES
(1, 'Eduardo', 37.20, 8.60, 26),
(2, 'Platone', 25.00, 7.00, 16);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `ID_CATEGORIE` varchar(1) NOT NULL,
  `LIBELLE_CATEGORIE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`ID_CATEGORIE`, `LIBELLE_CATEGORIE`) VALUES
('A', 'Passager'),
('B', 'Véh.inf.2m'),
('C', 'Véh.sup.2m');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `ID_CLIENT` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `PRENOM` char(32) DEFAULT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `CP` char(5) DEFAULT NULL,
  `VILLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `ID_CATEGORIE` varchar(1) NOT NULL,
  `ID_BATEAU` int(11) NOT NULL,
  `CAPACITEMAX` int(11) DEFAULT NULL,
  `ID_CAPACITE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `contenir`
--

INSERT INTO `contenir` (`ID_CATEGORIE`, `ID_BATEAU`, `CAPACITEMAX`, `ID_CAPACITE`) VALUES
('A', 1, 210, '1'),
('A', 2, 155, '2'),
('B', 1, 9, '3'),
('B', 2, 0, '4'),
('C', 1, 2, '5'),
('C', 2, 0, '6');

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `ID_EQUIPEMENT` int(11) NOT NULL,
  `LIBELLE_EQUIPEMENT` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`ID_EQUIPEMENT`, `LIBELLE_EQUIPEMENT`) VALUES
(1, 'Accès handicapé'),
(2, 'Bar'),
(3, 'Pont promenade'),
(4, 'Salon vidéo');

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `ID_LIAISON` int(11) NOT NULL,
  `ID_SECTEUR` int(11) NOT NULL,
  `ID_PORT` int(11) NOT NULL,
  `ID_PORT_ARRIVEE` int(11) NOT NULL,
  `DUREE_LIAISON` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`ID_LIAISON`, `ID_SECTEUR`, `ID_PORT`, `ID_PORT_ARRIVEE`, `DUREE_LIAISON`) VALUES
(11, 3, 3, 6, '00:50:00'),
(15, 1, 1, 5, '01:30:00'),
(16, 2, 2, 7, '01:25:00'),
(17, 2, 2, 8, '01:45:00'),
(19, 2, 2, 9, '02:05:00'),
(21, 4, 4, 11, '00:39:00'),
(24, 1, 1, 6, '04:00:00'),
(25, 3, 3, 8, '00:40:00'),
(30, 4, 4, 10, '02:30:00');

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `ID_PERIODE` int(11) NOT NULL,
  `DATEDEBUT` date DEFAULT NULL,
  `DATEFIN` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `periode`
--

INSERT INTO `periode` (`ID_PERIODE`, `DATEDEBUT`, `DATEFIN`) VALUES
(1, '2021-09-01', '2022-06-15'),
(2, '2022-06-16', '2022-09-15'),
(3, '2022-09-16', '2023-05-31');

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `ID_PORT` int(11) NOT NULL,
  `NOM_PORT` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`ID_PORT`, `NOM_PORT`) VALUES
(1, 'Palerme'),
(2, 'Messine'),
(3, 'Milazzo'),
(4, 'Trapani'),
(5, 'Ustica'),
(6, 'Lipari'),
(7, 'Stromboli'),
(8, 'Vulcano'),
(9, 'Panarea'),
(10, 'Pantelleria'),
(11, 'Favignagna');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

CREATE TABLE `proposer` (
  `ID_EQUIPEMENT` int(11) NOT NULL,
  `ID_BATEAU` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `proposer`
--

INSERT INTO `proposer` (`ID_EQUIPEMENT`, `ID_BATEAU`) VALUES
(1, 1),
(1, 2),
(2, 1),
(3, 1),
(3, 2),
(4, 1);

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `ID_RESERVATION` int(11) NOT NULL,
  `ID_CLIENT` int(11) NOT NULL,
  `ID_TRAVERSEE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `ID_SECTEUR` int(11) NOT NULL,
  `LIBELLE_SECTEUR` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`ID_SECTEUR`, `LIBELLE_SECTEUR`) VALUES
(1, 'Palerme'),
(2, 'Messine'),
(3, 'Milazzo'),
(4, 'Trapani');

-- --------------------------------------------------------

--
-- Structure de la table `selectionner`
--

CREATE TABLE `selectionner` (
  `ID_RESERVATION` int(11) NOT NULL,
  `ID_TYPE` int(11) NOT NULL,
  `ID_QUANTITE` int(11) NOT NULL,
  `QUANTITE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `tarifer`
--

CREATE TABLE `tarifer` (
  `ID_PERIODE` int(11) NOT NULL,
  `ID_LIAISON` int(11) NOT NULL,
  `ID_TYPE` int(11) NOT NULL,
  `TARIF` decimal(13,2) DEFAULT NULL,
  `ID_TARIF` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `tarifer`
--

INSERT INTO `tarifer` (`ID_PERIODE`, `ID_LIAISON`, `ID_TYPE`, `TARIF`, `ID_TARIF`) VALUES
(1, 11, 1, 20.00, '1'),
(1, 11, 2, 13.10, '2'),
(1, 11, 3, 7.00, '3'),
(1, 11, 4, 95.00, '4'),
(1, 11, 5, 142.00, '5'),
(1, 11, 6, 208.00, '6'),
(1, 11, 7, 226.00, '7'),
(1, 11, 8, 295.00, '8');

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `ID_TRAVERSEE` int(11) NOT NULL,
  `ID_LIAISON` int(11) NOT NULL,
  `ID_BATEAU` int(11) NOT NULL,
  `DATE_TRAVERSEE` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`ID_TRAVERSEE`, `ID_LIAISON`, `ID_BATEAU`, `DATE_TRAVERSEE`, `HEURE`) VALUES
(541200, 16, 2, '2021-09-21', '12:15:00'),
(541201, 16, 1, '2021-09-21', '14:30:00');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `ID_TYPE` int(11) NOT NULL,
  `ID_CATEGORIE` varchar(1) NOT NULL,
  `LIBELLE_TYPE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`ID_TYPE`, `ID_CATEGORIE`, `LIBELLE_TYPE`) VALUES
(1, 'A', 'Adulte'),
(2, 'A', 'Junior 8 à 18 ans'),
(3, 'A', 'Enfant 0 à 7 ans'),
(4, 'B', 'Voiture long.inf.4m'),
(5, 'B', 'Voiture long.inf.5m'),
(6, 'C', 'Fourgon'),
(7, 'C', 'Camping Car'),
(8, 'C', 'Camion');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD PRIMARY KEY (`ID_BATEAU`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`ID_CATEGORIE`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`ID_CLIENT`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`ID_CATEGORIE`,`ID_BATEAU`,`ID_CAPACITE`),
  ADD KEY `I_FK_CONTENIR_CATEGORIE` (`ID_CATEGORIE`),
  ADD KEY `I_FK_CONTENIR_BATEAU` (`ID_BATEAU`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`ID_EQUIPEMENT`);

--
-- Index pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD PRIMARY KEY (`ID_LIAISON`),
  ADD KEY `I_FK_LIAISON_SECTEUR` (`ID_SECTEUR`),
  ADD KEY `I_FK_LIAISON_PORT` (`ID_PORT`),
  ADD KEY `I_FK_LIAISON_PORT1` (`ID_PORT_ARRIVEE`);

--
-- Index pour la table `periode`
--
ALTER TABLE `periode`
  ADD PRIMARY KEY (`ID_PERIODE`);

--
-- Index pour la table `port`
--
ALTER TABLE `port`
  ADD PRIMARY KEY (`ID_PORT`);

--
-- Index pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD PRIMARY KEY (`ID_EQUIPEMENT`,`ID_BATEAU`),
  ADD KEY `I_FK_PROPOSER_EQUIPEMENT` (`ID_EQUIPEMENT`),
  ADD KEY `I_FK_PROPOSER_BATEAU` (`ID_BATEAU`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ID_RESERVATION`),
  ADD KEY `I_FK_RESERVATION_CLIENT` (`ID_CLIENT`),
  ADD KEY `I_FK_RESERVATION_TRAVERSEE` (`ID_TRAVERSEE`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD PRIMARY KEY (`ID_SECTEUR`);

--
-- Index pour la table `selectionner`
--
ALTER TABLE `selectionner`
  ADD PRIMARY KEY (`ID_RESERVATION`,`ID_TYPE`,`ID_QUANTITE`),
  ADD KEY `I_FK_SELECTIONNER_RESERVATION` (`ID_RESERVATION`),
  ADD KEY `I_FK_SELECTIONNER_TYPE` (`ID_TYPE`);

--
-- Index pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD PRIMARY KEY (`ID_PERIODE`,`ID_LIAISON`,`ID_TYPE`,`ID_TARIF`),
  ADD KEY `I_FK_TARIFER_PERIODE` (`ID_PERIODE`),
  ADD KEY `I_FK_TARIFER_LIAISON` (`ID_LIAISON`),
  ADD KEY `I_FK_TARIFER_TYPE` (`ID_TYPE`);

--
-- Index pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD PRIMARY KEY (`ID_TRAVERSEE`),
  ADD KEY `I_FK_TRAVERSEE_LIAISON` (`ID_LIAISON`),
  ADD KEY `I_FK_TRAVERSEE_BATEAU` (`ID_BATEAU`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`ID_TYPE`),
  ADD KEY `I_FK_TYPE_CATEGORIE` (`ID_CATEGORIE`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `FK_CONTENIR_BATEAU` FOREIGN KEY (`ID_BATEAU`) REFERENCES `bateau` (`ID_BATEAU`),
  ADD CONSTRAINT `FK_CONTENIR_CATEGORIE` FOREIGN KEY (`ID_CATEGORIE`) REFERENCES `categorie` (`ID_CATEGORIE`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `FK_LIAISON_PORT` FOREIGN KEY (`ID_PORT`) REFERENCES `port` (`ID_PORT`),
  ADD CONSTRAINT `FK_LIAISON_PORT1` FOREIGN KEY (`ID_PORT_ARRIVEE`) REFERENCES `port` (`ID_PORT`),
  ADD CONSTRAINT `FK_LIAISON_SECTEUR` FOREIGN KEY (`ID_SECTEUR`) REFERENCES `secteur` (`ID_SECTEUR`);

--
-- Contraintes pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD CONSTRAINT `FK_PROPOSER_BATEAU` FOREIGN KEY (`ID_BATEAU`) REFERENCES `bateau` (`ID_BATEAU`),
  ADD CONSTRAINT `FK_PROPOSER_EQUIPEMENT` FOREIGN KEY (`ID_EQUIPEMENT`) REFERENCES `equipement` (`ID_EQUIPEMENT`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_RESERVATION_CLIENT` FOREIGN KEY (`ID_CLIENT`) REFERENCES `client` (`ID_CLIENT`),
  ADD CONSTRAINT `FK_RESERVATION_TRAVERSEE` FOREIGN KEY (`ID_TRAVERSEE`) REFERENCES `traversee` (`ID_TRAVERSEE`);

--
-- Contraintes pour la table `selectionner`
--
ALTER TABLE `selectionner`
  ADD CONSTRAINT `FK_SELECTIONNER_RESERVATION` FOREIGN KEY (`ID_RESERVATION`) REFERENCES `reservation` (`ID_RESERVATION`),
  ADD CONSTRAINT `FK_SELECTIONNER_TYPE` FOREIGN KEY (`ID_TYPE`) REFERENCES `type` (`ID_TYPE`);

--
-- Contraintes pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD CONSTRAINT `FK_TARIFER_LIAISON` FOREIGN KEY (`ID_LIAISON`) REFERENCES `liaison` (`ID_LIAISON`),
  ADD CONSTRAINT `FK_TARIFER_PERIODE` FOREIGN KEY (`ID_PERIODE`) REFERENCES `periode` (`ID_PERIODE`),
  ADD CONSTRAINT `FK_TARIFER_TYPE` FOREIGN KEY (`ID_TYPE`) REFERENCES `type` (`ID_TYPE`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `FK_TRAVERSEE_BATEAU` FOREIGN KEY (`ID_BATEAU`) REFERENCES `bateau` (`ID_BATEAU`),
  ADD CONSTRAINT `FK_TRAVERSEE_LIAISON` FOREIGN KEY (`ID_LIAISON`) REFERENCES `liaison` (`ID_LIAISON`);

--
-- Contraintes pour la table `type`
--
ALTER TABLE `type`
  ADD CONSTRAINT `FK_TYPE_CATEGORIE` FOREIGN KEY (`ID_CATEGORIE`) REFERENCES `categorie` (`ID_CATEGORIE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
