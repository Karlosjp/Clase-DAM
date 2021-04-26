DROP DATABASE IF EXISTS Ejercicio1;

CREATE DATABASE Ejercicio1;

USE Ejercicio1;

CREATE TABLE Periodista(
    dni CHAR (9) PRIMARY KEY,
    nombre VARCHAR (20) NOT NULL,
    direccion VARCHAR (50),
    telefono VARCHAR (12),
    especialista VARCHAR (20)
);

CREATE TABLE Sucursal (
    codigo SMALLINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    direccion VARCHAR (50),
    telefono VARCHAR (12)
);

CREATE TABLE Empleado (
    dni CHAR (9) PRIMARY KEY,
    nombre VARCHAR (20) NOT NULL,
    direccion VARCHAR (50),
    telefono VARCHAR (12),
    sucursal SMALLINT UNSIGNED,

    FOREIGN KEY (sucursal) REFERENCES Sucursal (codigo)
);

CREATE TABLE Revista(
    numreg SMALLINT UNSIGNED PRIMARY KEY,
    titulo VARCHAR (30) NOT NULL,
    periodicidad ENUM("Semanal", "Quincenal", "Mensual", "Trimestral", "Anual") DEFAULT "Mensual",
    tipo VARCHAR (10),
    sucursal SMALLINT UNSIGNED,

    FOREIGN KEY (sucursal) REFERENCES Sucursal (codigo)
);

CREATE TABLE Escribe(
    numreg SMALLINT UNSIGNED,
    dni_per CHAR (9),

    PRIMARY KEY (numreg, dni_per),
    FOREIGN KEY (numreg) REFERENCES Revista (numreg),
    FOREIGN KEY (dni_per) REFERENCES Periodista (dni)
);

CREATE TABLE NumRevista(
    numreg SMALLINT UNSIGNED,
    numero SMALLINT UNSIGNED,
    numpaginas SMALLINT UNSIGNED CHECK (numpaginas > 0),
    fecha DATE,
    cantvendidas SMALLINT UNSIGNED,
    
    PRIMARY KEY (numreg, numero),
    FOREIGN KEY (numreg) REFERENCES Revista (numreg)
);