-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.24-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para SMI_Proyecto
CREATE DATABASE IF NOT EXISTS `smi_proyecto` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `SMI_Proyecto`;

-- Volcando estructura para tabla SMI_Proyecto.dispositivo
CREATE TABLE IF NOT EXISTS `dispositivo` (
  `IdDispositivo` int(11) NOT NULL,
  `NombreDispositivo` varchar(50) DEFAULT NULL,
  `DescripcionDispositivo` varchar(100) DEFAULT NULL,
  `ConsumoDispositivo` double DEFAULT NULL,
  `EstadoDispositivo` int(11) DEFAULT NULL,
  `fkIdUsuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdDispositivo`),
  KEY `fkIdUsuario` (`fkIdUsuario`),
  CONSTRAINT `fkIdUsuario` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`IdUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla SMI_Proyecto.dispositivo: ~0 rows (aproximadamente)

-- Volcando estructura para tabla SMI_Proyecto.lectura
CREATE TABLE IF NOT EXISTS `lectura` (
  `IdLectura` int(11) NOT NULL,
  `Fecha_hora` datetime DEFAULT NULL,
  `fkIdDispositivo` int(11) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  PRIMARY KEY (`IdLectura`),
  KEY `fkIdDispositivo` (`fkIdDispositivo`),
  CONSTRAINT `fkIdDispositivo` FOREIGN KEY (`fkIdDispositivo`) REFERENCES `dispositivo` (`IdDispositivo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla SMI_Proyecto.lectura: ~0 rows (aproximadamente)

-- Volcando estructura para tabla SMI_Proyecto.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `EmailUsuario` varchar(20) NOT NULL,
  `ClaveUsuario` varchar(20) NOT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla SMI_Proyecto.usuario: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
