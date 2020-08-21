USE [VETERINARIA_EL_BOSQUE]
GO
create procedure [dbo].[sp_consultar_todos_articulos]
as
begin
	select * from dbo.SOLICITUD_ARTICULOS;
end
go

create procedure [dbo].[sp_consultar_articulos_id]
(
@ID_ARTICULO INT
)
as
begin
	select * from dbo.SOLICITUD_ARTICULOS where ID_Solicitud_Articulos like @ID_ARTICULO;
end
go

create procedure [dbo].[sp_consultar_articulo_proveedor]
as
begin
	select Descripcion from dbo.ARTICULOS_PROVEEDOR;
end
go

create procedure [dbo].[sp_actualizar_articulo]
(
@ID_Solicitud_Articulo int,
@ID_Articulo_Proveedor int,
@ID_Solicitud_Compra int,
@Descripcion varchar(100),
@Cantidad decimal(10,2)
)
as
begin 
	update dbo.SOLICITUD_ARTICULOS
	set
	ID_Articulo_Proveedor = @ID_Articulo_Proveedor,
	ID_Solicitud_Compra = @ID_Solicitud_Compra,
	Descripcion = @Descripcion,
	Cantidad = @Cantidad
	where ID_Solicitud_Articulos = @ID_Solicitud_Articulo
end
go

create procedure [dbo].[sp_consultar_despacho]
as
begin
	select * from dbo.DESPACHO;
end
go

create procedure [dbo].[sp_consultar_despacho_id]
(
@ID_DESPACHO INT
)
as
begin
	select * from dbo.DESPACHO where ID_Despacho like @ID_DESPACHO;
end
go

create procedure [dbo].[sp_agregar_despacho]
(
@ID_Factura int,
@Fecha date,
@Estado int
)
as
begin 
	 insert into dbo.DESPACHO
	 (ID_Factura, Fecha, Estado)
	 values(@ID_Factura, @Fecha, @Estado)
end
go

create procedure [dbo].[sp_consultar_estados]
as
begin
	select * from dbo.ESTADOS;
end
go

create procedure [dbo].[sp_actualizar_despacho]
(
@ID_despacho int,
@ID_factura int,
@fecha date,
@Estado int
)
as
begin 
	update dbo.DESPACHO
	set
	ID_Factura = @ID_factura,
	Fecha = @fecha,
	Estado = @Estado
	where ID_Despacho = @ID_despacho
end
go
