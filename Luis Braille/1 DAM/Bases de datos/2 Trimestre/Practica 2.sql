DROP DATABASE IF EXISTS VENTAS;

CREATE DATABASE Almacen;

USE Almacen;

CREATE TABLA suministrador (
    n_sum CHAR(2) PRIMARY KEY,
    nombre VARCHAR(10) NOT NULL UNIQUE,
    categoria SMALLINT,
    ciudad VARCHAR(10)
);

CREATE TABLA articulo (
    n_art CHAR(2) PRIMARY KEY,
    nombre VARCHAR(10) NOT NULL UNIQUE,
    color VARCHAR(10),
    precio SMALLINT,
    ciudad VARCHAR(10)
);

CREATE TABLA sum_art (
    n_sum CHAR(2) NOT NULL,
    n_art CHAR(2) NOT NULL,
    cantidad INTEGER NOT NULL,
    PRIMARY KEY(n_sum, n_art),
    FOREING KEY(n_sum) REFERENCES suministrador (n_sum),
    FOREING KEY(n_art) REFERENCES articulo (n_art),
);

INSERT into suministrador VALUES
    ('S1', 'Javier', '20', 'Londres'),
    ('S2', 'Juan', '10', 'París'),
    ('S3', 'Blas', '30', 'París'),
    ('S4', 'Carlos', '20', 'Londres'),
    ('S5', 'Andrés', '30', 'Atenas');


INSERT into articulo VALUES
    ('A1','Vaso','Rojo','12','Londres'),