CREATE SCHEMA [GESTIONAME_LAS_VACACIONES]
GO

 DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)
SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 ORDER BY [name])
WHILE @name is not null
BEGIN
    SELECT @SQL = 'DROP PROCEDURE [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Procedure: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 AND [name] > @name ORDER BY [name])
END
GO

/* Drop all views */
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)
SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'V' AND category = 0 ORDER BY [name])
WHILE @name IS NOT NULL
BEGIN
    SELECT @SQL = 'DROP VIEW [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped View: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'V' AND category = 0 AND [name] > @name ORDER BY [name])
END
GO

/* Drop all functions */
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 ORDER BY [name])

WHILE @name IS NOT NULL
BEGIN
    SELECT @SQL = 'DROP FUNCTION [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Function: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 AND [name] > @name ORDER BY [name])
END
GO

/* Drop all Foreign Key constraints */
DECLARE @name VARCHAR(128)
DECLARE @constraint VARCHAR(254)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 TABLE_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'FOREIGN KEY' ORDER BY TABLE_NAME)

WHILE @name is not null
BEGIN
    SELECT @constraint = (SELECT TOP 1 CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'FOREIGN KEY' AND TABLE_NAME = @name ORDER BY CONSTRAINT_NAME)
    WHILE @constraint IS NOT NULL
    BEGIN
        SELECT @SQL = 'ALTER TABLE [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +'] DROP CONSTRAINT [' + RTRIM(@constraint) +']'
        EXEC (@SQL)
        PRINT 'Dropped FK Constraint: ' + @constraint + ' on ' + @name
        SELECT @constraint = (SELECT TOP 1 CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'FOREIGN KEY' AND CONSTRAINT_NAME <> @constraint AND TABLE_NAME = @name ORDER BY CONSTRAINT_NAME)
    END
SELECT @name = (SELECT TOP 1 TABLE_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'FOREIGN KEY' ORDER BY TABLE_NAME)
END
GO

/* Drop all Primary Key constraints */
DECLARE @name VARCHAR(128)
DECLARE @constraint VARCHAR(254)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 TABLE_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'PRIMARY KEY' ORDER BY TABLE_NAME)

WHILE @name IS NOT NULL
BEGIN
    SELECT @constraint = (SELECT TOP 1 CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'PRIMARY KEY' AND TABLE_NAME = @name ORDER BY CONSTRAINT_NAME)
    WHILE @constraint is not null
    BEGIN
        SELECT @SQL = 'ALTER TABLE [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +'] DROP CONSTRAINT [' + RTRIM(@constraint)+']'
        EXEC (@SQL)
        PRINT 'Dropped PK Constraint: ' + @constraint + ' on ' + @name
        SELECT @constraint = (SELECT TOP 1 CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'PRIMARY KEY' AND CONSTRAINT_NAME <> @constraint AND TABLE_NAME = @name ORDER BY CONSTRAINT_NAME)
    END
SELECT @name = (SELECT TOP 1 TABLE_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE constraint_catalog=DB_NAME() AND CONSTRAINT_TYPE = 'PRIMARY KEY' ORDER BY TABLE_NAME)
END
GO

/* Drop all tables */
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'U' AND category = 0 ORDER BY [name])

WHILE @name IS NOT NULL
BEGIN
    SELECT @SQL = 'DROP TABLE [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Table: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'U' AND category = 0 AND [name] > @name ORDER BY [name])
END



--/////////////////////////////////////////////////////--
--CREACION DE TABLAS--
CREATE TABLE GESTIONAME_LAS_VACACIONES.Funcionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(50) NULL ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Rol(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(50) NULL,
  baja INT DEFAULT 0,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Usuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  usuario NVARCHAR(30) NOT NULL,
  pass NVARCHAR(30) NULL ,
  baja INT default 0,
  fechaBaja DATETIME,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolxFuncionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES GESTIONAME_LAS_VACACIONES.Rol(id) ,
  idFuncionalidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Funcionalidad(id),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolxUsuario(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES GESTIONAME_LAS_VACACIONES.Rol(id) ,
  idUsuario INT REFERENCES GESTIONAME_LAS_VACACIONES.Usuario(id) ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Paciente (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
  documento INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(100),
  fechaNacimiento DATETIME NOT NULL,
  sexo CHAR,
  estadoCivil VARCHAR(10),
  cantFamiliares INT DEFAULT 0,
  cantConsultas INT DEFAULT 0,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Profesional (
  id INTEGER PRIMARY KEY NOT NULL DEFAULT 0,
  nombre NVARCHAR(50) NOT NULL ,
  apellido VARCHAR(50) NOT NULL,
  tipoDocumento VARCHAR,
  documento INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(100),
  fechaNacimiento DATETIME NOT NULL,
  sexo CHAR,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Especialidad(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion VARCHAR(30),
  tipoEspecialidad VARCHAR(30),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Agenda(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesional(id),
  idEspecialidad int REFERENCES GESTIONAME_LAS_VACACIONES.Especialidad(id),
  fechaInicio DATETIME NOT NULL,   -- ACA PARA FECHA DEL AÑO QUE TRABAJA Y HORARIO
  fechaFinal DATETIME NOT NULL,
  diaInicio VARCHAR(10),   -- ACA PARA LUNES Y MARTES
  diaFin VARCHAR (10),
  baja INTEGER DEFAULT 0
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.CompraBono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  cantidad INT NOT NULL DEFAULT 1,
  monto INT NOT NULL,
  fecha DATETIME NOT NULL,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Servicio(
  id INTEGER PRIMARY KEY,
  precioBono INT,
  precioCuota INT ,
  descripcion varchar(30),
  baja INT DEFAULT 0,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Modificacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Servicio(id),
  fecha DATETIME DEFAULT NULL,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Bono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Servicio(id),
  idCompraBono INT REFERENCES GESTIONAME_LAS_VACACIONES.CompraBono(id),
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.ConsultaMedica(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idBono INT REFERENCES GESTIONAME_LAS_VACACIONES.Bono(id),
  fecha DATETIME NOT NULL,
  diagnostico VARCHAR(255) NOT NULL,
  sintomas VARCHAR(255),
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Turno(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesional(id),
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  idConsultaMedica INT REFERENCES GESTIONAME_LAS_VACACIONES.ConsultaMedica(id),
  fecha DATETIME NOT NULL,
  baja INT default 0,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Cancelacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idConsultaMedica INT REFERENCES GESTIONAME_LAS_VACACIONES.ConsultaMedica(id),
  tipoCancelacion INT NOT NULL,
  motivo VARCHAR(255),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.EspecialidadxProfesional(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEspecialidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Especialidad(id) ,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesional(id) ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Intento(
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	idUsuario INT REFERENCES GESTIONAME_LAS_VACACIONES.Usuario(id),
	tiempo DATETIME,)

GO

--////////////////////////////////////--
--MIGRACION--

CREATE TABLE #PacienteTemporal(
 id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
  dni INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATETIME NOT NULL,
  idPlan INT,
  precioBono INT NOT NULL,
  precioCuota INT NOT NULL,
  descripcion varchar(255),
  Compra_Bono_Fecha DATETIME,
  )

INSERT INTO GESTIONAME_LAS_VACACIONES.Rol(descripcion) VALUES ('Administrativo')
INSERT INTO GESTIONAME_LAS_VACACIONES.Rol(descripcion) VALUES ('Afiliado')
INSERT INTO GESTIONAME_LAS_VACACIONES.Rol(descripcion) VALUES ('Profesional')

INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('ABM ROL')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('ABM AFILIADOS')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('COMPRA BONOS')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('PEDIDO DE TURNO')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('REGISTRO DE LLEGADA')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('CANCELAR TURNO')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) VALUES ('LISTADO ESTADISTICO')

INSERT INTO GESTIONAME_LAS_VACACIONES.Usuario (usuario, pass) VALUES ('admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')

INSERT INTO #PacienteTemporal(nombre,apellido,dni,direccion,telefono,email,fechaNacimiento,idPlan,descripcion,precioBono,precioCuota, Compra_Bono_Fecha)
SELECT DISTINCT Paciente_Nombre,Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,Paciente_Fecha_Nac,
				Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Farmacia,Plan_Med_Precio_Bono_Consulta, Compra_Bono_Fecha
					FROM gd_esquema.Maestra


INSERT INTO GESTIONAME_LAS_VACACIONES.Paciente(nombre,apellido,documento, direccion, telefono, email, fechaNacimiento)
	SELECT distinct nombre,apellido,dni,direccion,telefono,email,fechaNacimiento
		FROM #PacienteTemporal
INSERT INTO GESTIONAME_LAS_VACACIONES.Servicio(id,descripcion, precioCuota, precioBono)
	SELECT DISTINCT idPlan,descripcion, precioCuota, precioBono
		FROM #PacienteTemporal
INSERT INTO GESTIONAME_LAS_VACACIONES.Modificacion(idPaciente,idPlan,fecha)
	SELECT DISTINCT id,idPlan,Compra_Bono_Fecha
		FROM #PacienteTemporal
		where idPlan is not null and id is not null
INSERT INTO GESTIONAME_LAS_VACACIONES.CompraBono(idPaciente,fecha,cantidad,monto)
select p.id,Bono_Consulta_Fecha_Impresion, COUNT(Bono_Consulta_Fecha_Impresion) as cantidad_bonos_por_dia,  COUNT(Bono_Consulta_Fecha_Impresion)* Plan_Med_Precio_Bono_Consulta as monto
from gd_esquema.Maestra m , GESTIONAME_LAS_VACACIONES.Paciente p 
where Bono_Consulta_Fecha_Impresion is not null  and p.documento = Paciente_Dni
group by Bono_Consulta_Fecha_Impresion, Paciente_Apellido,Paciente_Nombre, Plan_Med_Precio_Bono_Consulta, p.id
INSERT INTO GESTIONAME_LAS_VACACIONES.Profesional(nombre,apellido,documento,direccion,email,fechaNacimiento,telefono)
	SELECT DISTINCT Medico_Nombre,Medico_Apellido,Medico_Dni,Medico_Direccion,Medico_Mail,Medico_Fecha_Nac,Medico_Telefono
	FROM gd_esquema.Maestra
	WHERE Medico_Nombre IS NOT NULL
INSERT INTO GESTIONAME_LAS_VACACIONES.RolxFuncionalidad(idFuncionalidad, idRol)
	SELECT DISTINCT f.id, r.id FROM GESTIONAME_LAS_VACACIONES.Funcionalidad f, GESTIONAME_LAS_VACACIONES.Rol r  WHERE r.id = 1
INSERT INTO GESTIONAME_LAS_VACACIONES.RolxUsuario(idRol, idUsuario) 
	SELECT   r.id, u.id FROM GESTIONAME_LAS_VACACIONES.Rol r  , GESTIONAME_LAS_VACACIONES.Usuario u WHERE r.id = 1
INSERT INTO GESTIONAME_LAS_VACACIONES.Bono(idCompraBono, idPaciente, idPlan)
	SELECT c.id, p.id, s.id FROM GESTIONAME_LAS_VACACIONES.CompraBono c, GESTIONAME_LAS_VACACIONES.Paciente p, GESTIONAME_LAS_VACACIONES.Servicio s
--Meter Bono_Consulta_Numero en algun lugar del bono ACORDARSE
INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultaMedica(idBono, sintomas, fecha, diagnostico)
	SELECT b.id, Consulta_Sintomas, Turno_Fecha, Consulta_Enfermedades FROM GESTIONAME_LAS_VACACIONES.Bono b, gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Turno(idConsultaMedica, idPaciente, idProfesional, fecha)
	SELECT c.id, p.id, prof.id, Turno_Fecha FROM GESTIONAME_LAS_VACACIONES.ConsultaMedica c, GESTIONAME_LAS_VACACIONES.Paciente p, GESTIONAME_LAS_VACACIONES.Profesional prof, gd_esquema.Maestra
INSERT INTO GESTIONAME_LAS_VACACIONES.Especialidad(descripcion, tipoEspecialidad)
	SELECT DISTINCT Especialidad_Descripcion, Tipo_Especialidad_Descripcion
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL AND Especialidad_Descripcion IS NOT NULL
INSERT INTO GESTIONAME_LAS_VACACIONES.EspecialidadxProfesional(idEspecialidad, idProfesional)
	SELECT e.id, p.id FROM GESTIONAME_LAS_VACACIONES.Especialidad e, GESTIONAME_LAS_VACACIONES.Profesional p

-- FUNCION PARA SACAR EL idUsuario del DNI
GO

--////////////////////////////////////--
--FUNCIONES--
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.funcObtenerIdDeDni(@dni INT)
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER
	SELECT
		@retorno = id
	FROM 
		Paciente
	WHERE
		documento = @dni
		
	RETURN @retorno;
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@descEspecialidad as VARCHAR(30))
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER
	SELECT
		@retorno = id
	FROM 
		Especialidad
	WHERE
		descripcion = @descEspecialidad
	RETURN @retorno;
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdFuncionalidad (@descripcion as varchar(30))
RETURNS INT AS
 BEGIN 
 RETURN (SELECT id FROM GESTIONAME_LAS_VACACIONES.Funcionalidad
			WHERE @descripcion like descripcion) 
END

GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdRol (@descripcion as varchar(30))
RETURNS INT AS
 BEGIN 
 RETURN (SELECT id FROM GESTIONAME_LAS_VACACIONES.Rol
			WHERE @descripcion like descripcion) 
END


GO

--////////////////////////////////////--
--PROCEDURES--
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.logueo(@username VARCHAR(30), @pass VARCHAR(30))
AS BEGIN
	DECLARE @usuario NUMERIC(18,0)
	DECLARE @intentos INT
	SELECT COUNT(idUsuario) FROM GESTIONAME_LAS_VACACIONES.Intento i
								JOIN GESTIONAME_LAS_VACACIONES.Usuario u ON i.id = u.id
								WHERE u.usuario = @username
	IF (@intentos >= 3)
		RAISERROR('El usuario se encuentra bloqueado por tener 3 intentos de logueo fallidos',16,217) WITH SETERROR
			
	SELECT @usuario = id FROM GESTIONAME_LAS_VACACIONES.Usuarios WHERE usuario = @username AND pass = HASHBYTES('SHA2_256', @pass)
	IF (@usuario IS NULL)
		BEGIN 
		UPDATETIME intentos SET intentos = @intentos + 1 
		FROM GESTIONAME_LAS_VACACIONES.Usuarios usuarios
		JOIN GESTIONAME_LAS_VACACIONES.Intentos intentos ON intentos.usuario_id = usuarios.id
		WHERE usuarios.usuario = @username
		RAISERROR('Los datos ingresados no son validos',16,217) WITH SETERROR
		END 

	ELSE
	BEGIN
		IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Usuario_Rol 
						JOIN GESTIONAME_LAS_VACACIONES.Roles ON id = id_rol
						WHERE nombre = 'Administrativo' AND @usuario = id_usuario)
			RAISERROR('El usuario no tiene los permisos necesarios',16,217) WITH SETERROR
	END
	UPDATETIME intentos SET intentos = 0 
	FROM GESTIONAME_LAS_VACACIONES.Usuarios usuarios
	JOIN GESTIONAME_LAS_VACACIONES.Intentos intentos ON intentos.usuario_id = usuarios.id
	WHERE usuarios.usuario = @username
END
GO

--////////////////////////////////////--
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.crearRol(@nombre as  varchar(30))
AS 
BEGIN
if  not exists   (select descripcion from GESTIONAME_LAS_VACACIONES.Rol where  descripcion like @nombre)
Insert into GESTIONAME_LAS_VACACIONES.Rol(descripcion) values(@nombre)
ELSE
PRINT 'El Rol ya existe'
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarRol(@nombre as  varchar(30))
AS 
BEGIN 
DELETE FROM GESTIONAME_LAS_VACACIONES.Rol WHERE descripcion like @nombre
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarRol(@nombreViejo as varchar(30), @nombreNuevo as varchar(30))
AS
BEGIN
UPDATETIME GESTIONAME_LAS_VACACIONES.Rol
SET descripcion= @nombreNuevo
WHERE descripcion= @nombreViejo
END
GO

--////////////////////////////////////--
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaPaciente(@nombre as nvarchar(50), @apellido as nvarchar(50), 
@doc as int, @direc as varchar(100), @tel as int, @mail as varchar(100), @nacimiento as DATETIME, @sexo as char, @civil as varchar(10),
@cantFami as int)
AS
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Paciente WHERE apellido LIKE @apellido AND documento = @doc) 
INSERT INTO GESTIONAME_LAS_VACACIONES.Paciente(nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares) VALUES (@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami)
ELSE
PRINT 'El paciente ya existe'
END 
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarPaciente(@numAfiliado as int)
AS
DELETE GESTIONAME_LAS_VACACIONES.Paciente WHERE id = @numAfiliado
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente(@id as int,@nombre as nvarchar(50), @apellido as nvarchar(50), 
@doc as int, @direc as varchar(100), @tel as int, @mail as varchar(255), @sexo as char, @civil as varchar(10),
@cantFami as int)
AS
BEGIN
UPDATETIME GESTIONAME_LAS_VACACIONES.Paciente
SET nombre = @nombre, apellido  = @apellido , documento = @doc, direccion = @direc, telefono = @tel, email = @mail, sexo = @sexo, 
estadoCivil = @civil, cantFamiliares = @cantFami WHERE id = @id
END
GO

--////////////////////////////////////--
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol (@nombreRol as varchar(30),@nombreFuncionalidad as varchar(30))
AS
BEGIN
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Funcionalidad WHERE descripcion like @nombreFuncionalidad)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidad(descripcion) values (@nombreFuncionalidad)
END
INSERT INTO GESTIONAME_LAS_VACACIONES.RolxFuncionalidad(idFuncionalidad,idRol) VALUES
( GESTIONAME_LAS_VACACIONES.getIdFuncionalidad(@nombreFuncionalidad),GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol))
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol (@nombreRol as varchar(30), @nombreFuncionalidad as varchar(30))
AS
BEGIN
DELETE FROM GESTIONAME_LAS_VACACIONES.RolxFuncionalidad 
WHERE idFuncionalidad = GESTIONAME_LAS_VACACIONES.getIdFuncionalidad(@nombreFuncionalidad)
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol (@nombreRol as varchar(30), @nombreFuncionalidadVieja as varchar(30), @nombreFuncionalidadNueva as varchar(30))
AS
BEGIN
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.RolxFuncionalidad where idRol = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol) and idFuncionalidad = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreFuncionalidadVieja))
PRINT 'No existe la funcionalidad o el rol que desea modificar'
ELSE 
UPDATE GESTIONAME_LAS_VACACIONES.RolxFuncionalidad 
SET idFuncionalidad = @nombreFuncionalidadNueva 
WHERE idFuncionalidad = GESTIONAME_LAS_VACACIONES.getIdFuncionalidad(@nombreFuncionalidadVieja)
END 
GO

--////////////////////////////////////--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaAgendaProfesional
(@matriculaProfesional as int, @descEspecialidad as varchar(30), 
@fechaInicio as DATETIME, @fechaFin as DATETIME, @diaInicio as VARCHAR(10), 
  @diaFin as VARCHAR (10))
AS
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, 
fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matriculaProfesional, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@descEspecialidad), @fechaInicio, @fechaFin, @diaInicio, @diaFin) 
END
GO