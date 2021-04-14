DROP DATABASE IF EXISTS EjercicioE;

CREATE DATABASE EjercicioE;

USE EjercicioE;

CREATE TABLE empleado (
    ID INT,
    dni CHAR (9),
    nombre VARCHAR(20),
    fechanac DATE,
    telefono CHAR (9),
    salario INTEGER,
    codlocalidad CHAR (5)
);

CREATE TABLE localidad (
    codlocalidad CHAR (5),
    nombre VARCHAR (20),
    codprivincia CHAR (5)
);

CREATE TABLE provincia (
    codprivincia CHAR (5),
    nombre VARCHAR(20),
    codregion CHAR (5)
);

CREATE TABLE region (
    codregion CHAR (5),
    nombre VARCHAR(20)
);

ALTER TABLE empleado MODIFY ID INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY;
ALTER TABLE localidad MODIFY codlocalidad CHAR (5) PRIMARY KEY;
ALTER TABLE provincia MODIFY codprivincia CHAR (5) PRIMARY KEY;
ALTER TABLE region MODIFY codregion CHAR (5) PRIMARY KEY;
ALTER TABLE empleado MODIFY dni CHAR (9) UNIQUE;
ALTER TABLE empleado ADD FOREIGN KEY (codlocalidad) REFERENCES localidad (codlocalidad);
ALTER TABLE localidad ADD FOREIGN KEY (codprivincia) REFERENCES provincia (codprivincia);
ALTER TABLE provincia ADD FOREIGN KEY (codregion) REFERENCES region (codregion);

ALTER TABLE empleado DROP FOREIGN KEY empleado_ibfk_1;
ALTER TABLE localidad DROP FOREIGN KEY localidad_ibfk_1;
ALTER TABLE provincia DROP FOREIGN KEY provincia_ibfk_1;