DROP DATABASE IF EXISTS Almacen;

CREATE DATABASE Almacen;

USE Almacen;

CREATE TABLE suministrador (
    n_sum CHAR(2) PRIMARY KEY,
    nombre VARCHAR(10) NOT NULL UNIQUE,
    categoria SMALLINT,
    ciudad VARCHAR(10)
);

CREATE TABLE articulo (
    n_art CHAR(2) PRIMARY KEY,
    nombre VARCHAR(10) NOT NULL UNIQUE,
    color VARCHAR(10),
    precio SMALLINT,
    ciudad VARCHAR(10)
);

CREATE TABLE sum_art (
    n_sum CHAR(2) NOT NULL,
    n_art CHAR(2) NOT NULL,
    cantidad INTEGER NOT NULL,
    PRIMARY KEY(n_sum, n_art),
    CONSTRAINT fk_n_sum FOREIGN KEY(n_sum) REFERENCES suministrador (n_sum),
    CONSTRAINT fk_n_art FOREIGN KEY(n_art) REFERENCES articulo (n_art)
);

INSERT into suministrador VALUES
    ('S1', 'Javier', '20', 'Londres'),
    ('S2', 'Juan', '10', 'París'),
    ('S3', 'Blas', '30', 'París'),
    ('S4', 'Carlos', '20', 'Londres'),
    ('S5', 'Andrés', '30', 'Atenas');


INSERT into articulo VALUES
    ('A1','Vaso','Rojo','12','Londres'),
    ('A2','Plato','Verde','17','Paris'),
    ('A3','Sopera','Azul','30','Roma'),
    ('A4','Fuente','Rojo','25','Londres'),
    ('A5','Copa','Azul','14','Paris'),
    ('A6','Jarra','Rojo','35','Londres');

INSERT into sum_art VALUES 
    ("S1", "A1", 300),
    ("S1", "A2", 200),
    ("S1", "A3", 400),
    ("S1", "A4", 200),
    ("S1", "A5", 100),
    ("S1", "A6", 100),
    ("S2", "A1", 300),
    ("S2", "A2", 400),
    ("S3", "A2", 200),
    ("S4", "A2", 200),
    ("S4", "A4", 300),
    ("S4", "A5", 400);