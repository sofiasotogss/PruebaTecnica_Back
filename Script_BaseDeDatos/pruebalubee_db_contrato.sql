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
-- Table structure for table `contrato`
--

DROP TABLE IF EXISTS `contrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contrato` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CourseCode` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FechaAlta` datetime(6) NOT NULL,
  `Estado` tinyint(1) NOT NULL,
  `CantidadEgresados` int NOT NULL,
  `FechaEntrega` datetime(6) NOT NULL,
  `MedioEntrega` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Vendedor` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ColegioNivel` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ColegioNombre` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ColegioCurso` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ColegioLocalidad` varchar(250) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Comision` int NOT NULL,
  `Total` decimal(18,2) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contrato`
--

LOCK TABLES `contrato` WRITE;
/*!40000 ALTER TABLE `contrato` DISABLE KEYS */;
INSERT INTO `contrato` VALUES (1,'AAA001','2024-01-01 00:00:00.000000',1,50,'2024-02-15 00:00:00.000000','Presencial','VendedorA','Secundaria','ColegioA','2B','CiudadA',15,2500.75),(2,'BBB002','2024-02-01 00:00:00.000000',1,30,'2024-03-20 00:00:00.000000','Virtual','VendedorB','Primaria','ColegioB','3A','CiudadB',12,1800.25),(3,'CCC003','2024-03-01 00:00:00.000000',1,40,'2024-04-10 00:00:00.000000','Presencial','VendedorC','Secundaria','ColegioC','1A','CiudadC',20,3500.00),(4,'DDD004','2024-04-01 00:00:00.000000',1,25,'2024-05-15 00:00:00.000000','Virtual','VendedorD','Primaria','ColegioD','2A','CiudadD',18,2200.50),(5,'EEE005','2024-05-01 00:00:00.000000',1,35,'2024-06-20 00:00:00.000000','Presencial','VendedorE','Secundaria','ColegioE','3B','CiudadE',15,2800.75),(6,'FFF006','2024-06-01 00:00:00.000000',1,45,'2024-07-10 00:00:00.000000','Virtual','VendedorF','Primaria','ColegioF','1B','CiudadF',22,4000.25),(7,'GGG007','2024-07-01 00:00:00.000000',1,20,'2024-08-15 00:00:00.000000','Presencial','VendedorG','Secundaria','ColegioG','2C','CiudadG',14,1800.00),(8,'HHH008','2024-08-01 00:00:00.000000',1,28,'2024-09-20 00:00:00.000000','Virtual','VendedorH','Primaria','ColegioH','3C','CiudadH',20,3200.50),(9,'III009','2024-09-01 00:00:00.000000',1,38,'2024-10-10 00:00:00.000000','Presencial','VendedorI','Secundaria','ColegioI','1C','CiudadI',18,2700.75),(10,'JJJ010','2024-10-01 00:00:00.000000',1,42,'2024-11-15 00:00:00.000000','Virtual','VendedorJ','Primaria','ColegioJ','2D','CiudadJ',16,2000.25);
/*!40000 ALTER TABLE `contrato` ENABLE KEYS */;
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
