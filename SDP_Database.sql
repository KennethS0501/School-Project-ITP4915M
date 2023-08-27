-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: sdp
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `access`
--

DROP TABLE IF EXISTS `access`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `access` (
  `AccessID` int NOT NULL,
  `AccessName` varchar(45) DEFAULT NULL,
  `AddAccount` tinyint DEFAULT '0',
  `RemoveAccount` tinyint DEFAULT '0',
  `ModifyAccount` tinyint DEFAULT '0',
  `AddProduct` tinyint DEFAULT '0',
  `RemoveProduct` tinyint DEFAULT '0',
  `ModifyProduct` tinyint DEFAULT '0',
  `AddStaff` tinyint DEFAULT '0',
  `RemoveStaff` tinyint DEFAULT '0',
  `ModifyStaff` tinyint DEFAULT '0',
  `DetailStaff` tinyint DEFAULT '0',
  `Payment` tinyint DEFAULT '0',
  `EditOrder` tinyint DEFAULT '0',
  `CancelOrder` tinyint DEFAULT '0',
  `RestockIndex` tinyint DEFAULT '0',
  `RestockFromWarehouse` tinyint DEFAULT '0',
  `CofirmSalesRestock` tinyint DEFAULT '0',
  `SetDangerLevelsSales` tinyint DEFAULT '0',
  PRIMARY KEY (`AccessID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `access`
--

LOCK TABLES `access` WRITE;
/*!40000 ALTER TABLE `access` DISABLE KEYS */;
INSERT INTO `access` VALUES (1,'CEO',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1),(3,'Sales',0,0,0,0,0,0,0,0,0,0,1,1,0,1,0,1,0),(5,'1',1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `access` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `staffID` int NOT NULL,
  `password` int DEFAULT NULL,
  PRIMARY KEY (`staffID`),
  CONSTRAINT `FK324262436` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (1,111),(2,111),(3,111),(4,111),(5,111),(6,111),(8,111),(9,111),(12,111),(13,111),(14,NULL),(15,NULL),(18,NULL);
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customerID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `phone` int DEFAULT NULL,
  `AddDate` datetime NOT NULL,
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'AaronTestMethod','dasda',22222222,'2022-06-06 03:44:04'),(2,'KennethTest','',12341234,'2022-06-06 04:11:32'),(4,'KennethTest1','HHHHH',12341234,'2022-06-06 09:37:32'),(5,'KennethTest1','A',32131412,'2022-06-06 09:43:22'),(6,'KennethTest13',NULL,51242331,'2022-06-06 09:43:44'),(7,'KennethTest1234',NULL,12351234,'2022-06-06 09:49:07'),(8,'aaa',NULL,24224444,'2022-06-06 09:58:32'),(9,'gggggg',NULL,22215466,'2022-06-06 10:01:59'),(10,'sdadsa',NULL,22215466,'2022-06-06 10:14:31'),(11,'sdadsa','sadads',22215466,'2022-06-06 10:15:47'),(12,'asd',NULL,22222222,'2022-06-06 10:18:52'),(13,'AAAA',NULL,11111111,'2022-06-23 22:18:03'),(14,'aaa',NULL,89898988,'2022-06-23 22:33:35'),(15,'sorry',NULL,898989898,'2022-06-23 22:41:18'),(16,'aaa',NULL,89898989,'2022-06-23 23:01:59'),(17,'TestDepositCreateOrder',NULL,12341234,'2022-06-24 19:24:21'),(18,'TestDeposit',NULL,12341234,'2022-06-24 20:09:00'),(19,'TestDeposit',NULL,12341234,'2022-06-24 20:10:14'),(20,'TestReceiptForderSelect',NULL,21341234,'2022-06-24 20:14:23'),(21,'TestReceipt2',NULL,12341234,'2022-06-24 20:15:25'),(22,'TestReceipt2',NULL,12341234,'2022-06-24 20:16:20'),(23,'TestDeposit',NULL,12341234,'2022-06-24 20:18:16'),(24,'TestCheckout',NULL,12341234,'2022-06-24 20:18:43'),(25,'KennethCancelTest',NULL,12341234,'2022-06-28 12:07:07'),(26,'LLL',NULL,111,'2022-06-28 12:35:42'),(27,'aaaas',NULL,111,'2022-06-28 12:38:58'),(28,'Test aaa',NULL,12341234,'2022-06-29 00:38:08'),(29,'Chak Kai Long',NULL,11112222,'2022-06-29 00:39:59'),(30,'TestInstallation','aa',12341234,'2022-06-29 00:40:21'),(31,'TestInstallation','AAA',12341234,'2022-06-29 00:43:54'),(32,'TestInstallation1','AA',12341234,'2022-06-29 00:49:56'),(33,'Alan wong',NULL,99999999,'2022-06-29 01:25:25');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `delivery`
--

DROP TABLE IF EXISTS `delivery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery` (
  `deliveryID` int NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `timeSession` varchar(20) NOT NULL,
  `staffID` int DEFAULT NULL,
  `status` varchar(20) DEFAULT '0',
  `deliveryDate` date DEFAULT NULL,
  PRIMARY KEY (`deliveryID`),
  KEY `FKdelivery78883` (`staffID`),
  CONSTRAINT `FKdelivery78883` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery`
--

LOCK TABLES `delivery` WRITE;
/*!40000 ALTER TABLE `delivery` DISABLE KEYS */;
INSERT INTO `delivery` VALUES (10,'2022-06-09','',8,'1','2022-06-29'),(11,'2022-06-15','Afternoon',NULL,'2','2022-06-28'),(13,'2022-06-05','Afternoon',NULL,'0','2022-06-06'),(14,'2022-06-06','Morning',8,'0','2022-06-28'),(15,'2022-06-05','',NULL,'0','2022-06-28'),(16,'2022-06-29','Morning',NULL,'0',NULL),(17,'2022-06-29','Afternoon',NULL,'0',NULL),(18,'2022-06-29','Afternoon',NULL,'0',NULL);
/*!40000 ALTER TABLE `delivery` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `departID` int NOT NULL AUTO_INCREMENT,
  `departName` varchar(30) NOT NULL,
  PRIMARY KEY (`departID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Sales'),(2,'IT'),(3,'Inventory'),(4,'Technical Support'),(5,'Purchase'),(6,'Accounting');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departmentmanager`
--

DROP TABLE IF EXISTS `departmentmanager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departmentmanager` (
  `staffID` int NOT NULL,
  `departID` int NOT NULL,
  PRIMARY KEY (`departID`),
  KEY `FKdepartment61658` (`staffID`),
  CONSTRAINT `FKdepartment355423` FOREIGN KEY (`departID`) REFERENCES `department` (`departID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FKdepartment61658` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departmentmanager`
--

LOCK TABLES `departmentmanager` WRITE;
/*!40000 ALTER TABLE `departmentmanager` DISABLE KEYS */;
/*!40000 ALTER TABLE `departmentmanager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `installation`
--

DROP TABLE IF EXISTS `installation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `installation` (
  `installationID` int NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `timeSession` varchar(20) NOT NULL,
  `staffID` int DEFAULT NULL,
  `status` varchar(20) DEFAULT '0',
  `installtionDate` date DEFAULT NULL,
  PRIMARY KEY (`installationID`),
  KEY `FKinstallati147808` (`staffID`),
  CONSTRAINT `FKinstallati147808` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `installation`
--

LOCK TABLES `installation` WRITE;
/*!40000 ALTER TABLE `installation` DISABLE KEYS */;
INSERT INTO `installation` VALUES (7,'2022-06-09','A',9,'0','2022-06-23'),(9,'2022-06-06','A',NULL,'0','2022-06-23'),(10,'2022-06-29','Afternoon',NULL,NULL,NULL),(11,'2022-06-29','Afternoon',NULL,NULL,NULL);
/*!40000 ALTER TABLE `installation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `orderID` int NOT NULL AUTO_INCREMENT,
  `customerID` int NOT NULL,
  `deliveryID` int DEFAULT NULL,
  `installationID` int DEFAULT NULL,
  `method` varchar(20) NOT NULL,
  `totalPrice` double NOT NULL,
  `payDate` date NOT NULL,
  `dMethod` varchar(50) NOT NULL,
  `deposit` varchar(1) NOT NULL,
  `Cancel` varchar(1) NOT NULL,
  PRIMARY KEY (`orderID`),
  KEY `FKorder889113` (`deliveryID`),
  KEY `FKorder979197` (`installationID`),
  KEY `FKcustomer1` (`customerID`),
  CONSTRAINT `FKcustomer1` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`),
  CONSTRAINT `FKorder889113` FOREIGN KEY (`deliveryID`) REFERENCES `delivery` (`deliveryID`),
  CONSTRAINT `FKorder979197` FOREIGN KEY (`installationID`) REFERENCES `installation` (`installationID`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,1,10,7,'cash',40,'2022-06-06','Cross-border Shipping','0','1'),(2,2,15,NULL,'cash',20,'2022-06-06','Cross-border Shipping','0','1'),(3,4,11,NULL,'cash',1200,'2022-06-06','Local Shipping','0','1'),(4,5,13,NULL,'cash',20,'2022-06-06','Cross-border Shipping','0','1'),(5,6,NULL,NULL,'cash',20,'2022-06-06','Self-Service','0','1'),(6,7,NULL,NULL,'cash',4000,'2022-06-06','Self-Service','0','1'),(7,8,NULL,NULL,'cash',20,'2022-06-06','Self-Service','0','1'),(8,9,NULL,NULL,'cash',20,'2022-06-06','Self-Service','0','1'),(9,10,NULL,NULL,'cash',20,'2022-06-06','Self-Service','0','1'),(10,11,14,9,'cash',20,'2022-06-06','Local Shipping','0','0'),(11,12,NULL,NULL,'cash',20,'2022-06-06','Self-Service','0','0'),(12,13,NULL,NULL,'cash',20,'2022-06-23','Self-Service','0','1'),(13,14,NULL,NULL,'cash',20,'2022-06-23','Self-Service','0','0'),(14,15,NULL,NULL,'cash',20,'2022-06-23','Self-Service','0','0'),(15,16,NULL,NULL,'cash',20,'2022-06-23','Self-Service','0','0'),(16,17,NULL,NULL,'cash',1800,'2022-06-24','Self-Service','0','0'),(17,18,NULL,NULL,'cash',3000,'2022-06-24','Self-Service','0','0'),(18,19,NULL,NULL,'cash',60,'2022-06-24','Self-Service','0','0'),(19,20,NULL,NULL,'cash',400,'2022-06-24','Self-Service','0','0'),(20,21,NULL,NULL,'cash',20,'2022-06-24','Self-Service','0','0'),(21,22,NULL,NULL,'cash',40,'2022-06-24','Self-Service','0','0'),(22,23,NULL,NULL,'cash',1800,'2022-06-24','Self-Service','0','0'),(23,24,NULL,NULL,'cash',60,'2022-06-24','Self-Service','0','0'),(24,25,NULL,NULL,'cash',400,'2022-06-28','Self-Service','0','0'),(25,26,NULL,NULL,'cash',40,'2022-06-28','Self-Service','0','1'),(26,27,NULL,NULL,'cash',40,'2022-06-28','Self-Service','0','0'),(27,28,NULL,NULL,'cash',100,'2022-06-29','Self-Service','0','0'),(28,29,NULL,NULL,'cash',3040,'2022-06-29','Self-Service','1','0'),(29,30,16,NULL,'cash',40,'2022-06-29','Local Shipping','0','0'),(30,31,17,10,'cash',400,'2022-06-29','Local Shipping','0','0'),(31,32,18,11,'cash',20,'2022-06-29','Local Shipping','0','0'),(32,33,NULL,NULL,'cash',20,'2022-06-29','Self-Service','0','0');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productlist`
--

DROP TABLE IF EXISTS `productlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productlist` (
  `productID` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `price` double NOT NULL,
  `fromDate` date NOT NULL,
  PRIMARY KEY (`productID`)
) ENGINE=InnoDB AUTO_INCREMENT=1004 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productlist`
--

LOCK TABLES `productlist` WRITE;
/*!40000 ALTER TABLE `productlist` DISABLE KEYS */;
INSERT INTO `productlist` VALUES (1000,'A',20,'2022-06-05'),(1001,'B',40,'2022-06-05'),(1002,'C',60,'2022-06-05'),(1003,'D',80,'2022-06-05');
/*!40000 ALTER TABLE `productlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receipt`
--

DROP TABLE IF EXISTS `receipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receipt` (
  `orderID` int NOT NULL,
  `productID` int NOT NULL,
  `qty` int NOT NULL,
  `shopID` int NOT NULL,
  PRIMARY KEY (`productID`,`qty`,`shopID`,`orderID`),
  KEY `FKreceipt123_idx` (`productID`),
  KEY `FKreceipt1_idx` (`orderID`),
  CONSTRAINT `FKreceipt1` FOREIGN KEY (`orderID`) REFERENCES `order` (`orderID`),
  CONSTRAINT `FKreceipt123` FOREIGN KEY (`productID`) REFERENCES `productlist` (`productID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipt`
--

LOCK TABLES `receipt` WRITE;
/*!40000 ALTER TABLE `receipt` DISABLE KEYS */;
INSERT INTO `receipt` VALUES (2,1000,1,1),(4,1000,1,1),(5,1000,1,1),(7,1000,1,1),(8,1000,1,1),(9,1000,1,1),(10,1000,1,1),(11,1000,1,1),(12,1000,1,1),(13,1000,1,1),(14,1000,1,1),(15,1000,1,1),(20,1000,1,1),(31,1000,1,1),(32,1000,1,1),(3,1000,20,1),(6,1000,20,1),(19,1000,20,1),(24,1000,20,1),(30,1000,20,1),(1,1001,1,1),(18,1001,1,1),(21,1001,1,1),(25,1001,1,1),(26,1001,1,1),(27,1001,1,1),(28,1001,1,1),(29,1001,1,1),(3,1001,20,1),(6,1001,20,1),(23,1002,1,1),(27,1002,1,1),(6,1002,20,1),(16,1002,30,1),(22,1002,30,1),(17,1002,50,1),(28,1002,50,1),(18,1003,1,1),(6,1003,20,1);
/*!40000 ALTER TABLE `receipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restockretailproduct`
--

DROP TABLE IF EXISTS `restockretailproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restockretailproduct` (
  `shopID` int NOT NULL,
  `warehouseID` int NOT NULL,
  `productID` int NOT NULL,
  `qty` int NOT NULL,
  `Date` datetime NOT NULL,
  `Status` varchar(1) DEFAULT '0',
  PRIMARY KEY (`shopID`,`warehouseID`,`productID`,`qty`,`Date`),
  KEY `FKrestockPro125910` (`productID`),
  CONSTRAINT `FKrestockPro125910` FOREIGN KEY (`productID`) REFERENCES `productlist` (`productID`),
  CONSTRAINT `FKrestockPro555458` FOREIGN KEY (`shopID`) REFERENCES `retailstore` (`shopID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restockretailproduct`
--

LOCK TABLES `restockretailproduct` WRITE;
/*!40000 ALTER TABLE `restockretailproduct` DISABLE KEYS */;
INSERT INTO `restockretailproduct` VALUES (1,1,1000,20,'2022-06-22 06:15:34','1'),(1,1,1000,122,'2022-06-22 06:42:28','1'),(1,1,1000,299,'2022-06-22 06:38:22','1'),(1,1,1001,1,'2022-06-29 01:35:31',NULL),(1,1,1001,122,'2022-06-22 06:42:28','1'),(1,1,1001,500,'2022-06-13 03:50:59','1'),(1,1,1001,500,'2022-06-26 21:10:53','0'),(1,1,1002,100,'2022-06-28 22:19:12','1'),(1,1,1002,122,'2022-06-22 06:42:28','1'),(1,1,1002,299,'2022-06-22 06:38:22','1'),(1,1,1002,500,'2022-06-26 21:10:53','0'),(1,1,1003,100,'2022-06-28 22:19:12','1'),(1,1,1003,122,'2022-06-22 06:42:28','1'),(1,1,1003,299,'2022-06-22 06:38:22','1'),(1,1,1003,500,'2022-06-13 03:50:59','1');
/*!40000 ALTER TABLE `restockretailproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restockwarehousestock`
--

DROP TABLE IF EXISTS `restockwarehousestock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restockwarehousestock` (
  `warehouseID` int NOT NULL,
  `supplierID` int NOT NULL,
  `productID` int NOT NULL,
  `qty` int NOT NULL,
  `Date` datetime NOT NULL,
  PRIMARY KEY (`warehouseID`,`supplierID`,`productID`,`qty`,`Date`),
  KEY `FKproduct_idx` (`productID`),
  KEY `FKsupplier_idx` (`supplierID`),
  KEY `FKwarehouse_idx` (`warehouseID`),
  CONSTRAINT `FKproduct_restock` FOREIGN KEY (`productID`) REFERENCES `productlist` (`productID`),
  CONSTRAINT `FKsupplier_restock` FOREIGN KEY (`supplierID`) REFERENCES `supplier` (`SupplierID`),
  CONSTRAINT `FKwarehouse_restock` FOREIGN KEY (`warehouseID`) REFERENCES `warehouse` (`warehouseID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restockwarehousestock`
--

LOCK TABLES `restockwarehousestock` WRITE;
/*!40000 ALTER TABLE `restockwarehousestock` DISABLE KEYS */;
INSERT INTO `restockwarehousestock` VALUES (1,2000,1002,20,'2022-06-22 06:13:51'),(1,2000,1002,134,'2022-06-06 10:15:40'),(1,2000,1003,134,'2022-06-06 10:15:39');
/*!40000 ALTER TABLE `restockwarehousestock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retailstore`
--

DROP TABLE IF EXISTS `retailstore`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `retailstore` (
  `shopID` int NOT NULL AUTO_INCREMENT,
  `address` varchar(255) NOT NULL,
  `phone` int NOT NULL,
  PRIMARY KEY (`shopID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retailstore`
--

LOCK TABLES `retailstore` WRITE;
/*!40000 ALTER TABLE `retailstore` DISABLE KEYS */;
INSERT INTO `retailstore` VALUES (1,'Kowloon Bay',77778888),(2,'Tsuen Wan',88889999);
/*!40000 ALTER TABLE `retailstore` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retailstorestock`
--

DROP TABLE IF EXISTS `retailstorestock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `retailstorestock` (
  `RproductID` int NOT NULL AUTO_INCREMENT,
  `shopID` int NOT NULL,
  `qty` int NOT NULL,
  `restockPoint` int DEFAULT NULL,
  PRIMARY KEY (`RproductID`,`shopID`),
  KEY `FKretailStor74088` (`shopID`),
  CONSTRAINT `FKproduct` FOREIGN KEY (`RproductID`) REFERENCES `productlist` (`productID`),
  CONSTRAINT `FKretailStor74088` FOREIGN KEY (`shopID`) REFERENCES `retailstore` (`shopID`)
) ENGINE=InnoDB AUTO_INCREMENT=1004 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retailstorestock`
--

LOCK TABLES `retailstorestock` WRITE;
/*!40000 ALTER TABLE `retailstorestock` DISABLE KEYS */;
INSERT INTO `retailstorestock` VALUES (1000,1,2519,122),(1001,1,4696,500),(1001,2,20,300),(1002,1,61,50),(1002,2,20,30),(1003,1,4353,50);
/*!40000 ALTER TABLE `retailstorestock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `staffID` int NOT NULL AUTO_INCREMENT,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `birthDate` date NOT NULL,
  `hireDate` date NOT NULL,
  `gender` char(1) NOT NULL,
  `departID` int NOT NULL,
  `titleID` int NOT NULL,
  `accessID` int DEFAULT NULL,
  PRIMARY KEY (`staffID`),
  UNIQUE KEY `staffID_UNIQUE` (`staffID`),
  KEY `FKStaffDepartment1_idx` (`departID`),
  KEY `FKStaffTitles1_idx` (`titleID`),
  KEY `FKStaffAccess1_idx` (`accessID`),
  CONSTRAINT `FKStaffAccess1` FOREIGN KEY (`accessID`) REFERENCES `access` (`AccessID`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `FKStaffDepartment1` FOREIGN KEY (`departID`) REFERENCES `department` (`departID`) ON UPDATE CASCADE,
  CONSTRAINT `FKStaffTitles1` FOREIGN KEY (`titleID`) REFERENCES `titles` (`titleID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Test','Manager','2011-01-05','2011-01-05','M',1,1,1),(2,'Test','IT','2011-01-05','2011-01-05','M',2,1,1),(3,'Test','Invertory','2022-06-29','2022-06-22','M',3,1,1),(4,'Test','Technical','2011-01-05','2011-01-05','M',4,1,1),(5,'Test','Purchase','2011-01-05','2011-01-05','M',5,1,1),(6,'Test','Accounting','2011-01-05','2011-01-05','M',6,1,3),(7,'Test','Sales','2011-01-05','2011-01-05','M',1,7,3),(8,'Alan','Wong','2011-01-05','2011-01-05','M',3,4,NULL),(9,'Justin','Chan','2011-01-05','2011-01-05','M',3,5,1),(10,'Installation','2','2011-01-05','2011-01-05','M',3,5,1),(11,'Harryss','James','2000-01-05','2000-01-05','F',2,7,NULL),(12,'111','1111','2022-06-28','2022-06-28','M',1,1,NULL),(13,'Test','Sales','2000-01-05','2000-01-05','F',1,1,3),(14,'Esther','Esthee','2022-06-28','2022-06-28','M',1,1,NULL),(15,'as','as','2022-06-28','2022-06-28','M',1,1,NULL),(18,'hehe','kdiaobao','2022-06-28','2022-06-28','M',1,1,NULL);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `SupplierID` int NOT NULL,
  `SuppliernnName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (2000,'AAA');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `titles`
--

DROP TABLE IF EXISTS `titles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `titles` (
  `titleID` int NOT NULL,
  `title` varchar(50) NOT NULL,
  PRIMARY KEY (`titleID`),
  UNIQUE KEY `titleID_UNIQUE` (`titleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `titles`
--

LOCK TABLES `titles` WRITE;
/*!40000 ALTER TABLE `titles` DISABLE KEYS */;
INSERT INTO `titles` VALUES (1,'Manager'),(2,'Clerk'),(3,'CEO'),(4,'DeliveryMan'),(5,'InstalltionMan'),(7,'Sales');
/*!40000 ALTER TABLE `titles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouse`
--

DROP TABLE IF EXISTS `warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehouse` (
  `warehouseID` int NOT NULL AUTO_INCREMENT,
  `address` varchar(255) NOT NULL,
  `phone` int NOT NULL,
  PRIMARY KEY (`warehouseID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse`
--

LOCK TABLES `warehouse` WRITE;
/*!40000 ALTER TABLE `warehouse` DISABLE KEYS */;
INSERT INTO `warehouse` VALUES (1,'Kowloon Bay',11112222),(2,'Wakada',22223333);
/*!40000 ALTER TABLE `warehouse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehousestock`
--

DROP TABLE IF EXISTS `warehousestock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehousestock` (
  `WproductID` int NOT NULL,
  `warehouseID` int NOT NULL,
  `qty` int NOT NULL,
  `reorderPoint` int DEFAULT NULL,
  PRIMARY KEY (`WproductID`,`warehouseID`),
  KEY `FKwarehouseS377978` (`warehouseID`),
  CONSTRAINT `FKproductlist1` FOREIGN KEY (`WproductID`) REFERENCES `productlist` (`productID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FKwarehouseS377978` FOREIGN KEY (`warehouseID`) REFERENCES `warehouse` (`warehouseID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehousestock`
--

LOCK TABLES `warehousestock` WRITE;
/*!40000 ALTER TABLE `warehousestock` DISABLE KEYS */;
INSERT INTO `warehousestock` VALUES (1000,1,500,10000000),(1000,2,30,50),(1001,1,500,200),(1001,2,30,20),(1002,1,634,50),(1003,1,634,50);
/*!40000 ALTER TABLE `warehousestock` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-29 12:53:31
