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


GO
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
  usuario VARCHAR(255) PRIMARY KEY NOT NULL,
pass VARCHAR(255),
  baja INT default 0,
  fechaBaja DATETIME,
  intentos INT,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolxFuncionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES GESTIONAME_LAS_VACACIONES.Rol(id) ,
  idFuncionalidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Funcionalidad(id),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolxUsuario(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES GESTIONAME_LAS_VACACIONES.Rol(id) ,
  idUsuario VARCHAR(255) REFERENCES GESTIONAME_LAS_VACACIONES.Usuario(usuario) ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Servicio(
  id INTEGER PRIMARY KEY,
  precioBono INT,
  precioCuota INT ,
  descripcion varchar(30),
  baja INT DEFAULT 0,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Paciente (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
  documento INT NOT NULL,
  tipoDocumento VARCHAR(10) ,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(100),
  fechaNacimiento DATETIME NOT NULL,
  sexo CHAR,
  estadoCivil VARCHAR(10),
  cantFamiliares INT DEFAULT 0,
  cantConsultas INT DEFAULT 0,
  servicio INT REFERENCES GESTIONAME_LAS_VACACIONES.SERVICIO(id),
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
  diaInicio INT,   -- LUNES 1 MARTES 2 MIERCOLES 3 JUEVES 4 VIERNES 5
  diaFin INT,
  baja INTEGER DEFAULT 0,
  motivo VARCHAR(255),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.CompraBono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  cantidad INT NOT NULL DEFAULT 1,
  monto INT NOT NULL,
  fecha DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Modificacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Servicio(id),
  motivo VARCHAR(50),
  fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Bono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Servicio(id),
  idCompraBono INT REFERENCES GESTIONAME_LAS_VACACIONES.CompraBono(id),
  usado INT DEFAULT 0 --0 Sin usar, 1 usado
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.ConsultaMedica(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idBono INT REFERENCES GESTIONAME_LAS_VACACIONES.Bono(id),
  fecha DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  diagnostico VARCHAR(255),
  sintomas VARCHAR(255),
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Turno(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesional(id),
  especialidad VARCHAR(30),
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Paciente(id),
  idConsultaMedica INT REFERENCES GESTIONAME_LAS_VACACIONES.ConsultaMedica(id),
  fecha DATETIME NOT NULL,
  baja INT default 0,
  tipoCancelacion INT, -- 0 Paciente, 1 Profesional
  motivo VARCHAR(255),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.EspecialidadxProfesional(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEspecialidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Especialidad(id) ,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesional(id) ,
  )

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

INSERT INTO GESTIONAME_LAS_VACACIONES.Usuario (usuario, pass) VALUES ('admin','52d77462b24987175c8d7dab901a5967e927ffc8d0b6e4a234e07a4aec5e3724')

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
	SELECT   r.id, u.usuario FROM GESTIONAME_LAS_VACACIONES.Rol r  , GESTIONAME_LAS_VACACIONES.Usuario u WHERE r.id = 1
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

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan(@idPaciente as int, @cantidad as int)
RETURNS INTEGER
AS
BEGIN
	DECLARE @precioBonoPlan INTEGER
	SELECT
		@precioBonoPlan = precioBono
	FROM 
		GESTIONAME_LAS_VACACIONES.Servicio s
	JOIN GESTIONAME_LAS_VACACIONES.Paciente p
	ON s.id = p.servicio
		
	RETURN @precioBonoPlan * @cantidad;
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getPlanMedico (@idAfiliado as INT)
RETURNS varchar(30) AS
 BEGIN 
 RETURN (SELECT s.descripcion FROM GESTIONAME_LAS_VACACIONES.Servicio s JOIN
								GESTIONAME_LAS_VACACIONES.Paciente p ON (p.servicio = s.descripcion)
			WHERE @idAfiliado = p.id) 
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdPlanMedico (@descripcion as VARCHAR(30))
RETURNS INT AS
 BEGIN 
 RETURN (SELECT id FROM GESTIONAME_LAS_VACACIONES.Servicio s
			WHERE @descripcion = s.descripcion) 
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.buscarAfiliados(@nombre as varchar(20),@apellido as varchar(20), @numAfiliado as int )
returns table 
as 
return select * from GESTIONAME_LAS_VACACIONES.Paciente where id = @numAfiliado or (nombre like @nombre and apellido like @apellido)
go

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado()
returns INT 
as 
BEGIN
return (((select max(id) from GESTIONAME_LAS_VACACIONES.Paciente) /100)+1) * 100
END

go
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar (@idFamiliar as int)
returns int 
AS
begin
declare @ret int;
select  @ret = max(id) from GESTIONAME_LAS_VACACIONES.Paciente where id between @idFamiliar and @idFamiliar+80 -- por si existe otro afiliado
return @ret +1;
end
go


--////////////////////////////////////--
--PROCEDURES--
--NUMERO 2--
--LOGUIN DE USUARIOS--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.LoguearUsuario(@username VARCHAR(255), @pass VARCHAR(255))
AS 
BEGIN
	DECLARE @usuario VARCHAR(255)
	DECLARE @intentos INT
	SELECT @intentos = intentos FROM GESTIONAME_LAS_VACACIONES.Usuario
								WHERE usuario like @username
	IF (@intentos >= 3)
		RAISERROR('El usuario se encuentra bloqueado por tener 3 intentos de logueo fallidos',16,217) WITH SETERROR
			
	SELECT @usuario = usuario FROM GESTIONAME_LAS_VACACIONES.Usuario WHERE usuario like @username AND pass like @pass
	IF (@usuario IS NULL)
	BEGIN
		UPDATE GESTIONAME_LAS_VACACIONES.Usuario
		SET intentos = @intentos +1 
		WHERE usuario = @username 
		RAISERROR(@pass,16,217) WITH SETERROR
	END
	ELSE
	BEGIN
	UPDATE GESTIONAME_LAS_VACACIONES.Usuario 
	SET intentos = 0 
	WHERE Usuario.usuario like @username
	END
END
GO


--////////////////////////////////////--
--NUMERO 1--
--ABM ROLES--


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
UPDATE GESTIONAME_LAS_VACACIONES.Rol
SET descripcion= @nombreNuevo
WHERE descripcion= @nombreViejo
END
GO

--////////////////////////////////////--
--EL 3 ESTA HARCODEADO ARRIBA--
--NUMERO 4--
--ABM PACIENTES--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaPaciente(@nombre as nvarchar(50), @apellido as nvarchar(50), 
@doc as int, @direc as varchar(100), @tel as int, @mail as varchar(100), @nacimiento as DATETIME, @sexo as char, @civil as varchar(10),
@cantFami as int, @servicio as int)
AS
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Paciente WHERE apellido LIKE @apellido AND documento = @doc) 
INSERT INTO GESTIONAME_LAS_VACACIONES.Paciente(id,nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares,servicio) VALUES (GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado(),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@servicio)
ELSE
PRINT 'El paciente ya existe'
END 
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaFamiliar(@idFamiliar as INT,@nombre as nvarchar(50), @apellido as nvarchar(50), 
@doc as int, @direc as varchar(100), @tel as int, @mail as varchar(100), @nacimiento as DATETIME, @sexo as char, @civil as varchar(10),
@cantFami as int,@servicio as int)
AS
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Paciente WHERE apellido LIKE @apellido AND documento = @doc) 
INSERT INTO GESTIONAME_LAS_VACACIONES.Paciente(id,nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares,servicio) VALUES (GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar(@idFamiliar),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@servicio)
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
UPDATE GESTIONAME_LAS_VACACIONES.Paciente
SET nombre = @nombre, apellido  = @apellido , documento = @doc, direccion = @direc, telefono = @tel, email = @mail, sexo = @sexo, 
estadoCivil = @civil, cantFamiliares = @cantFami WHERE id = @id
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cambioPlan(@idPaciente AS INT,@descripcionPlan AS VARCHAR(30), @motivo AS VARCHAR(50))
AS
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Modificacion(idPaciente,idPlan,motivo)
VALUES(@idPaciente,GESTIONAME_LAS_VACACIONES.getIdPlanMedico(@descripcionPlan),@motivo)
END
GO

--////////////////////////////////////--
--ABM FUNCIONALIDADES A ROL --

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
-- LOS 5, 6, 7 NO SE HACEN--
--NUMERO 8--
--CREACION AGENDA PROFESIONAL--

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

--////////////////////////////////////--
--NUMERO 9--
--COMPRA DE BONOS--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.compraDeBonos(@numAfiliado as int, @cantidad as int)
AS
BEGIN
DECLARE @aux INT
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Paciente where id = @numAfiliado)
PRINT 'No existe el afiliado'
ELSE 
INSERT INTO GESTIONAME_LAS_VACACIONES.CompraBono(idPaciente, cantidad, monto) 
VALUES (@numAfiliado, @cantidad, GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan(@numAfiliado, @cantidad))
WHILE (@aux < @cantidad)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Bono(idCompraBono, idPaciente, idPlan) 
VALUES ((SELECT id FROM GESTIONAME_LAS_VACACIONES.CompraBono WHERE idPaciente = @numAfiliado and fecha = CURRENT_TIMESTAMP) , @numAfiliado, (SELECT servicio FROM Paciente WHERE id = @numAfiliado))
SET @aux = @aux + 1
END
END
GO

--////////////////////////////////////--
--NUMERO 10--
--RESERVA DE TURNOS--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.verificarSiAtiende(@matricula as int, @especialidad as varchar(30), @fecha as DATETIME) 
RETURNS	INT
AS
BEGIN
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agenda 
WHERE idProfesional = @matricula 
	  and idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) 
	  and (@fecha between fechaInicio and fechaFinal)
	  and datepart (dw, @fecha) between diaInicio and diaFin)
RETURN 0

RETURN 1
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.reservarTurno(@matricula as int, @numAfiliado as int, @especialidad as varchar(30), @fecha as DATETIME)
AS
BEGIN
IF (NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turno WHERE idProfesional = @matricula and fecha = @fecha and (GESTIONAME_LAS_VACACIONES.verificarSiAtiende (@matricula, @especialidad, @fecha)) = 1))
	INSERT INTO GESTIONAME_LAS_VACACIONES.Turno (idPaciente, idProfesional, especialidad, fecha) 
	VALUES (@numAfiliado, @matricula, @especialidad, @fecha) 
END
GO


--////////////////////////////////////--
--NUMERO 11--
--REGISTRO DE LLEGADA--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.registrarLlegada(@numAfiliado as int, @matricula as int, @especialidad as varchar(30))
AS
BEGIN

DECLARE @bonoID AS INT

IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turno WHERE idPaciente = @numAfiliado	
						and idProfesional = @matricula
						and  CAST(fecha AS DATE) = CAST(CURRENT_TIMESTAMP AS DATE))
PRINT 'No existe el turno'
ELSE


SELECT @bonoID = min(b.id) 
FROM GESTIONAME_LAS_VACACIONES.Paciente p JOIN GESTIONAME_LAS_VACACIONES.Bono b 
ON p.id = b.idPaciente and b.usado = 0

INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultaMedica(idBono, fecha) 
VALUES (@bonoID, CURRENT_TIMESTAMP)

UPDATE GESTIONAME_LAS_VACACIONES.Bono
SET usado = 1
WHERE id = @bonoID

END
GO

--////////////////////////////////////--
--NUMERO 12--
--CARGA DE SINTOMAS Y DIAGNOSTICO A LA CONSULTA MEDICA--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cargarSintomasYDiagnostico(@idBono as int, @diagnostico as varchar(255), @sintomas as varchar(255))
AS
BEGIN

UPDATE GESTIONAME_LAS_VACACIONES.ConsultaMedica
SET diagnostico = @diagnostico, sintomas = @sintomas
WHERE idBono = @idBono

END
GO


--////////////////////////////////////--
--NUMERO 13--
--CANCELACION DE TURNOS--
--PACIENTE--
	
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado(@numAfiliado as int, @matricula as int, @especialidad as varchar(30), @fecha as DATETIME, @motivo as VARCHAR(255))
AS
BEGIN
IF (NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turno WHERE idPaciente = @numAfiliado 
				and (idProfesional = @matricula or especialidad like @especialidad) 
				and fecha = @fecha and CAST(fecha AS DATE) < CAST(CURRENT_TIMESTAMP AS DATE) ))
	
Print 'Como va a cancelar un turno que nunca agendo usted es hijo de primos'
ELSE 
UPDATE GESTIONAME_LAS_VACACIONES.Turno 
SET baja = 1, tipoCancelacion = 0, motivo = @motivo
WHERE idPaciente = @numAfiliado and (idProfesional = @matricula or especialidad like @especialidad) and fecha = @fecha
END
GO


--////////////////////////////////////--
--PROFESIONAL--


CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional(@matricula as int, @especialidad as varchar(30), @diaACancelar as DATETIME, @motivo as varchar(255))
AS
BEGIN 
DECLARE @inicioAux AS DATETIME
DECLARE @finalAux AS DATETIME
DECLARE @diaInicialAux as INT
DECLARE @diaFinalAux as INT


IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agenda WHERE idProfesional = @matricula 
				and @diaACancelar between fechaInicio and fechaFinal
				and GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad )
PRINT 'El dia no se encuentra agendado'
ELSE

SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agenda 
WHERE idProfesional = @matricula 
	  and @diaACancelar between fechaInicio 
	  and fechaFinal 
	  and GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Agenda 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula and @diaACancelar between fechaInicio and fechaFinal and GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Turno
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula and especialidad = @especialidad and fecha = @diaACancelar

IF (@diaACancelar != @inicioAux and @diaACancelar != @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1, @diaACancelar), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @diaACancelar), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaACancelar = @inicioAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @inicioAux), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaACancelar = @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1, @finalAux), @diaInicialAux, @diaFinalAux)

END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional(@matricula as int, @especialidad as varchar(30), @diaInicialACancelar as DATETIME, @diaFinalACancelar as DATETIME, @motivo as varchar(255))
AS
BEGIN 
DECLARE @inicioAux AS DATETIME
DECLARE @finalAux AS DATETIME
DECLARE @diaInicialAux as INT
DECLARE @diaFinalAux as INT


IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agenda WHERE idProfesional = @matricula 
				and @diaInicialACancelar between fechaInicio and fechaFinal
				and @diaFinalACancelar between fechaInicio and fechaFinal
				and GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad )
PRINT 'El rango de fechas no se encuentra agendado'
ELSE

SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agenda 
WHERE idProfesional = @matricula 
	  and @diaInicialACancelar between fechaInicio and fechaFinal
	  and @diaFinalACancelar between fechaInicio and fechaFinal
	  and GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Agenda 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula 
	and @diaInicialACancelar between fechaInicio and fechaFinal
	and @diaFinalACancelar between fechaInicio and fechaFinal 
	and GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Turno
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula 
	and especialidad = @especialidad 
	and fecha between  @diaInicialACancelar and @diaFinalACancelar

IF (@diaInicialACancelar != @inicioAux and @diaFinalACancelar != @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1,  @diaInicialACancelar ), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @diaFinalACancelar), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaInicialACancelar = @inicioAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @diaFinalACancelar), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaFinalACancelar = @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agenda(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1, @diaInicialACancelar), @diaInicialAux, @diaFinalAux)

END
GO

--////////////////////////////////////--
--NUMERO 14--
--LISTADO ESTRATEGICO--
--TOP 5 ESPECIALIDADES CON MAS CANCELACIONES--

CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones()
returns table 
AS
RETURN (SELECT GESTIONAME_LAS_VACACIONES.getIdEspecialidad(t.especialidad) as especialidades, a.idEspecialidad as especialidades2 FROM GESTIONAME_LAS_VACACIONES.Turno t JOIN GESTIONAME_LAS_VACACIONES.Agenda a ON t.baja = 1 and a.baja = 1)
GO

CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones()
returns table 
AS
RETURN (SELECT especialidades FROM GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones()
UNION ALL
SELECT especialidades2 FROM GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones())
--ORDER BY especialidades)
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones
AS
BEGIN

SELECT TOP 5 especialidades FROM GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones()

END
GO