			CREATE DATABASE IF NOT EXISTS `JuegoEducativo` 
			DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
			USE `JuegoEducativo`;
			
			CREATE TABLE IF NOT EXISTS `USUARIO` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `nombre` VARCHAR(50) NOT NULL,
			  `clave` VARCHAR(50) NOT NULL,
			  `rol` VARCHAR(20) NOT NULL, 
			  PRIMARY KEY (`id`)
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `MODULO` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `nombreEs` VARCHAR(100) NOT NULL,
			  `nombreEn` VARCHAR(100) NOT NULL,
			  `descripcion` VARCHAR(500) NOT NULL,
			  PRIMARY KEY (`id`)
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `PREGUNTA` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `idModulo` INT(11) NOT NULL,
			  `preguntaEs` TEXT NOT NULL,
			  `preguntaEn` TEXT NOT NULL,
			  `imagenRuta` VARCHAR(500) NOT NULL,
			  PRIMARY KEY (`id`),
			  FOREIGN KEY (`idModulo`) REFERENCES `MODULO`(`id`) ON DELETE CASCADE
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `OPCION` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `idPregunta` INT(11) NOT NULL,
			  `textoES` VARCHAR(500) NOT NULL,
			  `textoEn` VARCHAR(500) NOT NULL,
			  `esCorrecta` TINYINT(1) NOT NULL, 
			  PRIMARY KEY (`id`),
			  FOREIGN KEY (`idPregunta`) REFERENCES `PREGUNTA`(`id`) ON DELETE CASCADE
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `PUNTUACION` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `idUsuario` INT(11) NOT NULL,
			  `idModulo` INT(11) NOT NULL,
			  `puntos` INT(11) NOT NULL,
			  PRIMARY KEY (`id`),
			  FOREIGN KEY (`idUsuario`) REFERENCES `USUARIO`(`id`) ON DELETE CASCADE,
			  FOREIGN KEY (`idModulo`) REFERENCES `MODULO`(`id`) ON DELETE CASCADE
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



			INSERT IGNORE INTO MODULO (id, nombreEs, nombreEn, descripcion) VALUES (1, 'Arquitectura del computador', 'Computer Architecture', 'Hardware y componentes');
			INSERT IGNORE INTO MODULO (id, nombreEs, nombreEn, descripcion) VALUES (2, 'Antropología', 'Anthropology', 'Estudio del ser humano');
			INSERT IGNORE INTO MODULO (id, nombreEs, nombreEn, descripcion) VALUES (3, 'Cálculo', 'Calculus', 'Derivadas e integrales');
			INSERT IGNORE INTO MODULO (id, nombreEs, nombreEn, descripcion) VALUES (4, 'Deporte y primeros auxilios', 'Sports and First Aid', 'Actividad física y conocimientos básicos de emergencia');
