create database BaseCrudEstudiantes2
use BaseCrudEstudiantes2
drop database BaseCrudEstudiantes2

create table Alumnos(
	Codigo char(10) primary key,
	PrimNomb varchar(50) not null,
	SeguNomb varchar(50) not null,
	PrimApell varchar(50) not null,
	SeguoApell varchar(50) not null,
	Telefo char(7) ,
	Celular char(9) not null,
	Direcc varchar(50) not null,
	Email varchar(50) not null,
	FecNac datetime ,
	Sexo varchar(50) not null,
	Observa varchar(200),)

SELECT * FROM Alumnos ORDER BY PrimNomb ASC

insert into Alumnos(Codigo,PrimNomb,SeguNomb,PrimApell,SeguoApell,Telefo,Celular,Direcc,Email,FecNac,Sexo,Observa) values 
('A001','Lucas','Angel','Mallqui','Torres','4561237','945612378','LaCalles123','Torres@gmail.com','12-12-2002','M','miguel')

UPDATE Alumnos SET PrimNomb='Marco' ,SeguNomb = 'Oscar',PrimApell='Quispe',SeguoApell='Torres',
Telefo='4567891',Celular='978456123',Direcc='Torres123',Email='Torres@gmail.com',FecNac='05-3-2002',Sexo='M', Observa='Bueno' where Codigo = 'A001'

DELETE FROM Alumnos WHERE Codigo = 'A01' 

SELECT * FROM Alumnos WHERE Codigo ='A01'


create table Notas(
	idalumno char(10) foreign key references Alumnos(codigo) on delete cascade ,
	curso varchar(15) not null,
	nota1 varchar(15) not null,
	nota2 varchar(15) not null,
	nota3 varchar(15) not null,
)

select *  from Notas

insert into Notas values ('A001','d','d','d','d')

insert into Notas values ('A001','Fisica','d','d','d')


select *
from Alumnos  join Notas 
on(Codigo = idalumno);


select * from Notas where curso = 'Quimica'
SELECT idalumno from Notas  where idalumno = 'A001'
SELECT idalumno from Notas  where idalumno ='123 '

select Codigo,PrimNomb,SeguNomb,PrimApell,SeguoApell,Telefo,Celular,Direcc,Email,FecNac,Sexo,Observa ,curso,nota1,nota2,nota3
from Alumnos  join Notas on (Codigo = idalumno)


select idalumno as 'ID ALUMNO' , curso as 'Rufo' , nota1,nota2,nota3
from Notas

select * from Notas

DELETE FROM Alumnos WHERE Codigo = 'A001' 

delete from Notas where curso = 'Matematica';
--creacion de CystalReport
create procedure AlunmosOrix as
select  Codigo,PrimNomb as 'PrimerNombre',SeguNomb as 'SegundoNombre',PrimApell as 'PrimerApellido',SeguoApell as 'SegundoApellido',Telefo as 'Telefono',Celular,Direcc as 'Direccion',Email,FecNac as 'Fecha Nacimiento',Sexo,Observa as 'Observacion' ,curso as 'Curso',nota1,nota2,nota3
from Alumnos  join Notas on (Codigo = idalumno)
execute AlunmosOrix

create procedure AlunmosOrixg as
select  Codigo,PrimNomb as 'PrimerNombre',SeguNomb as 'SegundoNombre',PrimApell as 'PrimerApellido',SeguoApell as 'SegundoApellido',Telefo as 'Telefono',Celular,Direcc as 'Direccion',Email,FecNac as 'Fecha Nacimiento',Sexo,Observa as 'Observacion' ,curso as 'Curso',nota1,nota2,nota3
from Alumnos  join Notas on (Codigo = idalumno)
execute AlunmosOrixg

--creacion de procedimeinto almacenado :
create procedure Insertar_Notas
@cod varchar(20),@curso varchar(20),@nota1 varchar(20) ,@nota2 varchar(20),@nota3 varchar(30)
as
begin
if not exists (select curso from Notas where idalumno=@cod and curso=@curso)
insert into Notas(idalumno,curso,nota1,nota2,nota3) values (@cod,@curso,@nota1,@nota2,@nota3)	 
end


execute Insertar_Notas 'A001','Comunicacion','100%','100%','100%'

select *  from Notas
select curso from Notas where curso = 'Quimica' and idalumno = 'A001'