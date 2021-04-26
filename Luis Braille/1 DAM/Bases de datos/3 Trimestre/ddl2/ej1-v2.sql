DROP DATABASE IF EXISTS Ejercicio1;

CREATE DATABASE Ejercicio1;

USE Ejercicio1;

CREATE TABLE Periodista(
    dni CHAR (9),
    nombre VARCHAR (20),
    direccion VARCHAR (50),
    telefono VARCHAR (12),
    especialista VARCHAR (20)
);

CREATE TABLE Sucursal (
    codigo SMALLINT UNSIGNED,
    direccion VARCHAR (50),
    telefono VARCHAR (12)
);

CREATE TABLE Empleado (
    dni CHAR (9),
    nombre VARCHAR (20),
    direccion VARCHAR (50),
    telefono VARCHAR (12),
    sucursal SMALLINT UNSIGNED
);

CREATE TABLE Revista(
    numreg SMALLINT UNSIGNED,
    titulo VARCHAR (30),
    periodicidad VARCHAR(30),
    tipo VARCHAR (10),
    sucursal SMALLINT UNSIGNED
);

CREATE TABLE Escribe(
    numreg SMALLINT UNSIGNED,
    dni_per CHAR (9)
);

CREATE TABLE NumRevista(
    numreg SMALLINT UNSIGNED,
    numero SMALLINT UNSIGNED,
    numpaginas SMALLINT UNSIGNED,
    fecha DATE,
    cantvendidas SMALLINT UNSIGNED
);

ALTER TABLE Periodista MODIFY nombre VARCHAR (20) NOT NULL;
ALTER TABLE Empleado MODIFY nombre VARCHAR (20) NOT NULL;
ALTER TABLE Revista MODIFY titulo VARCHAR (30) NOT NULL;
ALTER TABLE NumRevista MODIFY numpaginas SMALLINT UNSIGNED CHECK (numpaginas > 0);
ALTER TABLE Revista MODIFY periodicidad ENUM("Semanal", "Quincenal", "Mensual", "Trimestral", "Anual") DEFAULT "Mensual";
ALTER TABLE Sucursal MODIFY codigo SMALLINT UNSIGNED AUTO_INCREMENT PRIMARY KEY;

ALTER TABLE Periodista ADD PRIMARY KEY (dni);
ALTER TABLE Empleado ADD PRIMARY KEY (dni);
ALTER TABLE Revista ADD PRIMARY KEY (numreg);
ALTER TABLE Escribe ADD PRIMARY KEY (numreg, dni_per);
ALTER TABLE NumRevista ADD PRIMARY KEY (numreg, numero);

ALTER TABLE Empleado ADD FOREIGN KEY (sucursal) REFERENCES Sucursal (codigo);
ALTER TABLE Revista ADD FOREIGN KEY (sucursal) REFERENCES Sucursal (codigo);
ALTER TABLE NumRevista ADD FOREIGN KEY (numreg) REFERENCES Revista (numreg);
ALTER TABLE Escribe ADD FOREIGN KEY (numreg) REFERENCES Revista (numreg);
ALTER TABLE Escribe ADD FOREIGN KEY (dni_per) REFERENCES Periodista (dni);