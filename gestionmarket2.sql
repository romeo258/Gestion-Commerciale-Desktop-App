CREATE DATABASE  IF NOT EXISTS `gestionmarket2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `gestionmarket2`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: gestionmarket2
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `article`
--

DROP TABLE IF EXISTS `article`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `article` (
  `codeArt` int NOT NULL AUTO_INCREMENT,
  `nomArt` varchar(50) NOT NULL,
  `prixArt` int NOT NULL,
  `stockArt` int NOT NULL,
  `nomCat` varchar(50) NOT NULL,
  `dateExpArt` date NOT NULL,
  PRIMARY KEY (`codeArt`),
  KEY `nomCat` (`nomCat`),
  CONSTRAINT `article_ibfk_1` FOREIGN KEY (`nomCat`) REFERENCES `categorie` (`nomCat`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5012 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `article`
--

LOCK TABLES `article` WRITE;
/*!40000 ALTER TABLE `article` DISABLE KEYS */;
INSERT INTO `article` VALUES (5001,'RED LABEL',25000,8,'WISKY','2023-03-04'),(5002,'BLACK LABEL',15000,3,'WISKY','2023-03-04'),(5003,'BEL MUSTA DORA',12500,11,'CHAMPAGNE','2023-03-04'),(5007,'TAK',10000,39,'CHAMPAGNE','2023-03-04'),(5009,'PICO',5000,8,'WISKY','2023-03-04');
/*!40000 ALTER TABLE `article` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorie` (
  `nomCat` varchar(50) NOT NULL,
  `remCat` varchar(150) NOT NULL,
  PRIMARY KEY (`nomCat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorie`
--

LOCK TABLES `categorie` WRITE;
/*!40000 ALTER TABLE `categorie` DISABLE KEYS */;
INSERT INTO `categorie` VALUES ('CHAMPAGNE','tout type'),('VIN BLANC','tout type'),('VIN ROUGE','tout type'),('WISKY','ALL TYPE');
/*!40000 ALTER TABLE `categorie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facture`
--

DROP TABLE IF EXISTS `facture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facture` (
  `pseudo` varchar(30) NOT NULL,
  `dateVente` date NOT NULL,
  `montAntVente` int NOT NULL,
  KEY `pseudo` (`pseudo`),
  CONSTRAINT `facture_ibfk_1` FOREIGN KEY (`pseudo`) REFERENCES `vendeur` (`pseudo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facture`
--

LOCK TABLES `facture` WRITE;
/*!40000 ALTER TABLE `facture` DISABLE KEYS */;
INSERT INTO `facture` VALUES ('WILSON','2023-03-04',75000),('WILSON','2023-03-04',45000),('WILSON','2023-03-06',3000),('WILSON','2023-03-06',50000),('WILSON','2023-03-06',25000),('WILSON','2023-03-06',15000),('WILSON','2023-03-06',15000),('WILSON','2023-03-06',15000),('WILSON','2023-03-07',16000),('WILSON','2023-06-02',12500),('WILSON','2023-06-12',122500),('wilson','2023-07-08',65000),('WILSON','2023-09-16',65000),('staline','2023-09-16',140000),('WILSON','2023-11-23',65000);
/*!40000 ALTER TABLE `facture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendeur`
--

DROP TABLE IF EXISTS `vendeur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vendeur` (
  `pseudo` varchar(30) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `motPass` varchar(10) NOT NULL,
  `adresse` varchar(150) NOT NULL,
  `phone` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`pseudo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendeur`
--

LOCK TABLES `vendeur` WRITE;
/*!40000 ALTER TABLE `vendeur` DISABLE KEYS */;
INSERT INTO `vendeur` VALUES ('staline','staline ken','staline','Douala Akwa\r\nAkwa Bercy\r\n','695509454'),('WILSON','TEMGOUA ROMEO','romeo1234','YAOUNDE-CAMEROUN, Nkolfoulou 1','682629274');
/*!40000 ALTER TABLE `vendeur` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-20 15:25:51
