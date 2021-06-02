mysql> select concat(numde, "-", NOMDE) as 'Número-Nombre' from departamentos;
+------------------------+
| Número-Nombre          |
+------------------------+
| 100-DIRECCIÓN GENERAL  |
| 110-DIRECC.COMERCIAL   |
| 111-SECTOR INDUSTRIAL  |
| 112-SECTOR SERVICIOS   |
| 120-ORGANIZACIÓN       |
| 121-PERSONAL           |
| 122-PROCESO DE DATOS   |
| 130-FINANZAS           |
+------------------------+

mysql> select e.NOMEM, concat(e.Salar + e.Comis, " €") as "Salario total"
    ->     from departamentos d join empleados e on d.numde = e.Numde where e.Numde = 111 order by e.Salar , e.NOMEM;
+----------+---------------+
| NOMEM    | Salario total |
+----------+---------------+
| SANCHO   | 720 €         |
| LUCRECIA | NULL          |
| HONORIA  | 1300 €        |
| DIANA    | 1360 €        |
| LIVIA    | 1360 €        |
| LAVINIA  | 1800 €        |
| AUREO    | 1910 €        |
| DORINDA  | 1900 €        |
+----------+---------------+

mysql> select NOMEM, concat((Salar + Comis + 120) * (Numhi - 3), " €") as "Salario total"
    ->     from empleados where Numhi > 3;
+---------+---------------+
| NOMEM   | Salario total |
+---------+---------------+
| JULIANA | NULL          |
| ANTONIO | NULL          |
| DOROTEA | NULL          |
+---------+---------------+

mysql> select NOMEM, Salar from empleados
    ->     where Comis is not null and ((Salar / Numhi between 720 and 1200) or Salar > Comis * 50) order by NOMEM;
+---------+-------+
| NOMEM   | Salar |
+---------+-------+
| AUREO   |  1800 |
| DORINDA |  1800 |
| LUCIANO |  1500 |
| MARCOS  |  2800 |
+---------+-------+

mysql> select concat("Departamento de ",NOMDE), presu from departamentos where NOMDE like "%SECTOR%";
+-----------------------------------+-------+
| concat("Departamento de ",NOMDE)  | presu |
+-----------------------------------+-------+
| Departamento de SECTOR INDUSTRIAL |  66.0 |
| Departamento de SECTOR SERVICIOS  |  54.0 |
+-----------------------------------+-------+

mysql> select NOMEM, Salar from empleados where (Numhi = 0 and Salar > 1500) or (Numhi > 0 and Salar < 1000) order by NOMEM desc limit 3;
+---------+-------+
| NOMEM   | Salar |
+---------+-------+
| OTILIA  |  1910 |
| JULIO   |  2600 |
| CLAUDIA |  2400 |
+---------+-------+

mysql> select NOMDE, tidir, presu from departamentos where tidir like 'F' or (tidir like 'P' and presu > 30) or depde is null;
+--------------------+-------+-------+
| NOMDE              | tidir | presu |
+--------------------+-------+-------+
| DIRECCIÓN GENERAL  | P     |  72.0 |
| DIRECC.COMERCIAL   | P     |  90.0 |
| SECTOR INDUSTRIAL  | F     |  66.0 |
| SECTOR SERVICIOS   | P     |  54.0 |
| ORGANIZACIÓN       | F     |  18.0 |
| PROCESO DE DATOS   | P     |  36.0 |
+--------------------+-------+-------+

mysql> select NOMEM, date_format(Fecna, '%D %M %Y') from empleados where Fecna like "%-11-%" order by NOMEM;
+---------+--------------------------------+
| NOMEM   | date_format(Fecna, '%D %M %Y') |
+---------+--------------------------------+
| AUGUSTO | 21st November 1976             |
| CESAR   | 20th November 1970             |
| GLORIA  | 30th November 1967             |
+---------+--------------------------------+

mysql> select NOMEM, date_format(Fecna, '%W %M %Y') from empleados where date_format(Fecna, '%W') like "Friday" and date_format(Fecin, '%W') like "Thursday";
+---------+--------------------------------+
| NOMEM   | date_format(Fecna, '%W %M %Y') |
+---------+--------------------------------+
| HONORIA | Friday October 1965            |
+---------+--------------------------------+

mysql> select NOMEM, date_format(Fecin, '%M') from empleados where month(Fecin) between 1 and 6;
+----------+--------------------------+
| NOMEM    | date_format(Fecin, '%M') |
+----------+--------------------------+
| CESAR    | February                 |
| LUCIANO  | February                 |
| JULIO    | January                  |
| MARCOS   | March                    |
| JULIANA  | February                 |
| PILAR    | January                  |
| LAVINIA  | February                 |
| ADRIANA  | March                    |
| OTILIA   | February                 |
| GLORIA   | February                 |
| AUGUSTO  | January                  |
| CORNELIO | February                 |
| AMELIA   | March                    |
| FABIOLA  | January                  |
| MICAELA  | January                  |
| LIVIA    | February                 |
| SABINA   | February                 |
| DIANA    | February                 |
| HORACIO  | January                  |
| HONORIA  | January                  |
| ROMULO   | January                  |
| SANCHO   | January                  |
+----------+--------------------------+

mysql> select d.numde, truncate(avg(e.Salar), 2) as "Salario medio", min(e.Salar) as "Salario minimo", max(e.Salar) as "Salario maximo"
from departamentos d join empleados e on e.Numde = d.numde group by d.numde;
+-------+---------------+----------------+----------------+
| numde | Salario medio | Salario minimo | Salario maximo |
+-------+---------------+----------------+----------------+
|   130 |       1670.00 |            600 |           2800 |
|   122 |       1670.00 |            600 |           2800 |
|   121 |       1670.00 |            600 |           2800 |
|   120 |       1670.00 |            600 |           2800 |
|   112 |       1670.00 |            600 |           2800 |
|   111 |       1670.00 |            600 |           2800 |
|   110 |       1670.00 |            600 |           2800 |
|   100 |       1670.00 |            600 |           2800 |
+-------+---------------+----------------+----------------+

select NOMEM, Numde from empleados group by Numde;
where Numde in (select numde from departamentos) 

mysql> select count(*), sum(Salar) as "Suma Salario", sum(Comis) as "Suma Comision", sum(Numhi) as "Suma hijos"
from empleados where Numde in (select numde from departamentos where tidir like 'F');
+----------+--------------+---------------+------------+
| count(*) | Suma Salario | Suma Comision | Suma hijos |
+----------+--------------+---------------+------------+
|        9 |        12560 |           730 |         11 |
+----------+--------------+---------------+------------+

mysql> select e.NOMEM from empleados e right join departamentos d on (e.Numde = d.numde) where e.Numde is null;
Empty set (0.00 sec)

mysql> select d.NOMDE from empleados e left join departamentos d on (e.Numde = d.numde) where e.Numem is null;
Empty set (0.00 sec)

mysql> select count(*) as "Numero empleados", Extel from empleados group by Extel having count(*) > 1;
+------------------+-------+
| Numero empleados | Extel |
+------------------+-------+
|                2 |   350 |
|                3 |   760 |
|                2 |   620 |
|                2 |   750 |
|                3 |   880 |
|                2 |   780 |
+------------------+-------+

mysql> select count(Extel) as "Total extensiones", numde from empleados where Numde in (
select numde from empleados group by numde having avg(Salar) > 2000) group by numde;
+-------------------+-------+
| Total extensiones | numde |
+-------------------+-------+
|                 4 |   121 |
+-------------------+-------+

mysql> select d.NOMDE, avg(e.Salar) from departamentos d join empleados e on (d.numde = e.Numde)
where d.numde in (select numde from empleados group by numde having avg(Salar) > 1800) 
group by d.numde;
+------------------+--------------+
| NOMDE            | avg(e.Salar) |
+------------------+--------------+
| PERSONAL         |    2002.5000 |
| PROCESO DE DATOS |    1856.0000 |
| FINANZAS         |    1950.0000 |
+------------------+--------------+

mysql> select NOMDE from departamentos where numde in (
    select distinct Numde from empleados where Salar < 2000);
+--------------------+
| NOMDE              |
+--------------------+
| DIRECCIÓN GENERAL  |
| DIRECC.COMERCIAL   |
| SECTOR INDUSTRIAL  |
| SECTOR SERVICIOS   |
| ORGANIZACIÓN       |
| PERSONAL           |
| PROCESO DE DATOS   |
| FINANZAS           |
+--------------------+

mysql> select count(*) as "Total empleados", count(distinct Comis) "Comisiones distintas",
    -> sum(Comis) as "Suma comisiones" from empleados where numde = 112;
+-----------------+----------------------+-----------------+
| Total empleados | Comisiones distintas | Suma comisiones |
+-----------------+----------------------+-----------------+
|               7 |                    4 |             590 |
+-----------------+----------------------+-----------------+