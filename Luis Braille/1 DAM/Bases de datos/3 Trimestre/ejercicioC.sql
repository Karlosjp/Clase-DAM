DROP DATABASE IF EXISTS EjercicioC;

CREATE DATABASE EjercicioC;

USE EjercicioC;

CREATE TABLE employee (
    emplroyeeid CHAR (5) PRIMARY KEY,
    employeename VARCHAR (20),
    position VARCHAR (20),
    salary FLOAT,
    remarks MEDIUMTEXT
);

CREATE TABLE planet (
    planetid CHAR (5) PRIMARY KEY,
    planetname VARCHAR (20),
    coordinates VARCHAR (10)
);

CREATE TABLE shipment (
    shipmentid CHAR (5) PRIMARY KEY,
    shipmentdate DATE,
    emplroyeeid CHAR (5),
    planetid CHAR (5),
    FOREIGN KEY (emplroyeeid) REFERENCES employee (emplroyeeid),
    FOREIGN KEY (planetid) REFERENCES planet (planetid)
);

CREATE TABLE has_clearance (
    emplroyeeid CHAR (5),
    planetid CHAR (5),
    clearancelevel SMALLINT,
    PRIMARY KEY (emplroyeeid, planetid),
    FOREIGN KEY (emplroyeeid) REFERENCES employee (emplroyeeid),
    FOREIGN KEY (planetid) REFERENCES planet (planetid)
);

CREATE TABLE client (
    accountNumber CHAR (5),
    clientname VARCHAR(20)
);

CREATE TABLE package (
    shipmentid CHAR (5),
    packagenumber CHAR (5),
    contents MEDIUMTEXT,
    weigth FLOAT,
    sender CHAR (5),
    recipient CHAR (5),
    PRIMARY KEY (shipmentid, packagenumber),
    FOREIGN KEY (shipmentid) REFERENCES shipment (shipmentid),
    FOREIGN KEY (sender) REFERENCES client (accountNumber)
);