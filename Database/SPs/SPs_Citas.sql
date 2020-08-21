
-- SP para consultar los consultorios
create proc SP_Consulta_Consultorios
AS
begin
select [ID_Consultorio],[Nombre] from CONSULTORIO
end 
go

-- SP para consultar los motivos
create proc SP_Consulta_Motivos
AS
begin
select [ID_Motivo_Cita],[Nombre] from MOTIVO_CITA
end 
go



--SP para crear citas

CREATE PROC SP_Insertar_Cita 
@id_mascota int, 
@id_consultorio int,
@id_Motivo int,
@Fecha_Inicio date,
@Hora_Inicio time,
@Hora_Fin time,
@Estado int
AS
begin
INSERT INTO CITAS 
(ID_Mascota,ID_Consultorio,ID_Motivo_Cita,Fecha_Inicio,Fecha_Fin,Hora_Inicio,Hora_Fin,Estado)
values (@id_mascota,@id_consultorio,@id_Motivo,@Fecha_Inicio,@Fecha_Inicio,@Hora_Inicio,@Hora_Fin,@Estado)
end
go

-- SP Actualizar Estado Cita
CREATE PROC SP_Actualizar_Estado_Cita @id_cita int,@id_estado int
AS
BEGIN
update CITAS set Estado = @id_estado where ID_Cita = @id_cita
end
go

--SP para cargar todas las citas
CREATE PROC SP_Consulta_Citas
as
begin
SELECT ct.ID_Cita, 
		m.ID_Mascota,
		m.Nombre,
		ct.ID_Consultorio, 
		ct.ID_Motivo_Cita,
		mc.Nombre,
		ct.Fecha_Inicio,
		ct.Hora_Inicio,
		ct.Hora_Fin,
		ct.Estado, 
		e.Nombre,
		CONCAT(c.Nombre,' ',c.Apellido_1,' ',c.Apellido_2) Cliente
			FROM CLIENTES c, 
				MASCOTAS m, 
				citas ct,
				MOTIVO_CITA mc,
				ESTADOS e
			WHERE ct.ID_Mascota = m.ID_Mascota and m.ID_Cliente = c.ID_Cliente and
				ct.ID_Motivo_Cita = mc.ID_Motivo_Cita and ct.Estado = e.ID_Estados 
			ORDER BY ct.Fecha_Inicio, ct.Hora_Inicio ASC;
end
go

--SP para modificar estado citas

CREATE PROC SP_Modificar_Estado_Cita 
@id_cita int, 
@Estado int
AS
begin
update CITAS set Estado = @Estado where ID_Cita = @id_cita;
end
go

--SP para Modificar citas

CREATE PROC SP_Modidicar_Cita 
@id_cita int,
@id_mascota int, 
@id_consultorio int,
@id_Motivo int,
@Fecha_Inicio date,
@Hora_Inicio time,
@Hora_Fin time,
@Estado int
AS
begin
UPDATE CITAS set
		ID_Mascota = @id_mascota,
		ID_Consultorio=@id_consultorio ,
		ID_Motivo_Cita=@id_Motivo,
		Fecha_Inicio=@Fecha_Inicio,
		Fecha_Fin=@Fecha_Inicio,
		Hora_Inicio=@Hora_Inicio,
		Hora_Fin= @Hora_Fin,
		Estado=@Estado
	WHERE ID_Cita = @id_cita
end
go

--SP para Consultar mascotas Por cliente

CREATE PROC SP_Consulta_Macota_Cliente
@Cedula varchar(20)
AS
begin
SELECT m.ID_Mascota, m.Nombre, CONCAT(c.Nombre,' ',c.Apellido_1,' ',c.Apellido_2) Nombre_Cliente FROM CLIENTES c, MASCOTAS M
	WHERE m.ID_Cliente = c.ID_Cliente and c.Cedula = @Cedula; 
end
go
