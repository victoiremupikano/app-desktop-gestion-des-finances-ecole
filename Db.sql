CREATE DATABASE  IF NOT EXISTS `finance_manager_dev` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `finance_manager_dev`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: finance_manager_dev
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `account_id` int NOT NULL AUTO_INCREMENT,
  `wording` varchar(255) DEFAULT NULL,
  `fk_student` int DEFAULT NULL,
  `fk_trimestry` int DEFAULT NULL,
  `fk_year` int DEFAULT NULL,
  `fk_user` int DEFAULT NULL,
  `row_add` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `row_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`account_id`)
) ENGINE=InnoDB AUTO_INCREMENT=90360624 DEFAULT CHARSET=utf8mb3 AVG_ROW_LENGTH=228;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (90360622,'Premier trimestre',90360623,90360622,110,4,'2023-08-22 07:32:55','2023-08-22 07:32:55'),(90360623,'Premier trimestre',90360622,90360622,110,4,'2023-08-22 07:32:55','2023-08-22 07:32:55');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `payment_id` int NOT NULL AUTO_INCREMENT,
  `wording` varchar(255) DEFAULT NULL,
  `mt_payed` decimal(13,4) DEFAULT NULL,
  `fk_account` int DEFAULT NULL,
  `fk_year` int DEFAULT NULL,
  `fk_user` int DEFAULT NULL,
  `row_add` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `row_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`payment_id`)
) ENGINE=InnoDB AUTO_INCREMENT=90360626 DEFAULT CHARSET=utf8mb3 AVG_ROW_LENGTH=228;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (90360622,'-',5.0000,90360622,110,4,'2023-08-22 15:31:06','2023-08-22 15:31:06'),(90360623,'-',5.0000,90360622,110,4,'2023-08-22 15:44:27','2023-08-22 15:44:27'),(90360624,'-',31.0000,90360622,110,4,'2023-08-22 15:59:02','2023-08-22 15:59:02'),(90360625,'-',9.0000,90360622,110,4,'2023-08-22 15:59:29','2023-08-22 15:59:29');
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `student_id` int NOT NULL AUTO_INCREMENT,
  `names` varchar(255) DEFAULT NULL,
  `kind` varchar(255) DEFAULT NULL,
  `birthday` varchar(255) DEFAULT NULL,
  `children_father` varchar(255) DEFAULT NULL,
  `children_mather` varchar(255) DEFAULT NULL,
  `religin` varchar(255) DEFAULT NULL,
  `adress` varchar(255) DEFAULT NULL,
  `tel` varchar(255) DEFAULT NULL,
  `level` varchar(255) DEFAULT NULL,
  `fk_year` int DEFAULT NULL,
  `fk_user` int DEFAULT NULL,
  `row_add` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `row_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`student_id`),
  KEY `fk1_idx` (`fk_year`)
) ENGINE=InnoDB AUTO_INCREMENT=90360624 DEFAULT CHARSET=utf8mb3 AVG_ROW_LENGTH=228;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (90360622,'Kasereka Ushindi Viki','Masculin','2023-08-22','Mupikano','Kangitsi','Chretienne','Butembo','0989876678','7',110,4,'2023-08-22 03:29:14','2023-08-22 03:35:26'),(90360623,'Kambale Mgenge Dalzon','Masculin','2023-08-22','Mupikano','Kangitsi','Chretienne','Butembo','0989887767','8',110,4,'2023-08-22 03:36:15','2023-08-22 03:36:15');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trimestry`
--

DROP TABLE IF EXISTS `trimestry`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trimestry` (
  `trimestry_id` int NOT NULL AUTO_INCREMENT,
  `wording` varchar(255) DEFAULT NULL,
  `mt_to_pay` decimal(13,4) DEFAULT NULL,
  `fk_year` int DEFAULT NULL,
  `fk_user` int DEFAULT NULL,
  `row_add` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `row_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`trimestry_id`)
) ENGINE=InnoDB AUTO_INCREMENT=90360624 DEFAULT CHARSET=utf8mb3 AVG_ROW_LENGTH=228;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trimestry`
--

LOCK TABLES `trimestry` WRITE;
/*!40000 ALTER TABLE `trimestry` DISABLE KEYS */;
INSERT INTO `trimestry` VALUES (90360622,'Premier trimestre',50.0000,110,4,'2023-08-21 18:52:45','2023-08-21 18:52:45'),(90360623,'Deuxieme trimestre',50.0000,110,4,'2023-08-21 18:53:30','2023-08-21 18:53:30');
/*!40000 ALTER TABLE `trimestry` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `login` varchar(45) DEFAULT NULL,
  `password` longtext,
  `row_add` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `row_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (4,'dev','4E-98-34-7D-B5-C3-2C-B1-0E-88-91-E6-B3-08-94-23-92-D8-3E-26','2023-04-18 13:39:43','2023-08-21 16:00:51');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `year`
--

DROP TABLE IF EXISTS `year`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `year` (
  `year_id` int NOT NULL AUTO_INCREMENT,
  `wording` varchar(255) DEFAULT NULL,
  `dteStart` date DEFAULT NULL,
  `dteEnd` date DEFAULT NULL,
  `status` varchar(5) DEFAULT NULL,
  `fk_user` int DEFAULT NULL,
  `row_add` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `row_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`year_id`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=utf8mb3 AVG_ROW_LENGTH=150;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `year`
--

LOCK TABLES `year` WRITE;
/*!40000 ALTER TABLE `year` DISABLE KEYS */;
INSERT INTO `year` VALUES (110,'Annee scalaire 2022-2023','2023-08-21','2024-01-11','True',4,'2023-08-21 16:02:01','2023-08-21 16:02:01');
/*!40000 ALTER TABLE `year` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-23  8:25:31
