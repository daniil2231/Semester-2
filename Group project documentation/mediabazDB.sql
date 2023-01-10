-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: mediaschemaa
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
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `EmployeeId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Age` int NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Nationality` varchar(56) NOT NULL,
  `Salary` double(10,2) NOT NULL,
  `PhoneNumber` bigint unsigned NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `BSN` int unsigned NOT NULL,
  `PermanentContract` tinyint(1) NOT NULL,
  `Position` enum('Admin','Manager','Worker','') NOT NULL,
  `IsAccountActive` tinyint(1) NOT NULL,
  `CovidVaccinated` tinyint(1) NOT NULL,
  PRIMARY KEY (`EmployeeId`)
) ENGINE=InnoDB AUTO_INCREMENT=8800 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'John','Wijnen',50,'Admin.Company@mail.com','123','Ginnekenweg 133','Dutch',100000.00,65315315189182,'Male',78465347,1,'Admin',1,1),(2,'Georgios','Metaxas',32,'Compay.admin@mail.com','123','Porthoslaan 185','Greek',100001.00,78178484281875,'Male',78614525,1,'Admin',1,1),(3,'Rutger','Verhoeff',21,'r.verhoeff@mail.com','555','Bachstraat 50','Dutch',46853.00,587154878521359,'Male',557859945,1,'Manager',1,1),(4,'Vlad','Tepes',55,'vlad@mail.com','555','Strada Lililacului 12','Romanian',56452.00,874326552659465,'Male',367354548,1,'Worker',1,0),(64,'jak','jel',97,'jakjel@gmail.com','555','nansen','Czech',46.00,454554555,'Female',46465,0,'Worker',0,0),(987,'Samuel','Samuelski',100,'jalfj@gmail.com','555','nansennansen','Czech',987.00,455454545,'Female',54664,0,'Worker',1,0),(8799,'Dandi','Bobandi',43,'da@mail.com','zxc','Idkstraat 5','Bulgarian',10.00,9853457,'Male',53334,1,'Worker',1,0);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shifts`
--

DROP TABLE IF EXISTS `shifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shifts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `EmployeeId` int NOT NULL,
  `ShiftDate` date NOT NULL,
  `ShiftNumber` enum('Morning','Midday','Evening','') NOT NULL,
  PRIMARY KEY (`Id`,`EmployeeId`,`ShiftDate`,`ShiftNumber`),
  KEY `EmployeeIdShift_idx` (`EmployeeId`),
  CONSTRAINT `EmployeeIdShift` FOREIGN KEY (`EmployeeId`) REFERENCES `employees` (`EmployeeId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shifts`
--

LOCK TABLES `shifts` WRITE;
/*!40000 ALTER TABLE `shifts` DISABLE KEYS */;
INSERT INTO `shifts` VALUES (14,4,'2022-03-14','Midday'),(16,4,'2022-03-15','Evening'),(17,4,'2022-03-15','Midday'),(18,8799,'2022-03-14','Morning'),(19,8799,'2022-03-14','Evening');
/*!40000 ALTER TABLE `shifts` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-20 21:49:09
