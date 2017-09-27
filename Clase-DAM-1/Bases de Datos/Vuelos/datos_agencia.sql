USE Vuelos;

INSERT INTO Usuario (Nombre, Apellidos, Fecha_ingreso, Fecha_nacimiento, Telefono) VALUES
    ('Carlos', 'Jaquez Payamps', '2017-05-29', '1999-01-01', '+34508724181'),
    ('Santiago', 'Caballero Jimenez', '2017-03-5', '1993-06-01', '+34568725181'),
    ('Thomas', 'Cuevas Mendez', '2015-07-31', '1998-03-01', '+34506724187'),
    ('Jaime', 'Rodriguez Santos', '2013-02-27', '1996-04-03', '+34505716181');

INSERT INTO Aeropuerto VALUES
    ('HAM', 'Alemania', 'Hamburgo'),
    ('IPC', 'Chile', 'Valparaiso'),
    ('MAD', 'España', 'Madrid');

INSERT INTO Companhia VALUES
    ('15481', 'Iberia'),
    ('12485', 'Air Euripa'),
    ('48521', 'Blue Air');

INSERT INTO Reserva (ID_Usuario, Cantidad) VALUES
    (1, 3),
    (3, 2),
    (2, 1),
    (1, 4);

INSERT INTO Vuelo VALUES
    ('M-25441-I', 'MAD', 'IPC', '2017-06-02'),
    ('H-3553-M', 'HAM', 'MAD', '2017-10-02'),
    ('I-25441-H', 'IPC', 'HAM', '2017-04-02'),
    ('H-25441-I', 'HAM', 'IPC', '2016-06-02');

INSERT INTO Proporciona VALUES
    ('M-25441-I', '15481'),
    ('H-3553-M', '15481'),
    ('I-25441-H', '12485'),
    ('H-25441-I', '48521');

INSERT INTO Asiento VALUES
    ('IZ-001', 'M-25441-I', 1, 'Turista', 250.45),
    ('IZ-002', 'M-25441-I', 1, 'Turista', 250.45),
    ('CE-001', 'M-25441-I', 1, 'Turista', 250.45),
    ('CE-002', 'M-25441-I', 1, 'Turista', 250.45),
    ('CE-003', 'M-25441-I', 1, 'Turista', 250.45),
    ('DE-001', 'M-25441-I', 1, 'Turista', 250.45),
    ('DE-002', 'M-25441-I', 1, 'Turista', 250.45),
    ('IZ-003', 'M-25441-I', 1, 'Turista', 250.45),
    ('IZ-004', 'M-25441-I', 1, 'Turista', 250.45),
    ('CE-001', 'H-3553-M', 1, 'Turista', 250.45),
    ('CE-002', 'H-3553-M', 1, 'Turista', 250.45),
    ('CE-003', 'I-25441-H', 1, 'Turista', 250.45),
    ('DE-001', 'H-3553-M', 1, 'Turista', 250.45),
    ('CE-001', 'I-25441-H', 1, 'Business', 400.50),
    ('IZ-051', 'H-3553-M', 1, 'Business', 400.50),
    ('DE-002', 'H-3553-M', 1, 'Business', 400.50),
    ('CE-041', 'I-25441-H', 1, 'Business', 400.50),
    ('CE-061', 'I-25441-H', 1, 'Business', 400.50),
    ('CE-071', 'I-25441-H', 1, 'Business', 400.50);

INSERT INTO Pasajero VALUES
    ('51296327A', 'IZ-001', 'M-25441-I', 'Carlos', 'sdfqweaf', 1, 2),
    ('54596327A', 'IZ-002', 'M-25441-I', 'David', 'sdfqweaf', 1, 2),
    ('57896327A', 'CE-001', 'M-25441-I', 'Andres', 'adfqe', 1, 2),
    ('54866327A', 'CE-002', 'M-25441-I', 'Marta', 'adfqe', 1, 2),
    ('53896427A', 'CE-003', 'M-25441-I', 'Rud', 'adfqe', 1, 2),
    ('54196327A', 'DE-001', 'M-25441-I', 'Anny', 'fsdgx', 1, 2),
    ('54926327A', 'DE-002', 'M-25441-I', 'Matias', 'ewaf', 1, 2),
    ('54891327A', 'IZ-003', 'M-25441-I', 'Antonia', 'fhsdd', 1, 2),
    ('54886327A', 'IZ-004', 'M-25441-I', 'Antonio', 'hjrhfdn', 1, 2),
    ('54596627A', 'CE-001', 'H-3553-M', 'Jose Luis', 'dfghert', 1, 2),
    ('54856327A', 'CE-002', 'H-3553-M', 'Jose Carlos', 'ertyjfg', 1, 2),
    ('54897777A', 'CE-003', 'I-25441-H', 'Fernando', 'ytrihjk', 1, 2),
    ('54899327A', 'DE-001', 'H-3553-M', 'Jose Maria', 'ghjfbnbc', 1, 2),
    ('54896327A', 'CE-001', 'I-25441-H', 'Blanca', 'dthwgsf', 1, 2),
    ('54845327A', 'IZ-051', 'H-3553-M', 'Jimena', 'yuioghkjg', 1, 1),
    ('54896827A', 'DE-002', 'H-3553-M', 'Tamara', 'ncvbndf', 1, 2),
    ('54896867A', 'CE-041', 'I-25441-H', 'Silvia', 'wertqsaf', 2, ' '),
    ('54897827A', 'CE-061', 'I-25441-H', 'Erika', 'qewrasf', 2, 1),
    ('54894527A', 'CE-071', 'I-25441-H', 'Aitor', 'sdfgcxvb', 1, ' ');
