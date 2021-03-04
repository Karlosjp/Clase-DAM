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
-- e7
select * from CAT22 where ciudad != "Londres";
-- e8
update CAT22 set ciudad ="New York" where ciudad="Paris";
    select * from CAT22;
-- e9
insert into CAT22 values ("S6", "Luis", "25", "Madrid");
--10A
select * from CAT22;
--10B
select * from suministrador;
--10C
insert into CAT22 values ("S7", "Carlos", "20", "Madrid");
--10D
select * from CAT22;
--11
delete from suministrador where 