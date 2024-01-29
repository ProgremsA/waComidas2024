--Creacion de la base de datos
create database ComidasDelAño2024
go

use ComidasDelAño2024
go

use master 

drop database ComidasDelAño2024

--Creacion de la tabla
create table Comidas
(
codCom int identity(1,1) primary key, 
nomCom varchar(45),
diaCom varchar(45),
fechCom varchar(45)
)
go
alter table Comidas 
add Autor varchar(50)

insert into Comidas
values
(@nom,@dia,@fec)

select*from Comidas

insert into Comidas
values 
('Recalentado de Pollo al Horno','Lunes','01/01/24'),
('Lentejitas','Martes','02/01/24')

update Comidas
set 'lentejitas'
where fechCom = '01/01/24'

delete from Comidas
where codCom = 34

UPDATE Comidas
SET fechCom = '10/01/2024'  
WHERE codCom = 10

--comando para resetear el codcom en caso se desordene el codigo
DBCC CHECKIDENT ('Comidas', RESEED, 26);

--Comando para actualizar un registro 
update Comidas
set Autor = 'Mamá'
where codCom = 26

select*from Comidas

select*from Comidas
where diaCom = 'lunes'

select * from Comidas where diaCom = 'martes'


