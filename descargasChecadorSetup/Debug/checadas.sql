/*
Navicat MySQL Data Transfer

Target Server Type    : MYSQL
Target Server Version : 50552
File Encoding         : 65001

Date: 2017-04-25 08:22:32
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for bitacora_horarios
-- ----------------------------
DROP TABLE IF EXISTS `bitacora_horarios`;
CREATE TABLE `bitacora_horarios` (
  `id_interno` int(10) NOT NULL,
  `id_horario` int(10) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_interno`,`id_horario`,`fecha`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Table structure for checadas
-- ----------------------------
DROP TABLE IF EXISTS `checadas`;
CREATE TABLE `checadas` (
  `id_interno` int(5) NOT NULL,
  `fecha_hora` datetime NOT NULL,
  `clave_concepto` char(3) DEFAULT NULL,
  `no_checador` tinyint(3) unsigned DEFAULT NULL,
  PRIMARY KEY (`id_interno`,`fecha_hora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Table structure for conceptos
-- ----------------------------
DROP TABLE IF EXISTS `conceptos`;
CREATE TABLE `conceptos` (
  `clave` char(3) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`clave`),
  UNIQUE KEY `clave_UNIQUE` (`clave`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for departamentos
-- ----------------------------
DROP TABLE IF EXISTS `departamentos`;
CREATE TABLE `departamentos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `status` bit(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for dias_inhabiles
-- ----------------------------
DROP TABLE IF EXISTS `dias_inhabiles`;
CREATE TABLE `dias_inhabiles` (
  `id_dia_inhabil` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `motivo` varchar(50) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_dia_inhabil`,`fecha`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for empleados
-- ----------------------------
DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `id_interno` int(5) NOT NULL,
  `id_depto` int(2) DEFAULT NULL,
  `nombre` char(100) NOT NULL,
  `activado` int(1) NOT NULL,
  `variado` int(1) NOT NULL,
  PRIMARY KEY (`id_interno`),
  UNIQUE KEY `id_interno` (`id_interno`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Table structure for empleados_dias_inhabiles
-- ----------------------------
DROP TABLE IF EXISTS `empleados_dias_inhabiles`;
CREATE TABLE `empleados_dias_inhabiles` (
  `id_interno` int(11) NOT NULL,
  `id_dia_inhabil` int(11) NOT NULL,
  PRIMARY KEY (`id_interno`,`id_dia_inhabil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=FIXED;

-- ----------------------------
-- Table structure for empleados_horarios
-- ----------------------------
DROP TABLE IF EXISTS `empleados_horarios`;
CREATE TABLE `empleados_horarios` (
  `id_empleado` int(11) NOT NULL,
  `id_horario` int(11) NOT NULL,
  `vigencia_inicio` date NOT NULL,
  `vigencia_fin` date NOT NULL,
  `prioridad` int(11) NOT NULL,
  PRIMARY KEY (`id_empleado`,`id_horario`,`vigencia_inicio`,`vigencia_fin`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=FIXED;

-- ----------------------------
-- Table structure for horarios
-- ----------------------------
DROP TABLE IF EXISTS `horarios`;
CREATE TABLE `horarios` (
  `id_horario` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) NOT NULL,
  `activo` bit(1) NOT NULL DEFAULT b'1',
  `dia_siguiente` bit(1) NOT NULL DEFAULT b'0' COMMENT 'Cuando activado, el empleado checa salida al dia siguiente.',
  `dias_que_aplica` char(7) NOT NULL,
  `dias_que_no_aplica` char(7) NOT NULL,
  `fecha_actualizacion` datetime NOT NULL,
  PRIMARY KEY (`id_horario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Table structure for horarios_detalles
-- ----------------------------
DROP TABLE IF EXISTS `horarios_detalles`;
CREATE TABLE `horarios_detalles` (
  `id_detalle` int(11) NOT NULL,
  `id_horario` int(11) NOT NULL,
  `clave_concepto` char(3) NOT NULL,
  `hora_minima` time NOT NULL,
  `hora_checada` time DEFAULT NULL,
  `hora_maxima` time NOT NULL,
  PRIMARY KEY (`id_detalle`,`id_horario`,`clave_concepto`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=FIXED;

-- ----------------------------
-- Table structure for justificaciones
-- ----------------------------
DROP TABLE IF EXISTS `justificaciones`;
CREATE TABLE `justificaciones` (
  `id_justificacion` int(11) NOT NULL AUTO_INCREMENT,
  `id_interno` int(5) NOT NULL,
  `fecha_hora` datetime NOT NULL,
  `detalle` text NOT NULL,
  `clave_concepto` char(3) NOT NULL,
  `autorizado_por` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_justificacion`),
  UNIQUE KEY `id_justicicacion_UNIQUE` (`id_justificacion`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;


-- ----------------------------
-- CONCEPTOS
-- ----------------------------
INSERT INTO conceptos (clave, descripcion) VALUES ('TD', 'Termina Descanso');
INSERT INTO conceptos (clave, descripcion) VALUES ('INV', 'Invalida');
INSERT INTO conceptos (clave, descripcion) VALUES ('DE', 'Descanso');
INSERT INTO conceptos (clave, descripcion) VALUES ('ST', 'Salida de Turno');
INSERT INTO conceptos (clave, descripcion) VALUES ('ID', 'Inicia Descanso');
INSERT INTO conceptos (clave, descripcion) VALUES ('ET', 'Entrada de Turno');

-- ----------------------------
-- DEPARTAMENTOS
-- ----------------------------
INSERT INTO departamentos (nombre, status) VALUES ('GENERAL', b'1');