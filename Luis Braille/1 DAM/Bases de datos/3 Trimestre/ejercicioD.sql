DROP DATABASE IF EXISTS EjercicioD;

CREATE DATABASE EjercicioD;

USE EjercicioD;

CREATE TABLE alumno (
    nummatricula INTEGER (6),
    nombre VARCHAR(20),
    fechanacimiento DATE,
    telefono CHAR (9),
    PRIMARY KEY (nummatricula)
);

CREATE TABLE profesor (
    idprofesor CHAR (5),
    nif_p CHAR (9) ,
    nombre VARCHAR (20),
    especialidad VARCHAR (20),
    telefono VARCHAR (9),
    PRIMARY KEY (idprofesor),
    UNIQUE KEY (nif_p)
);

CREATE TABLE asignatura (
    codasignatura CHAR (5),
    nombre VARCHAR (20),
    idprofesor CHAR (5),
    PRIMARY KEY (codasignatura),
    FOREIGN KEY (idprofesor) REFERENCES profesor (idprofesor)
);

CREATE TABLE recibe (
    nummatricula INTEGER (6),
    codasignatura CHAR (5),
    cursoescolar VARCHAR(6),
    PRIMARY KEY (nummatricula, codasignatura, cursoescolar),
    FOREIGN KEY (nummatricula) REFERENCES alumno (nummatricula),
    FOREIGN KEY (codasignatura) REFERENCES asignatura (codasignatura)
);