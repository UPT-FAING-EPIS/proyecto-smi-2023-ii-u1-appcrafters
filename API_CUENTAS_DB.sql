-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.24-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para dbcuentas
CREATE DATABASE IF NOT EXISTS `dbcuentas` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `dbcuentas`;

-- Volcando estructura para tabla dbcuentas.cuenta
CREATE TABLE IF NOT EXISTS `cuenta` (
  `correo` varchar(100) NOT NULL,
  `contraseña` varchar(100) DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `telefono` int(100) DEFAULT NULL,
  PRIMARY KEY (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla dbcuentas.cuenta: ~15 rows (aproximadamente)
/*!40000 ALTER TABLE `cuenta` DISABLE KEYS */;
INSERT INTO `cuenta` (`correo`, `contraseña`, `nombre`, `apellido`, `telefono`) VALUES
	('admin@gmail.com', '123', 'admin', 'admin', 123456789),
	('brenda@gmail.com', '156', 'brenda', 'quina', 156354279),
	('estrella@gmail.com', '159', 'estrella', 'miro', 159357486),
	('kid@gmail.com', '357', 'kid', 'rid', 357147258),
	('lobo@gmail.com', '248', 'lobo', 'torres', 248268259),
	('lucas@gmail.com', '369', 'lucas', 'almirante', 258147369),
	('lucia@gmai.com', '128', 'lucia', 'cruz', 128328458),
	('luna@gmail.com', '349', 'luna', 'mamani', 562389147),
	('maria@gmail.com', '258', 'maria', 'magdalena', 369258147),
	('max@gmail.com', '789', 'max', 'mad', 789132645),
	('pablo@gmail.com', '147', 'pablo', 'king', 147258369),
	('robin@gmail.com', '745', 'robin', 'wonder', 745965258),
	('sandro@gmail.com', '729', 'sandro', 'americo', 729381426),
	('sussie@gmail.com', '149', 'sussie', 'diaz', 149367258),
	('tyron@gmail.com', '456', 'tyron', 'baron', 456123987);
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
