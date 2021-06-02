drop database if exists bdtrim3carlos;

create database bdtrim3carlos;

use bdtrim3carlos;

create table empleados (
    idemp varchar(10),
    nombre varchar(25),
    direccion text,
    nivel text
);

create table tiendas (
    idtienda varchar(10),
    nombre varchar(25),
    direccion varchar(100),
    ciudad varchar(50),
    provincia varchar(50),
    codpostal integer(5),
    idemp int unsigned
);

create table proveedores (
    idprov int unsigned,
    nombre varchar(25),
    pais varchar(40),
    web enum("web1.com", "web2.com", "web3.com"),
    idprovp int unsigned
);

create table productos (
    codprod varchar(50),
    codprov int unsigned,
    categoria varchar(50),
    peso smallint,
    precio_coste decimal(10,2),
    cantidad bigint,
    precio_venta decimal(10,2),
    dimensiones float(7,2),
    descontinuado boolean 
);

create table ventas (
    idventa varchar(10),
    nart integer unsigned,
    codfab integer unsigned,
    peso smallint,
    categoria varchar(50),
    fecha_venta date,
    unidades_vendidas integer
);

create table pedidos (
    idpedido varchar(10),
    codfabricante integer unsigned,
    peso smallint,
    fecha_pedido date,
    categoria varchar(50),
    articulo varchar(50),
    unidades_pedidas integer unsigned,
    descuentos enum("5%", "10%", "15%")
);

alter table empleados add primary key (idemp);

alter table tiendas add primary key (idtienda);
alter table tiendas add unique (nombre, provincia);
alter table tiendas modify idemp varchar(10);
alter table tiendas add foreign key (idemp) references empleados(idemp);
alter table tiendas drop foreign key tiendas_ibfk_1;

alter table proveedores add primary key (idprov);
alter table proveedores add unique (nombre,pais);
alter table proveedores add foreign key (idprovp) references proveedores(idprov);
alter table proveedores add tipoprov enum("asia", "ue", "emea", "latam") default ("asia");
alter table proveedores modify web enum("web1.com", "web2.com");
alter table proveedores modify pais varchar(40) check (pais.lenght > 15);

alter table productos add primary key (codprod, categoria);
alter table productos add foreign key (codprov) references proveedores(idprov);
alter table productos modify precio_venta decimal(10) check(precio_venta > 0 && precio_venta < 1000);
alter table productos modify precio_venta decimal(10,2) check(precio_coste = precio_venta * 0.85);
alter table productos change cantidad ndisp bigint;
alter table productos modify peso float(10,2);
alter table productos modify dimensiones enum("10", "20", "30") default (10);
alter table productos add distancia float(7,3);

alter table ventas add primary key (idventa, nart, codfab, peso);
alter table ventas modify idventa int unsigned;
alter table ventas add foreign key (idventa) references proveedores(idprov);
alter table ventas modify nart varchar(50);
alter table ventas add foreign key (nart) references productos(codprod);
--alter table ventas add foreign key (categoria) references productos(categoria);
alter table ventas modify categoria varchar(50) check (categoria = "cat1"| categoria = "cat2" | categoria = "cat3");
alter table ventas modify fecha_venta date check(fecha_venta > "02.03.2018" & fecha_venta < "03.10.2021");
alter table ventas modify fecha_venta timestamp;
alter table ventas add grupo enum("a","b","c") not null;

alter table pedidos add primary key (idpedido, codfabricante, peso, fecha_pedido, categoria, articulo);
alter table pedidos add foreign key (idpedido) references tiendas(idtienda);
--alter table pedidos add foreign key (categoria) references productos(categoria);
alter table pedidos add foreign key (articulo) references productos(codprod);

alter table empleados rename customers;
alter table customers modify idemp int auto_increment;