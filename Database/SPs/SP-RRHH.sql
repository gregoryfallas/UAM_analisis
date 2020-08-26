 ALTER TABLE [dbo].[PERSONAL] ADD Correo_Electronico varchar(50) NULL
 GO

 ALTER TABLE [dbo].[PERSONAL] ADD Telefono varchar(50) NULL
 GO

CREATE PROCEDURE [dbo].[SP_AGREGAR_RECLUTAMIENTO3]
(
@ID_Puestos int,
@Nombre varchar(30),
@Descripcion varchar(100),
@Estado int
)
AS
BEGIN
INSERT INTO RECLUTAMIENTO 
    (ID_Puestos,Nombre,Descripcion,Estado) 
    
    VALUES 
    (@ID_Puestos,
	@Nombre ,
	@Descripcion,
     @Estado )
END
go
--*************************************************************************1

CREATE PROCEDURE [dbo].[SP_AGREGAR_PERSONAL]
(
@ID_Puesto int,
@Cedula varchar(20),
@Nombre varchar(30),
@Apellido_1 varchar(30),
@Apellido_2 varchar(30),
@Salario_Hora decimal(10,2),
@Salario_Mensual decimal(10,2),
@Fecha_Contratacion date,
@Estado int,
@Direccion varchar(150),
@Correo_Electronico varchar(50),
@Telefono varchar(50)
)
AS
BEGIN
INSERT INTO PERSONAL 
    (ID_Puesto, Cedula, Nombre, Apellido_1, Apellido_2, Salario_Hora, Salario_Mensual, 
	Fecha_Contratacion, Estado, Direccion, Correo_Electronico, Telefono) 
    
    VALUES 
    (
	@ID_Puesto,
    @Cedula,
    @Nombre, 
    @Apellido_1,
    @Apellido_2,
    @Salario_Hora,
    @Salario_Mensual,
    @Fecha_Contratacion,
    @Estado,
    @Direccion,
    @Correo_Electronico,
    @Telefono
	 )
END
go
------------------------------------------------------------------2

CREATE PROCEDURE [dbo].[SP_AGREGAR_USUARIOS]
(
@ID_Personal int,
@UserName varchar(20),
@Pass varchar(20),
@Last_Login varchar(20),
@Estado int
)
AS
BEGIN
INSERT INTO USUARIOS 
    (ID_Personal, UserName, Pass, Last_Login, Estado) 
    
    VALUES 
    (
	@ID_Personal,
    @UserName,
    @Pass,
    @Last_Login,
    @Estado
	 )
END
go
---------------------------------------------------------------------3

CREATE PROCEDURE [dbo].[SP_AGREGAR_NOMINA]
(
@Nombre varchar(30),
@Fecha_Inicio date,
@Fecha_Fin date,
@Descripcion varchar(50)
)
AS
BEGIN
INSERT INTO NOMINA 
    (Nombre, Fecha_Inicio, Fecha_Fin, Descripcion) 
    
    VALUES 
    (
	@Nombre,
    @Fecha_Inicio,
    @Fecha_Fin,
    @Descripcion
	 )
END
go
--------------------------------------------------------------------4

CREATE PROCEDURE [dbo].[SP_AGREGAR_PARTICIPANTES]
(
@ID_Reclutamiento int,
@Cedula_ varchar(20),
@Nombre varchar(30),
@Apellido_1 varchar(30),
@Apellido_2 varchar(30),
@Correo varchar(100),
@Telefono varchar(8),
@ID_Provincia int,
@ID_Canton int,
@ID_Distrito int,
@Direccion varchar(150),
@Estado int
)
AS
BEGIN
INSERT INTO PARTICIPANTES 
    (ID_Reclutamiento, Cedula_, Nombre, Apellido_1, Apellido_2, Correo, Telefono, ID_Provincia,
	ID_Canton, ID_Distrito, Direccion, Estado) 
    
    VALUES 
    (
	@ID_Reclutamiento,
    @Cedula_,
    @Nombre,
    @Apellido_1,
    @Apellido_2,
    @Correo,
    @Telefono,
    @ID_Provincia,
    @ID_Canton,
    @ID_Distrito,
    @Direccion,
    @Estado 
	 )
END
go
----------------------------------------------------------------------5

CREATE PROCEDURE [dbo].[SP_AGREGAR_MARCAS]
(
@ID_Personal int,
@Fecha date,
@Hora time(7),
@Tipo tinyint
)
AS
BEGIN
INSERT INTO MARCAS 
    (ID_Personal, Fecha, Hora, Tipo) 
    
    VALUES 
    (
	@ID_Personal,
    @Fecha,
    @Hora,
    @Tipo
	 )
END
go
 
-----------------------------------------------------------------------6

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PERSONAL]
@ID_Personal int,
@ID_Puesto int,
@Cedula varchar(20),
@Nombre varchar(30),
@Apellido_1 varchar(30),
@Apellido_2 varchar(30),
@Salario_Hora decimal(10,2),
@Salario_Mensual decimal(10,2),
@Fecha_Contratacion date,
@Estado int,
@Direccion varchar(150),
@Correo_Electronico varchar(50),
@Telefono varchar(50)
AS
BEGIN
	Update PERSONAL
	Set ID_Puesto = @ID_Puesto, Cedula = @Cedula, Nombre = @Nombre, Apellido_1 = @Apellido_1, Apellido_2 
	= @Apellido_2, Salario_Hora = @Salario_Hora, Salario_Mensual = @Salario_Mensual, Fecha_Contratacion 
	= @Fecha_Contratacion, Estado = @Estado, Direccion = @Direccion, Correo_Electronico = @Correo_Electronico,
	Telefono = @Telefono
	where ID_Personal = @ID_Personal
	
END
go
-------------------------------------------------------------------7

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado_Personal]
AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 5 OR [ID_Estados]= 6 OR [ID_Estados]= 7
END
go
----------------------------------------------------------------------8

CREATE PROCEDURE [dbo].[SP_PA_USUARIOIDPERSONAL]
AS
BEGIN
SELECT [ID_Personal],
       [Cedula]      
      
  FROM [dbo].[PERSONAL]
END
go

exec SP_PA_USUARIOIDPERSONAL
go
------------------------------------------------------------------------9

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado_Usuario]
AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 8 OR [ID_Estados]= 9 OR [ID_Estados]= 10
END
go
exec SP_PA_Tipo_Estado_Usuario
GO
--------------------------------------------------------------------------10

---------------------------------------------------------------------14

CREATE PROCEDURE [dbo].[SP_IDRECLUTAMIENTO_POSTULANTES]
AS
BEGIN
SELECT [ID_Reclutamiento],
       [Nombre]      
      
  FROM [dbo].[RECLUTAMIENTO]
END
go
exec SP_IDRECLUTAMIENTO_POSTULANTES
go
---------------------------------------------------------------------------15

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado_Postulantes]
AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 18 OR [ID_Estados]= 19
END
go
exec SP_PA_Tipo_Estado_Postulantes
go
------------------------------------------------------------------------------16

CREATE PROCEDURE [dbo].[SP_MODIFICAR_USUARIOS]
@ID_Usuario int,
@ID_Personal int,
@UserName varchar(20),
@Pass varchar(20),
@Estado int
AS
BEGIN
	Update USUARIOS
	Set ID_Personal = @ID_Personal, UserName = @UserName, Pass = @Pass,  Estado = @Estado
	where ID_Usuario = @ID_Usuario
END
go
--------------------------------------------------------------------------------------------------17

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PARTICIPANTES]
@Reclutamiento int,
@Ced varchar(20),
@Nomb varchar(30),
@Apell1 varchar(30),
@Apell2 varchar (30),
@Corre varchar (100),
@Tel varchar (8),
@Provincia int,
@Canton int,
@Distrito int,
@Direc varchar (150),
@Est int
AS
BEGIN
	SET NOCOUNT ON;
	Update PARTICIPANTES 
	Set ID_Reclutamiento = @Reclutamiento, Cedula_ =  @Ced, Nombre = @Nomb, Apellido_1 = @Apell1,
    Apellido_2 = @Apell2, Correo = @Corre, Telefono = @Tel, ID_Provincia = @Provincia,
    ID_Canton = @Canton, ID_Distrito = @Distrito, Direccion = @Direc, Estado = @Est
	where ID_Reclutamiento = @Reclutamiento
END
go
---------------------------------------------------------------------------------------------------------18

CREATE PROCEDURE [dbo].[SP_PA_NotasIdPruebas]
AS
BEGIN
SELECT [ID_Pruebas],
       [Nombre]      
      
  FROM [dbo].[PRUEBAS]
END
go

EXEC SP_PA_NotasIdPruebas
go
----------------------------------------------------------------------19

CREATE PROCEDURE [dbo].[SP_PA_NotasIdParticipantes]
AS
BEGIN
SELECT [ID_Participantes],
       [Cedula_]      
      
  FROM [dbo].[PARTICIPANTES]
END
go

EXEC SP_PA_NotasIdParticipantes
go
------------------------------------------------------------------20
--select * from PRUEBAS_PARTICIPANTES
--delete from PRUEBAS_PARTICIPANTES
--alter table PRUEBAS_PARTICIPANTES drop column Nota;
--alter table PRUEBAS_PARTICIPANTES add nota int null;
--drop proc [dbo].[SP_AGREGAR_PRUEBAS_PARTICIPANTES]
CREATE PROCEDURE [dbo].[SP_AGREGAR_PRUEBAS_PARTICIPANTES]
(
@ID_Pruebas int,
@ID_Participantes int,
@Nota int
)
AS
BEGIN
INSERT INTO PRUEBAS_PARTICIPANTES 
    (ID_Pruebas, ID_Participantes, Nota) 
    VALUES 
    (
	@ID_Pruebas,
    @ID_Participantes,
    @Nota
	 )
END
go
--------------------------------------------------------------------21

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PARTICIPANTES2]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT ID_Participantes
      ,ID_Reclutamiento
      ,Cedula_
      ,Nombre
      ,Apellido_1

      ,Apellido_2
      ,Correo
      ,Telefono
      ,ID_Provincia
      ,ID_Canton
      ,ID_Distrito
      ,Direccion
      ,Estado 
      
  FROM [dbo].[PARTICIPANTES]
   WHERE [Cedula_] LIKE '%' + @Cedula + '%' or [Nombre] LIKE '%' + @Cedula + '%'
END
go
---------------------------------------------------------------------------------------22

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PARTICIPANTES]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT P.ID_Participantes
      ,PRE.Nombre
      ,P.Cedula_
      ,P.Nombre
      ,P.Apellido_1
      ,P.Apellido_2
      ,P.Correo
      ,P.Telefono
      ,PR.Nombre
      ,PC.Nombre
      ,PD.Nombre
      ,P.Direccion
      ,PE.Nombre    
      
  FROM dbo.PARTICIPANTES P
      inner join RECLUTAMIENTO PRE on P.ID_Reclutamiento = PRE.ID_Reclutamiento 
      inner join PROVINCIAS PR on P.ID_Provincia = PR.ID_Provincias
      inner join CANTONES PC ON P.ID_Canton = PC.ID_Cantones
	  inner join DISTRITOS PD on P.ID_Distrito = PD.ID_Distritos
	  inner join ESTADOS PE on P.Estado = PE.ID_Estados 
      WHERE [Cedula_] LIKE '%' + @Cedula + '%' or P.[Nombre] LIKE '%' + @Cedula + '%'
 
END
GO
-------------------------------------------------------------------------------------------23

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PERSONAL]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT P.ID_Personal
      ,PP.Nombre
      ,P.Cedula
      ,P.Nombre
      ,P.Apellido_1
      ,P.Apellido_2
      ,P.Salario_Hora
      ,P.Salario_Mensual
      ,P.Fecha_Contratacion
      ,PE.Nombre
      ,P.Direccion
      ,P.Correo_Electronico
      ,P.Telefono    
      
  FROM dbo.PERSONAL P
      inner join PUESTOS PP on P.ID_Puesto = PP.ID_Puestos 
	  inner join ESTADOS PE on P.Estado = PE.ID_Estados
      WHERE [Cedula] LIKE '%' + @Cedula + '%' or P.[Nombre] LIKE '%' + @Cedula + '%'
 
END
GO
-------------------------------------------------------------------------------------------24

CREATE PROCEDURE [dbo].[SP_AGREGAR_PRUEBAS]
(
@Nombre varchar(30),
@Descripcion varchar(100)
)
AS
BEGIN
INSERT INTO PRUEBAS 
    (Nombre,Descripcion) 
    
    VALUES 
    (@Nombre ,
     @Descripcion)
END
go
----------------------------------------------------------------------------------------25

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PRUEBAS]
@ID_Pruebas int,
@Nombre varchar (30),
@Descripcion varchar(100)
AS
BEGIN
	Update PRUEBAS
	Set Nombre = @Nombre, Descripcion = @Descripcion
	where ID_Pruebas = @ID_Pruebas
END
go
---------------------------------------------------------------------------------------26

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Cargo]
AS
BEGIN
SELECT [ID_Puestos]
      ,[Nombre]      
      
  FROM [dbo].[PUESTOS]
   WHERE [ID_Puestos]= 1 OR [ID_Puestos]= 2 OR [ID_Puestos]= 3 OR [ID_Puestos]= 4
   OR [ID_Puestos]= 5 OR [ID_Puestos]= 6 OR [ID_Puestos]= 7 OR [ID_Puestos]= 8
    OR [ID_Puestos]= 9 OR [ID_Puestos]= 10 OR [ID_Puestos]= 11 OR [ID_Puestos]= 12
	 OR [ID_Puestos]= 13 OR [ID_Puestos]= 14 OR [ID_Puestos]= 15 OR [ID_Puestos]= 16
END
go
----------------------------------------------------------------------------------------------27

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 11 OR [ID_Estados]= 15 OR [ID_Estados]= 16 OR [ID_Estados]= 17
END
go
-----------------------------------------------------------------------------------------------28

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Puesto]

AS
BEGIN
SELECT [ID_Departamento]
      ,[Nombre]      
      
  FROM [dbo].[DEPARTAMENTOS]
   WHERE [ID_Departamento]= 1 OR [ID_Departamento]= 2 OR [ID_Departamento]= 3 OR [ID_Departamento]= 4
   OR [ID_Departamento]= 5 OR [ID_Departamento]= 6 OR [ID_Departamento]= 7 OR [ID_Departamento]= 8
END
-----------------------------------------------------------------------------------------------------------29








