CREATE DATABASE  IF NOT EXISTS `rental` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `rental`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: rental
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `CustomerId` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) DEFAULT NULL,
  `FullName` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`CustomerId`),
  KEY `UserId` (`UserId`),
  CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `user` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `damage`
--

DROP TABLE IF EXISTS `damage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `damage` (
  `DamageId` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleId` int(11) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `Cost` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`DamageId`),
  KEY `VehicleId` (`VehicleId`),
  CONSTRAINT `damage_ibfk_1` FOREIGN KEY (`VehicleId`) REFERENCES `vehicle` (`VehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `damage`
--

LOCK TABLES `damage` WRITE;
/*!40000 ALTER TABLE `damage` DISABLE KEYS */;
/*!40000 ALTER TABLE `damage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `damagereport`
--

DROP TABLE IF EXISTS `damagereport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `damagereport` (
  `DamageReportId` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleId` int(11) NOT NULL,
  `ReportDate` date DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `EstimatedCost` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`DamageReportId`),
  KEY `VehicleId` (`VehicleId`),
  CONSTRAINT `damagereport_ibfk_1` FOREIGN KEY (`VehicleId`) REFERENCES `vehicle` (`VehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `damagereport`
--

LOCK TABLES `damagereport` WRITE;
/*!40000 ALTER TABLE `damagereport` DISABLE KEYS */;
/*!40000 ALTER TABLE `damagereport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `InvoiceId` int(11) NOT NULL AUTO_INCREMENT,
  `RentalId` int(11) NOT NULL,
  `InvoiceDate` date DEFAULT NULL,
  `TotalAmount` decimal(10,2) DEFAULT NULL,
  `Status` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`InvoiceId`),
  KEY `RentalId` (`RentalId`),
  CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`RentalId`) REFERENCES `rental` (`RentalId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `license`
--

DROP TABLE IF EXISTS `license`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `license` (
  `LicenseId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) NOT NULL,
  `LicenseNumber` varchar(50) DEFAULT NULL,
  `ExpiryDate` date DEFAULT NULL,
  PRIMARY KEY (`LicenseId`),
  KEY `CustomerId` (`CustomerId`),
  CONSTRAINT `license_ibfk_1` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `license`
--

LOCK TABLES `license` WRITE;
/*!40000 ALTER TABLE `license` DISABLE KEYS */;
/*!40000 ALTER TABLE `license` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maintenancerecord`
--

DROP TABLE IF EXISTS `maintenancerecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `maintenancerecord` (
  `MaintenanceId` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleId` int(11) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Cost` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`MaintenanceId`),
  KEY `VehicleId` (`VehicleId`),
  CONSTRAINT `maintenancerecord_ibfk_1` FOREIGN KEY (`VehicleId`) REFERENCES `vehicle` (`VehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maintenancerecord`
--

LOCK TABLES `maintenancerecord` WRITE;
/*!40000 ALTER TABLE `maintenancerecord` DISABLE KEYS */;
/*!40000 ALTER TABLE `maintenancerecord` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `PaymentId` int(11) NOT NULL AUTO_INCREMENT,
  `RentalId` int(11) DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `PaymentDate` date DEFAULT NULL,
  `Method` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`PaymentId`),
  KEY `RentalId` (`RentalId`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`RentalId`) REFERENCES `rental` (`RentalId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rateconfiguration`
--

DROP TABLE IF EXISTS `rateconfiguration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rateconfiguration` (
  `RateId` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleType` enum('SUV','Sedan','Hatchback','Pickup') DEFAULT NULL,
  `DailyRate` decimal(10,2) DEFAULT NULL,
  `EffectiveFrom` date DEFAULT NULL,
  `EffectiveTo` date DEFAULT NULL,
  PRIMARY KEY (`RateId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rateconfiguration`
--

LOCK TABLES `rateconfiguration` WRITE;
/*!40000 ALTER TABLE `rateconfiguration` DISABLE KEYS */;
/*!40000 ALTER TABLE `rateconfiguration` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rental`
--

DROP TABLE IF EXISTS `rental`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rental` (
  `RentalId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `VehicleId` int(11) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `TotalAmount` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`RentalId`),
  KEY `CustomerId` (`CustomerId`),
  KEY `VehicleId` (`VehicleId`),
  CONSTRAINT `rental_ibfk_1` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`),
  CONSTRAINT `rental_ibfk_2` FOREIGN KEY (`VehicleId`) REFERENCES `vehicle` (`VehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rental`
--

LOCK TABLES `rental` WRITE;
/*!40000 ALTER TABLE `rental` DISABLE KEYS */;
/*!40000 ALTER TABLE `rental` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservation` (
  `ReservationId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `VehicleId` int(11) DEFAULT NULL,
  `ReservationDate` date DEFAULT NULL,
  `Status` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ReservationId`),
  KEY `CustomerId` (`CustomerId`),
  KEY `VehicleId` (`VehicleId`),
  CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`),
  CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`VehicleId`) REFERENCES `vehicle` (`VehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Customer','Agent') NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `VehicleId` int(11) NOT NULL AUTO_INCREMENT,
  `PlateNumber` varchar(20) NOT NULL,
  `Brand` varchar(50) DEFAULT NULL,
  `Model` varchar(50) DEFAULT NULL,
  `VehicleType` enum('SUV','Sedan','Hatchback','Pickup') NOT NULL,
  `DailyRate` decimal(10,2) DEFAULT NULL,
  `Availability` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`VehicleId`),
  UNIQUE KEY `PlateNumber` (`PlateNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicleinspection`
--

DROP TABLE IF EXISTS `vehicleinspection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicleinspection` (
  `InspectionId` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleId` int(11) NOT NULL,
  `InspectionDate` date DEFAULT NULL,
  `ConditionNotes` text DEFAULT NULL,
  `InspectorName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`InspectionId`),
  KEY `VehicleId` (`VehicleId`),
  CONSTRAINT `vehicleinspection_ibfk_1` FOREIGN KEY (`VehicleId`) REFERENCES `vehicle` (`VehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicleinspection`
--

LOCK TABLES `vehicleinspection` WRITE;
/*!40000 ALTER TABLE `vehicleinspection` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehicleinspection` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-01-05  1:31:05
