USE [VETERINARIA_EL_BOSQUE]
GO

ALTER TABLE [dbo].[CREDITOS] ADD Abono DECIMAL(10,2) NULL
GO

CREATE PROCEDURE [dbo].[MODIFICAR_ABONOS]
(
@ID_Factura int,
@Monto_Anterior decimal,
@Abono decimal,
@Monto_Actual decimal
)
as
begin
INSERT INTO [dbo].[CREDITOS]
           ([ID_Factura]
           ,[Monto_Anterior]
		   ,[Abono]
		   ,[Monto_Actual] )       
     VALUES
           (@ID_Factura,@Monto_Anterior,@Abono,@Monto_Actual)
END
GO






USE [VETERINARIA_EL_BOSQUE]
GO

create PROCEDURE [dbo].[SP_CONSULTAR_RESULTADOSexamenes_POR_CITAS]

AS
BEGIN
SELECT O.Resultado,
	   P.Nombre
	   
	  
	  FROM [dbo].[RESULTADO_LABORATORIO] O 
	    inner join CITAS c on O.ID_Cita=c.ID_Cita
		INNER JOIN PRUEBAS_LABORATORIO P on 
		o.ID_Pruebas_Laboratorio= P.ID_Pruebas_Laboratorio
        WHERE c.Estado=2 
		end
go





CREATE PROCEDURE [dbo].[SP_AGREGAR_FACTURA]
(
@idCliente int,
@idCaja int,
@numeroFactura int,
@fecha date,
@descripcion varchar(100),
@total decimal,
@tipoPago tinyint,
@estado int
)
AS
BEGIN
INSERT INTO [dbo].[FACTURAS]
           ([ID_Cliente]
           ,[ID_Caja]
           ,[Numero_Factura]
           ,[Fecha]
           ,[Descripcion]
           ,[Total]
           ,[Tipo_Pago]
           ,[Estado])
    VALUES 
    (@idCliente,
    @idCaja,
    @numeroFactura,
    @fecha,
    @descripcion,
    @total,
    @tipoPago,
    @estado )
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS]
(
@Nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Articulos]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]
      ,[Estado]
  FROM [dbo].[ARTICULOS]
   WHERE [Nombre] LIKE '%' + @Nombre + '%'
   END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CAJAS]
(
@ID_Caja int
)
AS
BEGIN
SELECT [ID_Caja]      
      ,[Estado]
  FROM [dbo].[CAJAS]

   WHERE ID_Caja = @ID_Caja
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT [ID_Cliente]
      ,[Cedula]
      ,[Nombre]
      ,[Apellido_1]
      ,[Apellido_2]      
      
  FROM [dbo].[CLIENTES]
   WHERE [Cedula] LIKE '%' + @Cedula + '%' or [Nombre] LIKE '%' + @Cedula + '%'
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES_FACTURA]
(
@Nombre varchar(20)
)
AS
BEGIN
SELECT [ID_Cliente]
      ,[Cedula]
      ,[Nombre]
      ,[Apellido_1]
      ,[Apellido_2]     
	  ,[Correo]
	  ,[Telefono]
	  ,[Credito]
      
  FROM [dbo].[CLIENTES]
   WHERE [Nombre] LIKE '%' + @Nombre + '%'
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_COBROS]
(
@Nom varchar(50)
)
AS
BEGIN
 
 SELECT c.Cedula,c.Nombre,c.Apellido_1,c.Apellido_2,Fecha,f.Numero_Factura,f.Total,f.Estado,f.Tipo_Pago,cr.Monto_Actual from CLIENTES AS c inner join FACTURAS AS f on c.ID_Cliente= f.ID_Cliente inner join CREDITOS AS cr on f.Numero_Factura =cr.ID_Factura
  WHERE F.Estado NOT IN('21')AND F.Estado NOT IN ('37') AND c.Nombre LIKE '%' + @Nom + '%'
 
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_COBROS_CONTADO]
(
@Nom varchar(50)
)
AS
BEGIN
 
 SELECT c.Cedula,c.Nombre,c.Apellido_1,c.Apellido_2,Fecha,f.Numero_Factura,f.Total,f.Estado,f.Tipo_Pago from CLIENTES AS c inner join FACTURAS AS f on c.ID_Cliente= f.ID_Cliente
 WHERE F.Estado NOT IN('21')AND F.Estado NOT IN ('37') AND f.Tipo_Pago NOT IN ('2') AND c.Nombre LIKE '%' + @Nom + '%'
 
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_COBROS_Credito]
(
@Nom varchar(50)
)
AS
BEGIN
 SELECT c.Cedula, c.Nombre, c.Apellido_1, c.Apellido_2, Fecha, cr.ID_Factura AS Factura, f.total AS Total, f.Estado, f.Tipo_Pago, MIN(CR.Monto_Actual) as Monto_Actual
FROM CLIENTES AS c inner join FACTURAS AS f ON c.ID_Cliente = f.ID_Cliente inner join CREDITOS AS cr ON cr.ID_Factura = f.Numero_Factura
WHERE F.Estado NOT IN('21') AND F.Estado NOT IN ('37') AND f.Tipo_Pago NOT IN ('1')AND c.Nombre LIKE '%' + @Nom + '%'
GROUP BY cr.ID_Factura, c.Cedula, c.Nombre, c.Apellido_1, c.Apellido_2, Fecha, f.Estado, f.Tipo_Pago, f.Total 
END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_EXPRESS]
(
@Estado int
)
AS
BEGIN
SELECT E.ID_Servicios,E.ID_Factura as Factura,E.Descripcion,E.Estado,F.Fecha,C.Nombre,C.Apellido_1 AS PrimerApellido,C.Apellido_2 AS SegundoApellido  FROM SERVICIOS_EXPRESS AS E INNER JOIN FACTURAS AS F on F.ID_Facturas= E.ID_Factura INNER JOIN CLIENTES AS C ON F.ID_Cliente= C.ID_Cliente
  WHERE E.Estado =@Estado
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_FACTURAS]
(
@ID_Facturas int

)
AS
BEGIN
SELECT [ID_Facturas]
      ,[ID_Cliente]
      ,[ID_Caja]
      ,[Numero_Factura]
      ,[Fecha]
      ,[Descripcion]
      ,[Total]
      ,[Tipo_Pago]
      ,[Estado]
  FROM [dbo].[FACTURAS]
  WHERE [ID_Facturas] = @ID_Facturas
  END 
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_INVENTARIO]
(
@Nom varchar(50)
)
AS
BEGIN
 
 select i.ID_Articulos,a.Nombre,a.Precio,i.Cantidad,i.Estado from dbo.INVENTARIO i
  inner join dbo.ARTICULOS a on i.ID_Articulos = a.ID_Articulos  WHERE a.Nombre LIKE '%' + @Nom + '%'
 end
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_NoFactura]
AS
BEGIN
SELECT MAX(Numero_Factura)        
  FROM [dbo].[FACTURAS] 
  END 
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRODUCTOS]
(
@Nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Articulos]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]
      ,[Estado]
  FROM [dbo].[ARTICULOS]
   WHERE [Nombre] LIKE '%' + @Nombre + '%'
   END
GO


CREATE PROCEDURE [dbo].[SP_CREAR_ARTICULOS]
(
@Nombre varchar(20),
@Descripcion varchar(100),
@Precio decimal(10,2),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[ARTICULOS]
           ([Nombre]
           ,[Descripcion]
           ,[Precio]
           ,[Estado])
     VALUES
           (@Nombre
           ,@Descripcion
           ,@Precio
           ,@Estado)
END
GO

CREATE PROCEDURE [dbo].[SP_CREAR_CAJAS]
(
@ID_Personal int,
@Nombre varchar(50),
@Descripcion varchar(50),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[CAJAS]
           ([ID_Personal]
           ,[Nombre]
           ,[Descripcion]
           ,[Estado])
     VALUES
           (1,'Caja1','Caja1',22 )

END
GO


CREATE PROCEDURE [dbo].[SP_CREAR_INVENTARIO]
(

@ID_ARTICULO int,
@Cantidad decimal,
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[INVENTARIO]
           ([ID_Articulos]
           ,[Cantidad]
    
           ,[Estado])
     VALUES
           (@ID_ARTICULO
           ,@Cantidad
           
           ,@Estado)
END
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_CREDITOS]
(
@ID_Factura int,
@Monto_Anterior decimal,
@Monto_Actual decimal
)
AS
BEGIN
INSERT INTO [dbo].[CREDITOS]
           ([ID_Factura]
           ,[Monto_Anterior]
           ,[Monto_Actual])
     VALUES
           (@ID_Factura,@Monto_Anterior,@Monto_Actual)
END
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE_ARTICULOS]
(

@ID_Factura int,
@ID_Articulos int,
@Cantidad decimal(10,2)

)
AS
BEGIN
INSERT INTO [dbo].[DETALLE_ARTICULOS]
           ([ID_Factura]
           ,[ID_Articulos]
           ,[Cantidad])
     VALUES
           (@ID_Factura,@ID_Articulos,@Cantidad)
END
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_EXPRESS]
(
@ID_Factura int, 
@Descripcion varchar(150),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[SERVICIOS_EXPRESS]
           ([ID_Factura]
           ,[Descripcion]
           ,[Estado])
     VALUES
           (@ID_Factura,@Descripcion,@Estado)
END
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_CREDITOS]
(
@Cedula varchar(20),
@Credito int
)
AS
BEGIN
UPDATE [dbo].[CLIENTES]
   SET [Credito] = @Credito
 WHERE [Cedula]= @Cedula
 END
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_ESTADO_CAJAS]
(
@ID_Caja int,
@ID_Estado int
)
AS
BEGIN
UPDATE [dbo].[CAJAS]
   SET[Estado]=@ID_Estado
 WHERE ID_Caja = @ID_Caja
 END
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_EXPRESS]
(
@ID_Factura int,
@Estado int
)
AS
BEGIN
UPDATE [dbo].[SERVICIOS_EXPRESS]
   SET [Estado] = @Estado
 WHERE [ID_Factura]=@ID_Factura
 END
GO


CREATE PROCEDURE [dbo].[SP_MODIFICAR_FACTURAS]
(
@Numero_Factura int,
@Estado int
)
AS
BEGIN
UPDATE [dbo].[FACTURAS]
   SET [Estado] = @Estado
 WHERE [Numero_Factura]=@Numero_Factura
 END
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_INVENTARIO]
(
@ID_Articulos int,
@Cantidad decimal
)
AS
BEGIN
UPDATE [dbo].[INVENTARIO]
   SET [Cantidad] = @Cantidad   
   
 WHERE ID_Articulos= @ID_Articulos
 END
GO

CREATE PROCEDURE [dbo].[SP_Vista_Factura]
(@Factura INT)
AS
BEGIN
	SELECT 
		cl.Nombre, 
		cl.Apellido_1, 
		cl.Apellido_2, 
		fa.Fecha, 
		fa.Numero_Factura, 
		ar.Nombre, 
		ar.Precio, 
		da.Cantidad, 
		fa.Total 

FROM FACTURAS AS fa inner join DETALLE_ARTICULOS AS da on fa.Numero_Factura = da.ID_Factura 
					inner join ARTICULOS AS ar on ar.ID_Articulos = da.ID_Articulos
					inner join CLIENTES AS cl on fa.ID_Cliente = cl.ID_Cliente
where fa.Numero_Factura = @Factura
END
GO
-----------------------------------------------------------------------------------------------------------------------------------
-------AQUI INICIA LOS SP DE CARLOS------------------------------------

USE [VETERINARIA_EL_BOSQUE]
GO

CREATE PROCEDURE [dbo].[PA_Clientes_Eliminar]
@cedula varchar(15)
AS
BEGIN
	DELETE FROM CLIENTES
	WHERE Cedula = @cedula
END
GO


CREATE PROCEDURE [dbo].[PA_Clientes_Modificar]
@ced varchar(20),
@nombre varchar(50),
@ape1   varchar(50),
@ape2  varchar(50),
@correo  varchar(50),
@telefono  varchar(20),
@prov  int,
@cant  int,
@dis   int,
@direccion  varchar(150)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE CLIENTES
	SET Cedula=@ced, Nombre=@nombre,Apellido_1=@ape1,Apellido_2=@ape2,Correo=@correo,Telefono=@telefono,
	ID_Provincias=@prov,ID_Cantones=@cant, ID_Distritos=@dis,Direccion=@direccion
	WHERE Cedula = @ced
END
GO

CREATE PROCEDURE [dbo].[PA_TipoMascota_Consultar]

AS
BEGIN	
	SET NOCOUNT ON;	
	SELECT ID_Tipo_Animal, Tipo 
	FROM   dbo.TIPO_ANIMAL
	END
GO


CREATE PROCEDURE [dbo].[PA_Usuarios_Eliminar]
@cedula varchar(15)
AS
BEGIN
	DELETE FROM CLIENTES
	WHERE Cedula = @cedula
END
GO


CREATE PROCEDURE [dbo].[SP_AGREGAR_CLIENTES]
(
@ced int,
@nom varchar(20),
@ape1 varchar(50),
@ape2 varchar(50),
@correo varchar(50),
@tel varchar(50),
@provincia int,
@canton int,
@distrito int,
@dire varchar(150),
@est int

)
AS
BEGIN
INSERT INTO CLIENTES 
	(Cedula,Nombre,Apellido_1,Apellido_2,Correo,Telefono,ID_Provincias,ID_Cantones,ID_Distritos,Direccion,Estado) 
	
	VALUES 
	(@ced ,
     @nom ,
	 @ape1 ,
	 @ape2 ,
	 @correo,
	 @tel ,
	 @provincia ,
	 @canton ,
	 @distrito ,
	 @dire ,
	 @est )
END
GO

CREATE PROCEDURE [dbo].[SP_AGREGAR_OBSERVACIONES]
(
@idcita int,
@des varchar(100)
)
AS
BEGIN
INSERT INTO OBSERVACIONES 
	(ID_Cita,Descripcion) 
	VALUES 
	(@idcita ,
     @des )
END
GO

CREATE PROCEDURE [dbo].[SP_AGREGAR_RESULTADOS_EXAMENES]
(
@idPrueba int,
@idcita int,
@resultado varchar(50),
@estado int
)
AS
BEGIN
INSERT INTO RESULTADO_LABORATORIO 
	(ID_Pruebas_Laboratorio,ID_Cita,Resultado,Estado) 
	
	VALUES 
	(@idPrueba ,
     @idcita ,
	 @resultado ,
	 @estado 
	 )
END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CANTONES_POR_PROVINCIA]
(
@PROV int
)
AS
BEGIN
SELECT ID_Cantones 
      ,[Nombre]      
      
   FROM [dbo].[CANTONES]
   WHERE [ID_Provincias]= @PROV
END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CITAS_EN_CURSO]

AS
BEGIN
SELECT C.ID_Cita,
       C.ID_Mascota, 
       M.Nombre    
      
   FROM [dbo].[CITAS] C INNER JOIN MASCOTAS M ON
   C.ID_Mascota=M.ID_Mascota
   WHERE C.[Estado]= 2
END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES_PANTALLACLIENTE]
(
@Cedula varchar(20)
)
AS
BEGIN
select C.ID_Cliente,
       C.Cedula,
	   C.Nombre,
	   C.Apellido_1,
	   C.Apellido_2,
	   C.Correo,
       C.Telefono,
	   P.Nombre,
	   CA.Nombre,
	   D.Nombre,
	   C.Direccion,
	   E.Nombre
      from CLIENTES C inner join PROVINCIAS P on C.ID_Provincias=P.ID_Provincias
      inner join CANTONES CA ON C.ID_Cantones=CA.ID_Cantones 
	  inner join DISTRITOS D on C.ID_Distritos=D.ID_Distritos
	  inner join ESTADOS E on C.Estado= E.ID_Estados 
      WHERE [Cedula] LIKE '%' + @Cedula + '%' or C.[Nombre] LIKE '%' + @Cedula + '%'

END

GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_DISTRITOS_POR_CANTON]
(
@CAN int
)
AS
BEGIN
SELECT [ID_Distritos] 
      ,[Nombre]      
      
   FROM [dbo].[DISTRITOS]
   WHERE [ID_Cantones]= @CAN
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTADOS_EXAMENES]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 23 OR [ID_Estados]= 24 OR [ID_Estados]= 25
   

END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTADOS_MASCOTAS]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 29 OR [ID_Estados]= 30 OR [ID_Estados]= 31
   OR [ID_Estados]= 32

END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTADOSCLIENTES]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 5 OR [ID_Estados]= 33
END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_IdCanton]
(
@nombreCanton varchar(20)
)
AS
BEGIN
SELECT [ID_Cantones]
      
  FROM [dbo].[CANTONES]
   WHERE [Nombre] =@nombreCanton
END

GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_Mascotas]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT M.[ID_Mascota],
       M.[ID_Cliente],
       M.[Nombre]
      ,TA.[Tipo]
	  ,M.[Raza]
      ,M.[Sexo]   
	  
      
  FROM [dbo].[MASCOTAS] M INNER JOIN [TIPO_ANIMAL] TA
  on M.Tipo_Animal=TA.ID_Tipo_Animal
   WHERE [Nombre] LIKE '%' + @nombre + '%' 
END
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_MEDICAMENTOS]

AS
BEGIN
 
 select A.ID_Articulos, A.Nombre from dbo.ARTICULOS A
  inner join dbo.INVENTARIO I on I.ID_Articulos=A.ID_Articulos  WHERE I.Estado=13 AND A.Descripcion='Medicamentos' 

 end
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_OBSERVACIONES_POR_CITAS]

AS
BEGIN
SELECT O.ID_Cita,
	   O.Descripcion
	  FROM [dbo].[OBSERVACIONES] O 
	    inner join CITAS c on O.ID_Cita=c.ID_Cita
  
   WHERE c.Estado=2
   END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_PROVINCIA]

AS
BEGIN
SELECT [ID_Provincias]
      ,[Nombre]      
      
  FROM [dbo].[PROVINCIAS]
 
END
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRUEBAS_LABORATORIO]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Pruebas_Laboratorio]
      ,[Nombre]
      ,[Descripcion]
      FROM [dbo].[PRUEBAS_LABORATORIO]
   WHERE [Nombre]=@nombre
END
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]      
      
  FROM [dbo].[SERVICIOS]
   WHERE [Nombre]=@nombre
END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_CIRUGIA]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]      
      
  FROM [dbo].[SERVICIOS]
   WHERE [Nombre]=@nombre
END

GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_CIRUJIAS_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios] BETWEEN  19 AND 25
	
	END
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_EXAMENES_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios] BETWEEN  13 AND 18
	
	END
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios]=1 or [ID_Servicios]=2 or [ID_Servicios]=3 or [ID_Servicios]=4
END
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_VACUNAS_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios] BETWEEN  5 AND 12
	
	END
GO


CREATE PROCEDURE [dbo].[SP_CREAR_MASCOTA]
(
@IdCliente int,
@Nombre varchar(50),
@Tipo int,
@Raza varchar(50),
@Sexo varchar(30),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[MASCOTAS]
           ([ID_Cliente]
           ,[Nombre]
           ,[Tipo_Animal]
           ,[Raza]
		   ,[Sexo]
		   ,[Estado]
		   
		   )
     VALUES
           (@IdCliente ,
            @Nombre ,
            @Tipo ,
            @Raza ,
            @Sexo ,
            @Estado )
END
GO


CREATE PROCEDURE [dbo].[SP_Mascotas_Eliminar]
@idMascota varchar(15)
AS
BEGIN
	DELETE FROM MASCOTAS
	WHERE  ID_Mascota= @idMascota
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_MASCOTAS_PRECONSULTA]    Script Date: 19/8/2020 21:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_MASCOTAS_PRECONSULTA]
@id int,
@Tama decimal(10,2),
@Est int,
@Edad int,
@Peso decimal(10,2)

AS
BEGIN
	UPDATE MASCOTAS
	SET 
	Tamaño=@Tama,
    Estado=@Est,
	
	Edad=@Edad,
	Peso=@Peso
  --  Estado=@Estado
	WHERE ID_MASCOTA = @id
END
GO



INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Limpieza oidos','1',5000.00) 

INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Desparacitación','1',5000.00)

INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Limpieza dental','1',5000.00) 

INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Corte uñas','1',5000.00)
 

 INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Rinotraqueitis','1',6500.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Panleucopenia','1',6500.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Parvovirosis','1',8550.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Rabia','1',9800.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Leptospirosis','1',9800.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('tetravalente','1',11800.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Moquillo','1',11800.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Panleucopenia','1',11800.00)

 

--examenes
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Sanguíneo','1',22000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Disbiosis','1',35000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Citología','1',38000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Raspados de piel','1',22800.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Heces','1',7500.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Orina','1',5050.00)


--Cirujias
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Oncológica ','1',55000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Cataratas','1',78000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Digestiva','1',95000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Traumatológica ','1',46000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Hernias','1',34400.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Urinario','1',68000.00)
INSERT INTO SERVICIOS(Nombre,Descripcion,Precio) VALUES
('Cesáreas','1',49000.00)
 



 --PRUEBA LABORATORIO
INSERT INTO PRUEBAS_LABORATORIO(Nombre,Descripcion) VALUES
('Sanguíneo','13')
INSERT INTO PRUEBAS_LABORATORIO(Nombre,Descripcion) VALUES
('Disbiosis','14')
INSERT INTO PRUEBAS_LABORATORIO(Nombre,Descripcion) VALUES
('Citología','15')
INSERT INTO PRUEBAS_LABORATORIO(Nombre,Descripcion) VALUES
('Raspados de piel','16')
INSERT INTO PRUEBAS_LABORATORIO(Nombre,Descripcion) VALUES
('Heces','17')
INSERT INTO PRUEBAS_LABORATORIO(Nombre,Descripcion) VALUES
('Orina','18')


--Medicamentos
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Hyalorcal 25 mg ','Medicamentos',5000.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Apoquel 30 mg','Medicamentos',780.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Total f Perros grandes','Medicamentos',6550.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Total f Perros medianos','Medicamentos',4600.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Total f Perros pequeños','Medicamentos',3440.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Aciflux 500 mg','Medicamentos',5800.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Analgésico 250 mg','Medicamentos',4000.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Analgésico 750 mg','Medicamentos',5700.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Dog chow 1kg','Alimentos',5700.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Ascan 5kg','Alimentos',5700.00,1)
INSERT INTO ARTICULOS(Nombre,Descripcion,Precio,Estado) VALUES
('Super Perro 10kg','Alimentos',5700.00,1)

EXECUTE SP_CREAR_INVENTARIO 1,49,13
EXECUTE SP_CREAR_INVENTARIO 2,49,13
EXECUTE SP_CREAR_INVENTARIO 3,49,13
EXECUTE SP_CREAR_INVENTARIO 4,49,13
EXECUTE SP_CREAR_INVENTARIO 5,49,13
EXECUTE SP_CREAR_INVENTARIO 6,49,13
EXECUTE SP_CREAR_INVENTARIO 7,49,13
EXECUTE SP_CREAR_INVENTARIO 8,49,13
EXECUTE SP_CREAR_INVENTARIO 9,49,13
EXECUTE SP_CREAR_INVENTARIO 10,49,13
EXECUTE SP_CREAR_INVENTARIO 11,49,13

EXECUTE SP_CREAR_CAJAS 1,'CAJA1','CREAR',22
execute SP_AGREGAR_CLIENTES 123456789,'Pedro','Mora','Rojas','pedro@gmail.com','88882020',1,1,561,'25 este de la plaza',5
EXECUTE SP_AGREGAR_FACTURA 1,1,0,'2020-08-21','prueba',1000,1,21
EXECUTE SP_INSERTAR_DETALLE_ARTICULOS 1,1,1

