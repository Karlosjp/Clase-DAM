DROP DATABASE IF EXISTS Ejercicio2;

CREATE DATABASE Ejercicio2;

USE Ejercicio2;

CREATE TABLE Director(
    nombre VARCHAR (20) NOT NULL,
    nacionalidad VARCHAR (20)
);

CREATE TABLE Actores(
    nombre VARCHAR (20) NOT NULL,
    nacionalidad VARCHAR (20),
    sexo ENUM('H', 'M')
);

CREATE TABLE Socio(
    dni CHAR (9) PRIMARY KEY,
    
);

CREATE TABLE Pelicula(
    
);

CREATE TABLE Actua(
    
);

CREATE TABLE Alquila(
    
);

CREATE TABLE Ejemplar(
    
);