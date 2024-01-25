-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: pruebalubee_db
-- ------------------------------------------------------
-- Server version	8.2.0

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
-- Table structure for table `detallecontrato`
--

DROP TABLE IF EXISTS `detallecontrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallecontrato` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ContratoId` int NOT NULL,
  `ItemId` int NOT NULL,
  `CreateDate` datetime(6) NOT NULL,
  `UpdateDate` datetime(6) NOT NULL,
  `Enabled` tinyint(1) NOT NULL,
  `Deleted` tinyint(1) NOT NULL,
  `CreateBy` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_DetalleContrato_ContratoId` (`ContratoId`),
  KEY `IX_DetalleContrato_ItemId` (`ItemId`),
  CONSTRAINT `FK_DetalleContrato_Contrato_ContratoId` FOREIGN KEY (`ContratoId`) REFERENCES `contrato` (`Id`) ON DELETE RESTRICT,
  CONSTRAINT `FK_DetalleContrato_Producto_ItemId` FOREIGN KEY (`ItemId`) REFERENCES `producto` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecontrato`
--

LOCK TABLES `detallecontrato` WRITE;
/*!40000 ALTER TABLE `detallecontrato` DISABLE KEYS */;
INSERT INTO `detallecontrato` VALUES (1,1,1,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario1'),(2,1,2,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario1'),(3,2,3,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario2'),(4,2,4,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario2'),(5,3,5,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario3'),(6,3,6,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario3'),(7,4,7,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario4'),(8,4,8,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario4'),(9,5,9,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario5'),(10,5,10,'2024-01-25 10:31:04.000000','2024-01-25 10:31:04.000000',1,0,'Usuario5');
/*!40000 ALTER TABLE `detallecontrato` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-25 12:15:57
