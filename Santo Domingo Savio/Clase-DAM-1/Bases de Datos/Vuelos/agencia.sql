DROP DATABASE IF EXISTS Vuelos;

CREATE DATABASE Vuelos;

USE Vuelos;

CREATE TABLE Usuario (
	ID INT AUTO_INCREMENT,
	Nombre VARCHAR(15),
	Apellidos VARCHAR (30),
	Fecha_ingreso DATE,
	Fecha_nacimiento DATE,
	Telefono VARCHAR(14),

	PRIMARY KEY (ID)
)engine=innodb;

CREATE TABLE Aeropuerto(
	Codigo_IATA CHAR(3),
	Pais VARCHAR(20),
	Ciudad VARCHAR(20),

	PRIMARY KEY (Codigo_IATA)
)engine=innodb;

CREATE TABLE Companhia(
	Codigo_empresa CHAR(5),
	Nombre VARCHAR(20),

	PRIMARY KEY (Codigo_empresa)
)engine=innodb;

CREATE TABLE Reserva(
	ID INT AUTO_INCREMENT,
	ID_Usuario INT,
	Cantidad TINYINT,

	PRIMARY KEY (ID),

	CONSTRAINT FK_res_usu FOREIGN KEY (ID_Usuario)
        REFERENCES Usuario (ID) ON DELETE NO ACTION ON UPDATE CASCADE
	)engine=innodb;

CREATE TABLE Vuelo(
	Codigo_vuelo VARCHAR(10),
	Origen CHAR(3),
    Destino CHAR(3),
	Fecha_hora_salida DATETIME,

	PRIMARY KEY (Codigo_vuelo ),

	CONSTRAINT FK_vue_aerO FOREIGN KEY (Origen)
        REFERENCES Aeropuerto (Codigo_IATA) ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT FK_vue_aerD FOREIGN KEY (Destino)
        REFERENCES Aeropuerto (Codigo_IATA) ON DELETE NO ACTION ON UPDATE CASCADE
)engine=innodb;


CREATE TABLE Proporciona(
	Codigo_vuelo VARCHAR(10),
	Codigo_empresa CHAR(5),

	CONSTRAINT FK_pro_vue FOREIGN KEY(Codigo_vuelo)
        REFERENCES Vuelo (Codigo_vuelo) ON DELETE SET NULL ON UPDATE CASCADE,
	CONSTRAINT FK_pro_com FOREIGN KEY(Codigo_empresa)
        REFERENCES Companhia(Codigo_empresa) ON DELETE NO ACTION ON UPDATE CASCADE
)engine=innodb;

CREATE TABLE Asiento(
	Codigo_asiento CHAR(6),
	Codigo_vuelo VARCHAR(10),
	ID_Reserva INT,
	Clase ENUM('Turista', 'Business'),
	Precio FLOAT(6,2),

	PRIMARY KEY (Codigo_asiento, Codigo_vuelo),

	CONSTRAINT FK_asi_vue FOREIGN KEY(Codigo_vuelo)
        REFERENCES Vuelo (Codigo_vuelo) ON DELETE NO ACTION ON UPDATE CASCADE
)engine=innodb;

CREATE TABLE Pasajero(
	DNI CHAR(9),
	Codigo_asiento CHAR(6),
	Codigo_vuelo VARCHAR(10),
	Nombre VARCHAR(15),
	Apellidos VARCHAR(30),
	Equipaje_mano ENUM('1', '2'),
	Equipaje_facturable ENUM(' ', '1', '2'),

	PRIMARY KEY (DNI),

	CONSTRAINT FK_pas_asI FOREIGN KEY(Codigo_asiento)
        REFERENCES Asiento(Codigo_asiento) ON DELETE RESTRICT ON UPDATE CASCADE,
	CONSTRAINT FK_pas_asv FOREIGN KEY(Codigo_vuelo)
        REFERENCES Asiento(Codigo_vuelo) ON DELETE SET NULL ON UPDATE CASCADE
)engine=innodb;

SOURCE datos_agencia.sql
