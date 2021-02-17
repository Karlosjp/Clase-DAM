DROP DATABASE IF EXISTS GESTION_ENVIOS;

CREATE DATABASE GESTION_ENVIOS;

USE GESTION_ENVIOS;

CREATE TABLE PROVEEDORES
( CPROV     CHAR(3) PRIMARY KEY,
  NOMBRE    CHAR(15) NOT NULL,
  SITUACION SMALLINT,
  CIUDAD    CHAR(20) );

CREATE TABLE PIEZAS
( CPIEZA    CHAR(3) PRIMARY KEY,
  NOMBRE    CHAR(15) NOT NULL,
  COLOR     CHAR(10),
  PESO      SMALLINT,
  CIUDAD    CHAR(20) );

CREATE TABLE PROYECTOS
( CPROY     CHAR(3) PRIMARY KEY,
  NOMBRE    CHAR(15) NOT NULL,
  CIUDAD    CHAR(20) );

CREATE TABLE ENVIOS
( CPROV     CHAR(3) NOT NULL,
  CPIEZA    CHAR(3) NOT NULL,
  CPROY     CHAR(3) NOT NULL,
  CANT      INTEGER NOT NULL,
  PRIMARY KEY(CPROV,CPIEZA,CPROY,CANT),
  FOREIGN KEY(CPROV) REFERENCES PROVEEDORES (CPROV),
  FOREIGN KEY(CPIEZA) REFERENCES PIEZAS (CPIEZA),
  FOREIGN KEY(CPROY) REFERENCES PROYECTOS (CPROY) );


INSERT into PROVEEDORES VALUES
	('S1','Maria',20,'Londres'),
	('S2','Juan',10,'Paris'),
	('S3','Carlos',30,'Paris'),
	('S4','Pedro',20,'Londres'),
	('S5','Jesus',30,'Atenas');


INSERT into PIEZAS VALUES
	('P1','Tuerca','Rojo',12,'Londres'),
	('P2','Tornillo','Verde',17,'Paris'),
	('P3','Arandela','Azul',17,'Roma'),
	('P4','Arandela','Rojo',14,'Londres'),
	('P5','Cinta','Azul',12,'Paris'),
	('P6','Abrazadera','Rojo',19,'Londres');


INSERT into PROYECTOS VALUES
	('J1','Impresora','Paris'),
	('J2','CD','Roma'),
	('J3','DVD','Atenas'),
	('J4','Terminal','Atenas'),
	('J5','Teclado','Londres'),
	('J6','Modem','Oslo'),
	('J7','Raton','Londres');


INSERT into ENVIOS VALUES
	('S1','P1','J1',200),
	('S1','P1','J2',700),
	('S2','P3','J3',400),
	('S2','P3','J3',200),
	('S2','P3','J3',100),
	('S2','P3','J3',500),
	('S2','P3','J3',600),
	('S2','P3','J3',300),
	('S2','P3','J3',800),
	('S2','P5','J3',100),
	('S3','P3','J3',700),
	('S3','P4','J4',500),
	('S4','P6','J5',300),
	('S4','P6','J6',300),
	('S5','P2','J7',200),
	('S5','P2','J3',100),
	('S5','P5','J3',500),
	('S5','P5','J3',100),
	('S5','P5','J4',100),
	('S5','P1','J3',100),
	('S5','P3','J3',900),
	('S5','P4','J3',800),
	('S5','P5','J3',400),
	('S5','P6','J3',500);
