-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `compressednaturalgas`
--

DROP TABLE IF EXISTS `compressednaturalgas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compressednaturalgas` (
  `fuelName` varchar(20) NOT NULL,
  `pricePerLiter` double NOT NULL,
  `suitability` varchar(100) NOT NULL,
  `purity` int NOT NULL,
  `airflowResistance` double NOT NULL,
  PRIMARY KEY (`fuelName`,`pricePerLiter`,`suitability`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compressednaturalgas`
--

LOCK TABLES `compressednaturalgas` WRITE;
/*!40000 ALTER TABLE `compressednaturalgas` DISABLE KEYS */;
/*!40000 ALTER TABLE `compressednaturalgas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diesel`
--

DROP TABLE IF EXISTS `diesel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diesel` (
  `fuelName` varchar(20) NOT NULL,
  `pricePerLiter` double NOT NULL,
  `suitability` varchar(100) NOT NULL,
  `purity` int NOT NULL,
  `viscosity` double NOT NULL,
  PRIMARY KEY (`fuelName`,`pricePerLiter`,`suitability`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diesel`
--

LOCK TABLES `diesel` WRITE;
/*!40000 ALTER TABLE `diesel` DISABLE KEYS */;
/*!40000 ALTER TABLE `diesel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fuel`
--

DROP TABLE IF EXISTS `fuel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fuel` (
  `fuelName` varchar(20) NOT NULL,
  `pricePerLiter` double NOT NULL,
  `suitability` varchar(100) NOT NULL,
  PRIMARY KEY (`fuelName`,`pricePerLiter`,`suitability`),
  CONSTRAINT `nameCNG` FOREIGN KEY (`fuelName`) REFERENCES `compressednaturalgas` (`fuelName`),
  CONSTRAINT `nameDiesel` FOREIGN KEY (`fuelName`) REFERENCES `diesel` (`fuelName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fuel`
--

LOCK TABLES `fuel` WRITE;
/*!40000 ALTER TABLE `fuel` DISABLE KEYS */;
/*!40000 ALTER TABLE `fuel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saleshistory`
--

DROP TABLE IF EXISTS `saleshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `saleshistory` (
  `username` varchar(20) NOT NULL,
  `zipCodesales` varchar(6) NOT NULL,
  `fuelNamesales` varchar(20) NOT NULL,
  `litersPurchasedsales` double NOT NULL,
  `cost` double NOT NULL,
  PRIMARY KEY (`username`),
  KEY `zipCode_idx` (`zipCodesales`),
  KEY `zipCodee_idx` (`zipCodesales`),
  KEY `zipCode_id` (`zipCodesales`) /*!80000 INVISIBLE */,
  KEY `zipCode_ix` (`zipCodesales`),
  KEY `zipCodesales_idx` (`zipCodesales`),
  KEY `fuelName_idx` (`fuelNamesales`),
  CONSTRAINT `fuelName` FOREIGN KEY (`fuelNamesales`) REFERENCES `fuel` (`fuelName`),
  CONSTRAINT `username` FOREIGN KEY (`username`) REFERENCES `users` (`username`),
  CONSTRAINT `zipCode` FOREIGN KEY (`zipCodesales`) REFERENCES `users` (`zipCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saleshistory`
--

LOCK TABLES `saleshistory` WRITE;
/*!40000 ALTER TABLE `saleshistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `saleshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `cardNumber` bigint NOT NULL,
  `cardValidThru` date NOT NULL,
  `cardCVC` int NOT NULL,
  `zipCode` varchar(6) NOT NULL,
  `phoneNumber` bigint NOT NULL,
  `role` varchar(10) NOT NULL,
  PRIMARY KEY (`username`,`zipCode`),
  KEY `zipCode` (`zipCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('a','1234',1234123412341234,'2022-03-18',456,'5622GP',884832010,'Customer'),('asd','123',12345667,'2022-03-23',333,'6555',565756856,'Customer'),('dandi','123',4321432143214321,'2022-10-11',0,'4555GP',12341234,'Admin');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-19 19:03:38
