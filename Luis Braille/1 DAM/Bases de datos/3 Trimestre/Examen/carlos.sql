-- MySQL dump 10.13  Distrib 8.0.23, for Linux (x86_64)
--
-- Host: localhost    Database: bdtrim3carlos
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `idemp` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  `direccion` text,
  `nivel` text,
  PRIMARY KEY (`idemp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `idpedido` varchar(10) NOT NULL,
  `codfabricante` int unsigned NOT NULL,
  `peso` smallint NOT NULL,
  `fecha_pedido` date NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `articulo` varchar(50) NOT NULL,
  `unidades_pedidas` int unsigned DEFAULT NULL,
  `descuentos` enum('5%','10%','15%') DEFAULT NULL,
  PRIMARY KEY (`idpedido`,`codfabricante`,`peso`,`fecha_pedido`,`categoria`,`articulo`),
  KEY `articulo` (`articulo`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`idpedido`) REFERENCES `tiendas` (`idtienda`),
  CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`articulo`) REFERENCES `productos` (`codprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `codprod` varchar(50) NOT NULL,
  `codprov` int unsigned DEFAULT NULL,
  `categoria` varchar(50) NOT NULL,
  `peso` float(10,2) DEFAULT NULL,
  `precio_coste` decimal(10,2) DEFAULT NULL,
  `ndisp` bigint DEFAULT NULL,
  `precio_venta` decimal(10,2) DEFAULT NULL,
  `dimensiones` enum('10','20','30') DEFAULT (10),
  `descontinuado` tinyint(1) DEFAULT NULL,
  `distancia` float(7,3) DEFAULT NULL,
  PRIMARY KEY (`codprod`,`categoria`),
  KEY `codprov` (`codprov`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`codprov`) REFERENCES `proveedores` (`idprov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedores` (
  `idprov` int unsigned NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `pais` varchar(40) DEFAULT NULL,
  `web` enum('web1.com','web2.com') DEFAULT NULL,
  `idprovp` int unsigned DEFAULT NULL,
  `tipoprov` enum('asia','ue','emea','latam') DEFAULT (_utf8mb4'asia'),
  PRIMARY KEY (`idprov`),
  UNIQUE KEY `nombre` (`nombre`,`pais`),
  KEY `idprovp` (`idprovp`),
  CONSTRAINT `proveedores_ibfk_1` FOREIGN KEY (`idprovp`) REFERENCES `proveedores` (`idprov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiendas`
--

DROP TABLE IF EXISTS `tiendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiendas` (
  `idtienda` varchar(10) NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `ciudad` varchar(50) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `codpostal` int DEFAULT NULL,
  `idemp` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idtienda`),
  UNIQUE KEY `nombre` (`nombre`,`provincia`),
  KEY `idemp` (`idemp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiendas`
--

LOCK TABLES `tiendas` WRITE;
/*!40000 ALTER TABLE `tiendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `idventa` int unsigned NOT NULL,
  `nart` varchar(50) NOT NULL,
  `codfab` int unsigned NOT NULL,
  `peso` smallint NOT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  `fecha_venta` date DEFAULT NULL,
  `unidades_vendidas` int DEFAULT NULL,
  `grupo` enum('a','b','c') NOT NULL,
  PRIMARY KEY (`idventa`,`nart`,`codfab`,`peso`),
  KEY `nart` (`nart`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`idventa`) REFERENCES `proveedores` (`idprov`),
  CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`nart`) REFERENCES `productos` (`codprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-25 10:44:27
