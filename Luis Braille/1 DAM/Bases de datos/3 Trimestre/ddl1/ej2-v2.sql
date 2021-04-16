DROP DATABASE IF EXISTS Pubs2;

CREATE DATABASE Pubs2;

USE Pubs2;

CREATE TABLE localidad (
    cod_localidad SMALLINT UNSIGNED,
    nombre VARCHAR (20)
);

CREATE TABLE pub (
    cod_pub CHAR (5),
    nombre VARCHAR (20) NOT NULL,
    licencia_fiscal VARCHAR (20) NOT NULL,
    domicilio VARCHAR (30),
    fecha_apertura DATE NOT NULL,
    horario ENUM('HOR1', 'HOR2', 'HOR3'),
    cod_localidad SMALLINT UNSIGNED NOT NULL
);

CREATE TABLE titular (
    dni_titular CHAR (5),
    nombre VARCHAR (20) NOT NULL,
    domicilio VARCHAR (30),
    position VARCHAR (20) NOT NULL,
    cod_pub CHAR (5) NOT NULL
);

CREATE TABLE empleado (
    dni_empleado CHAR (5),
    nombre VARCHAR (20) NOT NULL,
    domicilio VARCHAR (30)
);

CREATE TABLE existencias (
    cod_articulo CHAR (5),
    nombre VARCHAR (20) NOT NULL,
    cantidad SMALLINT UNSIGNED NOT NULL,
    precio DECIMAL(7,2) NOT NULL,
    cod_pub CHAR (5) NOT NULL
);

CREATE TABLE pub_empleado (
    cod_pub CHAR (5) NOT NULL,
    dni_empleado CHAR (5) NOT NULL,
    funcion ENUM('CAMARERO', 'SEGURIDAD', 'LIMPIEZA')
);

ALTER TABLE pub_empleado ADD FOREIGN KEY (cod_pub) REFERENCES pub (cod_pub);
ALTER TABLE pub_empleado ADD FOREIGN KEY (dni_empleado) REFERENCES empleado (dni_empleado);
ALTER TABLE existencias ADD FOREIGN KEY (cod_pub) REFERENCES pub (cod_pub);
ALTER TABLE titular ADD FOREIGN KEY (cod_pub) REFERENCES pub (cod_pub);
ALTER TABLE pub ADD FOREIGN KEY (cod_localidad) REFERENCES localidad (cod_localidad);