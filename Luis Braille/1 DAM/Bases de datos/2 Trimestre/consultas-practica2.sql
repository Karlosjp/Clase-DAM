-- e2
select * from suministrador where n_sum="S1";
-- e3
select articulo.nombre, avg(sum_art.cantidad) 
    from articulo join sum_art using(n_art) group by articulo.n_art;
-- e4
update suministrador set categoria *= 2;
    select * from suministrador;
-- e5
update suministrador set ciudad="Madrid" where categoria < (select min(precio) from articulo);
    select * from suministrador;
-- e6
create view CAT22 as select * from suministrador where categoria > 22;
-- e7
select * from CAT22 where ciudad != "Londres";
-- e8
update CAT22 set ciudad ="New York" where ciudad="Paris";
    select * from CAT22;
-- e9
insert into CAT22 values ("S6", "Luis", "25", "Madrid");
-- e10A
select * from CAT22;
-- e10B
select * from suministrador;
-- e10C
insert into CAT22 values ("S7", "Carlos", "20", "Madrid");
-- e10D
select * from CAT22;
-- e11
delete from suministrador where 
-- e12
create view ROJOS as select * from articulo where color = "Rojo";
-- e13
create view ROJLON as select * from articulo where color = "Rojo" and ciudad="Londres";
-- e14
select  n_art, sum(cantidad) from sum_art group by n_art;
-- e15
select  n_art, sum(cantidad) from sum_art group by n_art having sum(cantidad)>400;
-- e16
select  n_art, sum(cantidad) from sum_art where cantidad>200 group by n_art;
-- e17
select count(*) from suministrador;
-- e18
select count(distinct n_sum) from sum_art;
-- e19
select count(distinct n_sum) from sum_art where n_art="A1";
-- e20
select count(*) from sum_art where n_art="A2";
-- e21
select count(*) from suministrador where categoria > max(categoria);
-- e22
select count(*) from suministrador group by ciudad having categoria > avg(categoria);
-- e23
select count(*) from articulo where precio between 16 and 30;
-- e24
select nombre, n_art from articulo where nombre like "C%";
-- e25
select n_sum from suministrador where categoria IS NULL;
-- e26
select n_art from articulo where precio in (12, 14, 35);
-- e27
update articulo set color = "Amarillo" where n_art="A2";
    select * from articulo;
-- e28
update articulo set precio +=5, ciudad = null where n_art="A2";
    select * from articulo;
-- e29
select n_art from sum_art group by n_art having count(n_sum)=1;
-- e30
create view CI_CI as select distinct suministrador.ciudad as "sum_ciudad", articulo.ciudad as "art_ciudad"
    from sum_art join suministrador on sum_art.n_sum = suministrador.n_sum
    join articulo on sum_art.n_art = articulo.n_art
-- e31
select distinct suministrador.n_sum as "n_art", articulo.n_art as "n_art"
    from sum_art join suministrador on sum_art.n_sum = suministrador.n_sum
    join articulo on sum_art.n_art = articulo.n_art
    where suministrador.ciudad = articulo.ciudad;
-- e32
select n_art, max(cantidad) as "maximo", sum(cantidad) as "total" 
    from sum_art where n_art != "A1" group by n_art