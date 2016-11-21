IF NOT EXISTS ( SELECT  *
				FROM    sys.schemas
				WHERE   name = N'GESTIONAME_LAS_VACACIONES' ) 
	EXEC('CREATE SCHEMA [GESTIONAME_LAS_VACACIONES]');
GO


IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.TablaTemporalListado', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.TablaTemporalListado;
GO


IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional;
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.ConsultasMedicas', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.ConsultasMedicas;
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Turnos', N'U') IS NOT NULL 
DROP TABLE  GESTIONAME_LAS_VACACIONES.Turnos
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Bonos', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Bonos
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Modificaciones', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Modificaciones
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.ComprasBonos', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.ComprasBonos
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Agendas', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Agendas
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Especialidades', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Especialidades
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Profesionales', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Profesionales
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Pacientes', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Pacientes
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Planes', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Planes
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.RolesxUsuario', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.RolesxUsuario
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Usuarios', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Usuarios
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Roles', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Roles
GO

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Funcionalidades', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Funcionalidades
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha
GO

DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 ORDER BY [name])

WHILE @name is not null
BEGIN
    SELECT @SQL = 'DROP PROCEDURE [GESTIONAME_LAS_VACACIONES].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 AND [name] > @name ORDER BY [name])
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
     SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 AND [name] > @name ORDER BY [name])
END
GO
IF OBJECT_ID(N'tempdb..#PacienteTemporal', N'U') IS NOT NULL
drop table #PacienteTemporal

IF OBJECT_ID(N'tempdb..#TemporalProfesional', N'U') IS NOT NULL
drop table #TemporalProfesional

IF OBJECT_ID(N'tempdb..#ConsultasTemporal', N'U') IS NOT NULL
drop table #ConsultasTemporal

--/////////////////////////////////////////////////////--
--CREACION DE TABLAS--
CREATE TABLE GESTIONAME_LAS_VACACIONES.Funcionalidades (
  id INTEGER IDENTITY(1,1) PRIMARY KEY ,
  descripcion NVARCHAR(50),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Roles(
  id INTEGER IDENTITY(1,1) PRIMARY KEY ,
  descripcion NVARCHAR(50),
  baja INT DEFAULT 0,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Usuarios (
  usuario VARCHAR(255) PRIMARY KEY,
pass VARCHAR(255),
  baja INT default 0,
  fechaBaja DATETIME,
  intentos INT,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad (
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idRol INT REFERENCES GESTIONAME_LAS_VACACIONES.Roles(id) ,
  idFuncionalidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Funcionalidades(id),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolesxUsuario(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idRol INT REFERENCES GESTIONAME_LAS_VACACIONES.Roles(id) ,
  idUsuario VARCHAR(255) REFERENCES GESTIONAME_LAS_VACACIONES.Usuarios(usuario) ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Planes(
  id INTEGER PRIMARY KEY,
  precioBono INT,
  precioCuota INT ,
  descripcion VARCHAR(30),
  baja INT DEFAULT 0,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Pacientes (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
  documento INT NOT NULL,
  tipoDocumento VARCHAR(100) DEFAULT 'DNI' ,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATETIME NOT NULL,
  sexo CHAR,
  estadoCivil VARCHAR(10),
  cantFamiliares INT DEFAULT 0,
  cantConsultas INT DEFAULT 0,
  planes INTEGER ,--INT REFERENCES GESTIONAME_LAS_VACACIONES.Planes(id)
  baja INT DEFAULT 0,
  fechaBaja DATE,
   )


CREATE TABLE GESTIONAME_LAS_VACACIONES.Profesionales (
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido VARCHAR(50) NOT NULL,
  tipoDocumento VARCHAR,
  documento INT NOT NULL,
  direccion VARCHAR(255) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATETIME NOT NULL,
  sexo CHAR,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Especialidades(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  descripcion VARCHAR(50),
  tipoEspecialidad VARCHAR(50),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Agendas(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesionales(id),
  idEspecialidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Especialidades(id),
  fechaInicio DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,   -- ACA PARA FECHA DEL AÑO QUE TRABAJA Y HORARIO
  fechaFinal DATETIME NOT NULL DEFAULT '2016-12-12 11:00:00.000',
  diaInicio INT DEFAULT 1,   -- LUNES 1 MARTES 2 MIERCOLES 3 JUEVES 4 VIERNES 5
  diaFin INT DEFAULT 6,
  baja INTEGER DEFAULT 0,
  motivo VARCHAR(255),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.ComprasBonos(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  cantidad INT NOT NULL DEFAULT 1,
  monto INT NOT NULL,
  fecha DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Modificaciones(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Planes(id),
  motivo VARCHAR(50),
  fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Bonos(
  id INTEGER PRIMARY KEY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Planes(id),
  usado INT DEFAULT 0 --0 Sin usar, 1 usado
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Turnos(
  id INTEGER PRIMARY KEY IDENTITY (1,1),
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesionales(id),
  especialidad VARCHAR(255),
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  idAgenda INT REFERENCES GESTIONAME_LAS_VACACIONES.Agendas(id),
  fecha DATETIME NOT NULL,
  baja INT default 0,
  tipoCancelacion INT, -- 0 Paciente, 1 Profesional
  motivo VARCHAR(255),
  )
  CREATE INDEX ix1_turnos ON GESTIONAME_LAS_VACACIONES.Turnos (idPaciente)
  
CREATE TABLE GESTIONAME_LAS_VACACIONES.ConsultasMedicas(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idBono INT, --REFERENCES GESTIONAME_LAS_VACACIONES.Bonos(id),
  fecha DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  diagnostico VARCHAR(255),
  sintomas VARCHAR(255),
  idTurno INT REFERENCES GESTIONAME_LAS_VACACIONES.Turnos(id),
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional(
  id INTEGER  IDENTITY(1,1) PRIMARY KEY,
  idEspecialidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Especialidades(id) ,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesionales(id) ,
  )

--////////////////////////////////////--
--MIGRACION--


CREATE TABLE #PacienteTemporal(
id INT IDENTITY(1,1) PRIMARY KEY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
  dni INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATETIME NOT NULL,
  idPlan INT,
  descripcionPlan VARCHAR(255), 
  precioBono INT NOT NULL,
  precioCuota INT,
  fechaConsulta DATETIME,
  idTurno INT,
  fechaTurno DATETIME,
  idBono INT ,
  fechaBono DATETIME
  )
GO
CREATE TABLE #TemporalProfesional(
 idTurno INT,
 fechaTurno TIME,
 consultaSintoma varchar (50),
 consultaEnfermedad varchar(50),
 medicoNombre varchar(50),
 medicoApellido varchar(50),
 medicoDni int,
 medicoDir varchar(50),
 medicoTelefono int,
 medicoMail varchar(50),
 medicoNacimiento DATETIME,
 idEspecialidad int,
 especialidadDescripcion varchar(50),
 idEspecialidad2 int,
 especialidadDescripcion2 varchar(50),
)

create table #ConsultasTemporal(
id INTEGER,
fecha DATETIME,
idBono INT,
fechaBono DATETIME,
precioBono INT,
sintomas varchar(50),
diagnostico varchar(50),
dni INT
)
GO

insert into #ConsultasTemporal(id,fecha,idBono,fechaBono,precioBono,sintomas,diagnostico,dni)
SELECT	 Turno_Numero, Turno_Fecha,Bono_Consulta_Numero,Bono_Consulta_Fecha_Impresion,Plan_Med_Precio_Bono_Consulta, 
Consulta_Sintomas,Consulta_Enfermedades, Paciente_Dni
FROM gd_esquema.Maestra
INSERT INTO #PacienteTemporal (nombre,apellido,dni,direccion,telefono,email,fechaNacimiento,idPlan,descripcionPlan,precioBono,idTurno,fechaTurno,fechaBono,idBono)
SELECT Paciente_Nombre,Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,Paciente_Fecha_Nac,
				Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Consulta, Turno_Numero,Turno_Fecha ,Compra_Bono_Fecha,Bono_Consulta_Numero
					FROM GD2C2016.gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(nombre,apellido,direccion,documento,email,fechaNacimiento,telefono,planes)
SELECT  nombre,apellido,direccion,dni,email,fechaNacimiento,telefono ,idPlan
from #PacienteTemporal group by nombre,apellido,direccion,dni,email,fechaNacimiento,telefono,idPlan

INSERT INTO #TemporalProfesional (consultaEnfermedad,consultaSintoma,especialidadDescripcion,especialidadDescripcion2,fechaTurno,
						idEspecialidad,idEspecialidad2,idTurno,medicoApellido,medicoDni,medicoMail,medicoNacimiento,medicoNombre,medicoTelefono,medicoDir)
SELECT Consulta_Enfermedades,Consulta_Sintomas,Especialidad_Descripcion,Tipo_Especialidad_Descripcion,Turno_Fecha,
				Especialidad_Codigo,Tipo_Especialidad_Codigo,Turno_Numero,Medico_Apellido,Medico_Dni,Medico_Mail,Medico_Fecha_Nac,Medico_Nombre,Medico_Telefono,Medico_Direccion
					FROM GD2C2016.gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Profesionales(apellido,direccion,documento,email,fechaNacimiento,nombre,telefono)
SELECT medicoApellido,medicoDir,medicoDni,medicoMail,medicoNacimiento,medicoNombre,medicoTelefono 
FROM #TemporalProfesional where medicoApellido is not null 
group by medicoApellido,medicoDir,medicoDni,medicoMail,medicoNacimiento,medicoNombre,medicoTelefono 

INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad) 
SELECT p.id, e.idProfesional FROM GESTIONAME_LAS_VACACIONES.Profesionales p 
JOIN GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional e
ON p.id = e.idProfesional

INSERT INTO GESTIONAME_LAS_VACACIONES.Roles(descripcion) VALUES ('Administrativo')
INSERT INTO GESTIONAME_LAS_VACACIONES.Roles(descripcion) VALUES ('Afiliado')
INSERT INTO GESTIONAME_LAS_VACACIONES.Roles(descripcion) VALUES ('Profesional')

INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('ABM ROL')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('ABM AFILIADOS')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('COMPRA BONOS')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('PEDIDO DE TURNO')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('REGISTRO DE LLEGADA')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('CANCELAR TURNO')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('LISTADO ESTADISTICO')
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('ALTA AGENDA PROFESIONAL')
INSERT INTO GESTIONAME_LAS_VACACIONES.Usuarios (usuario, pass) VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxUsuario(idRol,idUsuario) values(1,'admin')
GO 
INSERT INTO GESTIONAME_LAS_VACACIONES.Planes(id,descripcion, precioCuota, precioBono)
	SELECT DISTINCT idPlan,descripcionPlan, precioCuota, precioBono
		FROM #PacienteTemporal
	
INSERT INTO GESTIONAME_LAS_VACACIONES.ComprasBonos(idPaciente,fecha,cantidad,monto)
SELECT p.id,t.fechaBono, COUNT(t.fechaBono) ,  COUNT(t.fechaBono)* t.precioBono
FROM #ConsultasTemporal t 
join GESTIONAME_LAS_VACACIONES.Pacientes p
on t.dni = p.documento
where t.fechaBono is not null
GROUP BY p.id, fechaBono,precioBono 

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (1,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (2,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (3,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (4,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (5,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (6,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (7,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (8,1)

	
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Turnos ON

INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos(id,idPaciente, idProfesional,especialidad, fecha, idAgenda)
	select c.id, pa.id, p.id ,t.especialidadDescripcion, c.fecha, a.id
	FROM #ConsultasTemporal c join GESTIONAME_LAS_VACACIONES.Pacientes pa on pa.documento = c.dni
	, #TemporalProfesional t , GESTIONAME_LAS_VACACIONES.Profesionales p 
	JOIN GESTIONAME_LAS_VACACIONES.Agendas a
	ON a.idProfesional = p.id
	JOIN GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional e
	ON a.idEspecialidad = e.idEspecialidad
	WHERE c.id  = t.idTurno and t.medicoDni  =p.documento
	group by c.id, pa.id, p.id , c.fecha, t.especialidadDescripcion, a.id
	HAVING PA.ID IS NOT NULL

INSERT INTO GESTIONAME_LAS_VACACIONES.Especialidades(descripcion, tipoEspecialidad)
	SELECT DISTINCT especialidadDescripcion, idEspecialidad
	FROM #TemporalProfesional
	WHERE especialidadDescripcion IS NOT NULL


INSERT INTO GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional(idEspecialidad, idProfesional)
	SELECT DISTINCT esp.id, e.id FROM #TemporalProfesional p 
	join  GESTIONAME_LAS_VACACIONES.Profesionales e 
	on (p.medicoDni = e.documento and p.medicoNombre like e.nombre and p.medicoApellido like e.apellido)
	join GESTIONAME_LAS_VACACIONES.Especialidades esp
	on esp.descripcion = p.especialidadDescripcion


INSERT INTO GESTIONAME_LAS_VACACIONES.Bonos(id, idPaciente, idPlan)
	SELECT c.idBono, p.id, m.idPlan from #ConsultasTemporal c join (GESTIONAME_LAS_VACACIONES.Modificaciones m 
	join GESTIONAME_LAS_VACACIONES.Pacientes p
	on p.id = m.id)
	on p.documento	 = c.dni 
	where c.idBono is not null
	group by c.idBono, p.id, m.idPlan 
	

--INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos(id, idProfesional, fecha, especialidad) VALUES (0, 3, '2016-04-04 07:30:00.000', 6)

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
		GESTIONAME_LAS_VACACIONES.Pacientes
	WHERE
		documento = @dni
	RETURN @retorno;
END
GO

GO
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado()
RETURNS INT 
AS 
BEGIN
declare @ret INT;
BEGIN
IF((SELECT Count(*) FROM GESTIONAME_LAS_VACACIONES.Pacientes)= 0)set @ret = 100
ELSE set @ret = (((SELECT top 1 id FROM GESTIONAME_LAS_VACACIONES.Pacientes ORDER BY 1 DESC) /100)+1) * 100
END
RETURN @ret
END
GO
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar (@idFamiliar INT)
RETURNS INT 
AS
begin
declare @ret INT;
SELECT  @ret = max(id) FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE id BETWEEN @idFamiliar AND @idFamiliar+80 -- por si existe otro afiliado
RETURN @ret +1;
end
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@descEspecialidad VARCHAR(100))
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER
	SELECT
		@retorno = id
	FROM 
		GESTIONAME_LAS_VACACIONES.Especialidades
	WHERE
		descripcion = @descEspecialidad
	RETURN @retorno;
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getDescEspecialidad(@idEspecialidad int)
RETURNS VARCHAR(200)
AS
BEGIN
	DECLARE @retorno  VARCHAR(200)
	SELECT
		@retorno = descripcion
	FROM 
		GESTIONAME_LAS_VACACIONES.Especialidades
	WHERE
		id = @idEspecialidad
	RETURN @retorno;
END
GO



CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdFuncionalidad (@descripcion VARCHAR(30))
RETURNS INT
 AS
 BEGIN 
 RETURN (SELECT id FROM GESTIONAME_LAS_VACACIONES.Funcionalidades
			WHERE @descripcion LIKE descripcion) 
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdRol (@descripcion VARCHAR(30))
RETURNS INT AS
 BEGIN 
 RETURN (SELECT id FROM GESTIONAME_LAS_VACACIONES.Roles
			WHERE @descripcion LIKE descripcion) 
END


GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan(@idPaciente INT, @cantidad INT)
RETURNS INTEGER
AS
BEGIN
	DECLARE @precioBonoPlan INTEGER
	SELECT
		@precioBonoPlan = precioBono
	FROM 
		GESTIONAME_LAS_VACACIONES.Planes s
	JOIN GESTIONAME_LAS_VACACIONES.Pacientes p
	ON s.id = p.planes
		
	RETURN @precioBonoPlan * @cantidad;
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getPlanMedico (@idAfiliado INT)
RETURNS VARCHAR(30) 
AS
 BEGIN 
 RETURN (SELECT s.descripcion FROM GESTIONAME_LAS_VACACIONES.Planes s JOIN
								GESTIONAME_LAS_VACACIONES.Pacientes p ON (p.planes = s.descripcion)
			WHERE @idAfiliado = p.id) 
END
GO
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdPlanMedico (@descripcion VARCHAR(30))
RETURNS INT 
AS
 BEGIN 
 RETURN (SELECT s.id FROM GESTIONAME_LAS_VACACIONES.Planes s
			WHERE @descripcion = s.descripcion) 
END
GO
select * from GESTIONAME_LAS_VACACIONES.getIdPlanMedico("Plan medico 110")

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.buscarAfiliados(@nombre varchar(20),@apellido varchar(20), @numAfiliado int )
returns table as
return select * from GESTIONAME_LAS_VACACIONES.Pacientes where @numAfiliado <> -1 and  id = @numAfiliado and baja =0																
or @numAfiliado = -1 and  nombre  like @nombre and apellido like @apellido AND baja = 0
GO	
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional()
returns table 
as 
return select p.id as idProf, e.id as idEsp, p.nombre, p.apellido from GESTIONAME_LAS_VACACIONES.Profesionales p JOIN GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional e
ON e.idProfesional = p.id 
go


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.buscarProfesionales(@nombre varchar(20),@apellido varchar(20), @especialidad varchar(255), @matricula int )
returns table 
as 
return select idProf, GESTIONAME_LAS_VACACIONES.getDescEspecialidad(idEsp) as especialidad, nombre, apellido from GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional() a
WHERE a.nombre like @nombre or a.idProf = @matricula or a.apellido like @apellido or a.idEsp = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad)
go

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getHorarioDeAtencionDelProfesional(@matricula int, @especialidad as varchar(100))
RETURNS TABLE
AS
RETURN select a.fechaInicio, a.fechaFinal FROM GESTIONAME_LAS_VACACIONES.Agendas a
WHERE a.idProfesional = @matricula and a.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) and CURRENT_TIMESTAMP between fechaInicio and fechaFinal
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getDiasDeAtencionDelProfesional(@matricula int, @especialidad as varchar(100))
RETURNS TABLE
AS
RETURN select a.diaInicio, a.diaFin FROM GESTIONAME_LAS_VACACIONES.Agendas a
WHERE a.idProfesional = @matricula and a.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) and CURRENT_TIMESTAMP between fechaInicio and fechaFinal
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getTurnosAgendadosProfesional(@matricula int, @especialidad as varchar(100))
RETURNS TABLE
AS
RETURN select fecha from GESTIONAME_LAS_VACACIONES.Turnos t
WHERE t.idProfesional = @matricula and t.especialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) and baja = 0 
GO


--////////////////////////////////////--
--PROCEDURES--
--NUMERO 2--
--LOGUIN DE USUARIOS--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.LoguearUsuario(@username VARCHAR(255), @pass VARCHAR(255))
AS 
BEGIN
	DECLARE @usuario VARCHAR(255)
	DECLARE @intentos INT
	SELECT @intentos = intentos FROM GESTIONAME_LAS_VACACIONES.Usuarios
								WHERE usuario LIKE @username
	IF (@intentos >= 3)
		RAISERROR('El usuario se encuentra bloqueado por tener 3 intentos de logueo fallidos',16,217) WITH SETERROR
			
	SELECT @usuario = usuario FROM GESTIONAME_LAS_VACACIONES.Usuarios WHERE usuario LIKE @username AND pass LIKE @pass
	IF (@usuario IS NULL)
	BEGIN
		UPDATE GESTIONAME_LAS_VACACIONES.Usuarios
		SET intentos = @intentos +1 
		WHERE usuario = @username 
		RAISERROR(@pass,16,217) WITH SETERROR
	END
	ELSE
	BEGIN
	UPDATE GESTIONAME_LAS_VACACIONES.Usuarios 
	SET intentos = 0 
	WHERE usuario LIKE @username
	END
END
GO

--////////////////////////////////////--
--NUMERO 1--
--ABM ROLES--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades(@nombreRol VARCHAR(30))
RETURNS TABLE
AS
RETURN (SELECT funcionalidad.id, funcionalidad.descripcion
 FROM GESTIONAME_LAS_VACACIONES.Funcionalidades funcionalidad, GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad rolxfun
 WHERE funcionalidad.id = rolxfun.idFuncionalidad
 AND rolxfun.idRol = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol))
 GO


CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.crearRol(@nombreRol VARCHAR(30), @nombreUsuario VARCHAR(30))
AS 
BEGIN
IF  NOT EXISTS   (SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Roles WHERE  descripcion LIKE @nombreRol)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Roles(descripcion) VALUES(@nombreRol)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxUsuario(idRol, idUsuario) VALUES (GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol), @nombreUsuario)
END
ELSE
RAISERROR('El Rol ya existe',16,217) WITH SETERROR 
END
GO



CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerBaja(@nombreRol VARCHAR(30))
RETURNS TABLE
AS
RETURN (SELECT baja FROM GESTIONAME_LAS_VACACIONES.Roles WHERE descripcion = @nombreRol)
GO


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.existeRol(@nombreRol VARCHAR(30))
RETURNS INT
AS
BEGIN
IF EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Roles WHERE descripcion = @nombreRol)
BEGIN
RETURN 1
END
RETURN 0
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarRol(@nombre VARCHAR(30))
AS 
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Roles r WHERE r.descripcion = @nombre)
BEGIN
RAISERROR('El Rol no existe',16,217) WITH SETERROR  
END
ELSE
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Roles SET baja = 1 WHERE descripcion = @nombre
END
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.habilitarRol(@nombre VARCHAR(30))
AS
BEGIN
DECLARE @baja INTEGER
SELECT @baja= baja FROM GESTIONAME_LAS_VACACIONES.Roles WHERE descripcion = @nombre
IF (@baja = 1)
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Roles SET baja = 0 WHERE descripcion = @nombre
END
ELSE
BEGIN
RAISERROR('El Rol ya esta habilitado',16,217) WITH SETERROR   
END
END
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarRol(@nombreViejo VARCHAR(30), @nombreNuevo VARCHAR(30))
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Roles
SET descripcion= @nombreNuevo
WHERE descripcion= @nombreViejo
END
GO


--////////////////////////////////////--
--EL 3 ESTA HARCODEADO ARRIBA--
--NUMERO 4--
--ABM PACIENTES--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaPaciente(@nombre nvarchar(50), @apellido nvarchar(50), 
@doc INT, @direc VARCHAR(100), @tel INT, @mail VARCHAR(100), @nacimiento DATETIME, @sexo char, @civil VARCHAR(10),
@cantFami INT, @planes INT)
AS
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Pacientes ON
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE (apellido LIKE @apellido AND nombre LIKE @nombre) OR documento = @doc) 
INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(id,nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares,planes) VALUES (GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado(),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@planes)
ELSE
RAISERROR( 'El paciente ya existe',16,217) WITH SETERROR
END 
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaFamiliar(@idFamiliar INT,@nombre nvarchar(50), @apellido nvarchar(50), 
@doc INT, @direc VARCHAR(100), @tel INT, @mail VARCHAR(100), @nacimiento DATETIME, @sexo char, @civil VARCHAR(10),
@cantFami INT,@planes INT)
AS
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Pacientes ON
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE apellido LIKE @apellido AND documento = @doc) 
INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(id,nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares,planes) VALUES (GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar(@idFamiliar),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@planes)
ELSE
RAISERROR( 'El paciente ya existe',16,217)
END 
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarPaciente(@numAfiliado INT)
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Turnos SET baja = 1 WHERE idPaciente = @numAfiliado
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes SET baja = 1, fechaBaja = CURRENT_TIMESTAMP WHERE id = @numAfiliado
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente(@id INT,@direc VARCHAR(100),
 @tel INT, @mail VARCHAR(255), @sexo char, @civil VARCHAR(10),@cantFami INT,@plan INT)
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes
SET direccion = @direc, telefono = @tel, email = @mail, sexo = @sexo, 
estadoCivil = @civil, cantFamiliares = @cantFami,planes = @plan WHERE id = @id
END
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cambioPlan(@idPaciente INT,@descripcionPlan VARCHAR(30), @motivo VARCHAR(50))
AS
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Modificaciones(idPaciente,idPlan,motivo)
VALUES(@idPaciente,GESTIONAME_LAS_VACACIONES.getIdPlanMedico(@descripcionPlan),@motivo)
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes
SET planes = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@descripcionPlan)
WHERE id = @idPaciente
END
GO
--////////////////////////////////////--
--ABM FUNCIONALIDADES A ROL --


CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol (@nombreRol VARCHAR(30),@nombreFuncionalidad VARCHAR(30))
AS
BEGIN
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Funcionalidades WHERE descripcion LIKE @nombreFuncionalidad)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES (@nombreFuncionalidad)
END
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad,idRol) VALUES
( GESTIONAME_LAS_VACACIONES.getIdFuncionalidad(@nombreFuncionalidad),GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol))
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getDescripcionFuncionalidad(@id INTEGER)
RETURNS NVARCHAR(50)
AS
BEGIN
RETURN (SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Funcionalidades WHERE id = @id)
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerFuncionesNoCargadasAUnRol(@nombreRol NVARCHAR(50))
RETURNS TABLE
AS
RETURN (SELECT * FROM GESTIONAME_LAS_VACACIONES.Funcionalidades f WHERE f.descripcion NOT IN 
(SELECT fun.descripcion FROM GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad rolx 
JOIN GESTIONAME_LAS_VACACIONES.Funcionalidades fun 
ON rolx.idFuncionalidad = fun.id 
WHERE rolx.idRol = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol)))
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol (@nombreRol VARCHAR(30), @nombreFuncionalidad VARCHAR(30))
AS
BEGIN
DELETE FROM GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad 
WHERE idFuncionalidad = GESTIONAME_LAS_VACACIONES.getIdFuncionalidad(@nombreFuncionalidad)
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol (@nombreRol VARCHAR(30), @nombreFuncionalidadVieja VARCHAR(30), @nombreFuncionalidadNueva VARCHAR(30))
AS
BEGIN
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad WHERE idRol = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol) AND idFuncionalidad = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreFuncionalidadVieja))
RAISERROR ('No existe la funcionalidad o el rol que desea modificar',16,217)
ELSE 
UPDATE GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad 
SET idFuncionalidad = @nombreFuncionalidadNueva 
WHERE idFuncionalidad = GESTIONAME_LAS_VACACIONES.getIdFuncionalidad(@nombreFuncionalidadVieja)
END 
GO

--////////////////////////////////////--
-- LOS 5, 6, 7 NO SE HACEN--
--NUMERO 8--
--CREACION AGENDA PROFESIONAL--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaAgendaProfesional
(@matriculaProfesional  INT, @descEspecialidad VARCHAR(255), 
@fechaInicio  DATETIME, @fechaFin DATETIME, @diaInicio INT, 
  @diaFin INT)
AS
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, 
fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matriculaProfesional, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@descEspecialidad), @fechaInicio, @fechaFin, @diaInicio, @diaFin) 
END
GO

--////////////////////////////////////--
--NUMERO 9--
--COMPRA DE BONOS--

create function GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado(@numAfiliado INT)
RETURNS  TABLE 
AS 
RETURN (SELECT TOP 1 pl.descripcion,pl.precioBono FROM  GESTIONAME_LAS_VACACIONES.Pacientes p
join GESTIONAME_LAS_VACACIONES.Planes pl
on p.planes = pl.id
where   @numAfiliado = p.id)
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.compraDeBonos(@numAfiliado INT, @cantidad INT)
AS
BEGIN
DECLARE @aux INT
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE id = @numAfiliado)
RAISERROR ('No existe el afiliado',16,217)
ELSE 
INSERT INTO GESTIONAME_LAS_VACACIONES.ComprasBonos(idPaciente, cantidad, monto) 
VALUES (@numAfiliado, @cantidad, GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan(@numAfiliado, @cantidad))
WHILE (@aux < @cantidad)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Bonos(id, idPaciente, idPlan) 
VALUES ((SELECT id FROM GESTIONAME_LAS_VACACIONES.ComprasBonos WHERE idPaciente = @numAfiliado AND fecha = CURRENT_TIMESTAMP) , @numAfiliado, (SELECT p.planes FROM GESTIONAME_LAS_VACACIONES.Pacientes p WHERE id = @numAfiliado))
SET @aux = @aux + 1
END
END
GO

--////////////////////////////////////--
--NUMERO 10--
--RESERVA DE TURNOS--

SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Turnos ON
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.reservarTurno(@matricula INT, @numAfiliado INT, @especialidad VARCHAR(255), @fecha DATETIME)
AS
BEGIN
IF (NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idProfesional = @matricula AND fecha = @fecha))
	INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos (idPaciente, idProfesional, especialidad, fecha) 
	VALUES (@numAfiliado, @matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) , @fecha) 
END
GO

--////////////////////////////////////--
--NUMERO 11--
--REGISTRO DE LLEGADA--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerIdProfesional(@nombre  VARCHAR(255), @apellido VARCHAR(255))
RETURNS TABLE 
AS
RETURN SELECT  p.id FROM GESTIONAME_LAS_VACACIONES.Profesionales p where p.nombre like @nombre or p.apellido like @apellido;
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosDelprofesional(@nombreProf  varchar(255),@apellidoProf  VARCHAR(255), @especialidadProf VARCHAR(255), @idTurno INT)
RETURNS TABLE 
AS 
RETURN SELECT id , fecha, idPaciente, especialidad, idProfesional FROM GESTIONAME_LAS_VACACIONES.Turnos t 
where (t.idProfesional  in 
					(select id from GESTIONAME_LAS_VACACIONES.obtenerIdProfesional( @nombreProf ,  @apellidoProf))
and t.especialidad like @especialidadProf) OR t.id = @idTurno
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.registrarLlegada(@numAfiliado INT, @matricula INT, @especialidad VARCHAR(30))
AS
BEGIN

DECLARE @bonoID INT
DECLARE @turnoID INT

IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idPaciente = @numAfiliado	
						AND idProfesional = @matricula
						AND  CAST(fecha AS DATE) = CAST(CURRENT_TIMESTAMP AS DATE))
RAISERROR('No existe el turno',16,217)
ELSE

SELECT @bonoID = min(b.id) 
FROM GESTIONAME_LAS_VACACIONES.Pacientes p JOIN GESTIONAME_LAS_VACACIONES.Bonos b 
ON p.id/100 = b.idPaciente/100 AND b.usado = 0

SELECT @TurnoID = id FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idPaciente = @numAfiliado	
						AND idProfesional = @matricula
						AND  CAST(fecha AS DATE) = CAST(CURRENT_TIMESTAMP AS DATE)

INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultasMedicas(idBono, fecha, idTurno) 
VALUES (@bonoID, CURRENT_TIMESTAMP, @turnoID)

UPDATE GESTIONAME_LAS_VACACIONES.Bonos
SET usado = 1
WHERE id = @bonoID

END
GO

--////////////////////////////////////--
--NUMERO 12--
--CARGA DE SINTOMAS Y DIAGNOSTICO A LA CONSULTA MEDICA--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cargarSintomasYDiagnostico(@idBono INT, @diagnostico VARCHAR(255), @sintomas VARCHAR(255))
AS
BEGIN

UPDATE GESTIONAME_LAS_VACACIONES.ConsultasMedicas
SET diagnostico = @diagnostico, sintomas = @sintomas
WHERE idBono = @idBono
END
GO

--////////////////////////////////////--
--NUMERO 13--
--CANCELACION DE TURNOS--
--PACIENTE--
	
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado(@numAfiliado INT, @matricula INT, @especialidad VARCHAR(30), @fecha DATETIME, @motivo VARCHAR(255))
AS
BEGIN
IF (NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idPaciente = @numAfiliado 
				AND (idProfesional = @matricula or especialidad LIKE @especialidad) 
				AND fecha = @fecha AND CAST(fecha AS DATE) < CAST(CURRENT_TIMESTAMP AS DATE) ))
	
RAISERROR( 'Como va a cancelar un turno que nunca agendo usted es hijo de primos',16,217)
ELSE 
UPDATE GESTIONAME_LAS_VACACIONES.Turnos 
SET baja = 1, tipoCancelacion = 0, motivo = @motivo
WHERE idPaciente = @numAfiliado AND (idProfesional = @matricula or especialidad LIKE @especialidad) AND fecha = @fecha
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerIdPaciente(@nombre  VARCHAR(255), @apellido VARCHAR(255), @dni INT)
RETURNS INT
AS
BEGIN
DECLARE @id INT
SELECT  @id = p.id FROM GESTIONAME_LAS_VACACIONES.Pacientes p where p.nombre=@nombre AND p.apellido=@apellido AND p.documento=@dni
RETURN @id
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelAfiliadoSegunId(@idAfiliado INT)
RETURNS TABLE
AS
RETURN (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos turnos 
WHERE turnos.idPaciente = @idAfiliado AND turnos.tipoCancelacion IS NULL)
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosDelAfiliado(@nombreAfiliado NVARCHAR(50), @apellido NVARCHAR(50), @dni INT)
RETURNS TABLE
AS
RETURN (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos turnos 
WHERE turnos.idPaciente = (GESTIONAME_LAS_VACACIONES.obtenerIdPaciente(@nombreAfiliado, @apellido, @dni)))
GO




--////////////////////////////////////--
--PROFESIONAL--


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelProfesionalSegunId(@matricula INT)
RETURNS TABLE
AS
RETURN (SELECT id, idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin 
FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @matricula AND baja=0)
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@fecha DATETIME, @delta INT)
RETURNS VARCHAR(100)
AS
BEGIN
SET @fecha = DATEADD(day,@delta, @fecha)
RETURN CAST(@fecha AS datetime) 
END
GO 

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional(@matricula INT, @especialidad VARCHAR(255), @diaACancelar DATETIME, @motivo VARCHAR(255))
AS
BEGIN 
DECLARE @inicioAux DATETIME
DECLARE @finalAux DATETIME
DECLARE @diaInicialAux INT
DECLARE @diaFinalAux INT

IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @matricula 
				AND @diaACancelar BETWEEN fechaInicio AND fechaFinal
				AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad )
BEGIN
RAISERROR('El dia no se encuentra agendado',16,217)
END
ELSE
BEGIN
SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agendas 
WHERE idProfesional = @matricula 
	AND @diaACancelar BETWEEN fechaInicio AND fechaFinal
	  AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Agendas 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula AND @diaACancelar BETWEEN fechaInicio AND fechaFinal AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Turnos
SET baja = 1, tipoCancelacion = 1, motivo = @motivo
WHERE idProfesional = @matricula AND especialidad = @especialidad AND fecha = @diaACancelar

IF (@diaACancelar != @inicioAux AND @diaACancelar != @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@diaACancelar, -1), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad),  GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@diaACancelar, +1), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaACancelar = @inicioAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad),GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@inicioAux, +1), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaACancelar = @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@finalAux, -1), @diaInicialAux, @diaFinalAux)

END
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional(@matricula INT, @especialidad VARCHAR(255), @diaInicialACancelar DATETIME, @diaFinalACancelar DATETIME, @motivo VARCHAR(255))
AS
BEGIN 
DECLARE @inicioAux AS DATETIME
DECLARE @finalAux AS DATETIME
DECLARE @diaInicialAux AS INT
DECLARE @diaFinalAux AS INT


IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @matricula 
				AND @diaInicialACancelar BETWEEN fechaInicio AND fechaFinal
				AND @diaFinalACancelar BETWEEN fechaInicio AND fechaFinal
				AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad )
RAISERROR( 'El rango de fechas no se encuentra agendado',16,217)
ELSE

SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agendas 
WHERE idProfesional = @matricula 
	  AND @diaInicialACancelar BETWEEN fechaInicio AND fechaFinal
	  AND @diaFinalACancelar BETWEEN fechaInicio AND fechaFinal
	  AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Agendas 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula 
	AND @diaInicialACancelar BETWEEN fechaInicio AND fechaFinal
	AND @diaFinalACancelar BETWEEN fechaInicio AND fechaFinal 
	AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Turnos
SET baja = 1, tipoCancelacion = 1, motivo = @motivo
WHERE idProfesional = @matricula 
	AND especialidad = @especialidad 
	AND fecha BETWEEN  @diaInicialACancelar AND @diaFinalACancelar

IF (@diaInicialACancelar != @inicioAux AND @diaFinalACancelar != @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1,  @diaInicialACancelar ), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @diaFinalACancelar), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaInicialACancelar = @inicioAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @diaFinalACancelar), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaFinalACancelar = @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1, @diaInicialACancelar), @diaInicialAux, @diaFinalAux)

END
GO


--////////////////////////////////////--
--NUMERO 14--
--LISTADO ESTRATEGICO--
--TOP 5 ESPECIALIDADES CON MAS CANCELACIONES--

CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones(@fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE 
AS
RETURN (SELECT GESTIONAME_LAS_VACACIONES.getIdEspecialidad(t.especialidad) AS especialidades, a.idEspecialidad AS especialidades2 
FROM GESTIONAME_LAS_VACACIONES.Turnos t JOIN GESTIONAME_LAS_VACACIONES.Agendas a ON (t.baja = 1 or a.baja = 1) AND t.fecha BETWEEN @fechaInicio AND @fechaFin)
GO

CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones(@fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE 
AS
RETURN (SELECT especialidades FROM GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones(@fechaInicio,@fechaFin)
UNION ALL
SELECT especialidades2 FROM GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones(@fechaInicio,@fechaFin))
--ORDER BY especialidades, especialidades2)
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones(@fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE 
AS
RETURN (SELECT TOP 5 GESTIONAME_LAS_VACACIONES.getDescEspecialidad(especialidades) as especialidades
FROM GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones(@fechaInicio,@fechaFin) where especialidades is not null);
GO

--TOP 5 PROFESIONALES MAS CONSULTADOS POR PLAN ESPECIFICANDO ESPECIALIDAD--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas(@planes INT,@fechaInicio as DATETIME,@fechaFin as DATETIME)
RETURNS TABLE AS
RETURN (SELECT p.id AS idProf, COUNT(p.id) AS cantConsultas
FROM GESTIONAME_LAS_VACACIONES.ConsultasMedicas c JOIN GESTIONAME_LAS_VACACIONES.Turnos t 
ON c.idTurno = t.id
JOIN GESTIONAME_LAS_VACACIONES.Profesionales p
ON t.idProfesional = p.id
JOIN GESTIONAME_LAS_VACACIONES.Pacientes pac
ON t.idPaciente = pac.id AND pac.planes = @planes and c.fecha between @fechaInicio and @fechaFin
GROUP BY p.id)
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getTop5Profesionales(@planes INT,@fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE AS
RETURN SELECT TOP 5 cantConsultas, idProf
FROM GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas(@planes,@fechaInicio,@fechaFin)
ORDER BY cantConsultas
GO


--Top 5 de las especialidades de médicos con más bonos de consultas utilizados--
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida(@planes INT, @fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE AS
RETURN (SELECT a.idProf AS profesional, COUNT(t.especialidad) AS vecesEspecialidad
FROM  GESTIONAME_LAS_VACACIONES.getTop5Profesionales(@planes,@fechaInicio,@fechaFin) a
JOIN GESTIONAME_LAS_VACACIONES.Turnos t
ON a.idProf = t.idProfesional
GROUP BY a.idProf, t.especialidad)
GO

-- Pacientes con mas compras--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras(@fechaInicio DATETIME,@fechaFin  DATETIME)
RETURNS TABLE AS
RETURN (SELECT TOP 5 unPaciente.id , unPaciente.nombre, unPaciente.apellido , (SELECT count(id) FROM GESTIONAME_LAS_VACACIONES.Pacientes familiar WHERE familiar.id/100  = unPaciente.id/100 AND familiar.id <> unPaciente.id) AS 'Cantidad de familiares'
FROM GESTIONAME_LAS_VACACIONES.Pacientes  unPaciente 
JOIN GESTIONAME_LAS_VACACIONES.ComprasBonos compra ON  unPaciente.id/100 = compra.idPaciente/100 and compra.fecha between @fechaInicio and @fechaFin
GROUP BY unPaciente.id, unPaciente.nombre,unPaciente.apellido  
ORDER BY COUNT(compra.idPaciente))
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas(@fechaInicio DATETIME, @fechaFin DATETIME)
RETURNS TABLE AS 
RETURN (SELECT TOP 5 GESTIONAME_LAS_VACACIONES.getDescEspecialidad(especialidad.id) as especialidad FROM GESTIONAME_LAS_VACACIONES.Especialidades especialidad
JOIN (GESTIONAME_LAS_VACACIONES.ConsultasMedicas consulta
JOIN GESTIONAME_LAS_VACACIONES.Turnos turno
ON turno.id = consulta.idTurno and consulta.fecha between @fechaInicio and @fechaFin)
ON turno.especialidad = especialidad.descripcion
GROUP BY especialidad.id
ORDER BY COUNT(consulta.id))
GO

create table GESTIONAME_LAS_VACACIONES.TablaTemporalListado(
idProfesional INT, 
cantidadDeHoras INT
) 
go
go
create procedure GESTIONAME_LAS_VACACIONES.profesionalesConMasHoras
as BEGIN
declare @horaInicio  TIME , @horaFin TIME
declare @idProfesional int
declare @diaInicio int, @diaFin int

DECLARE cursoram cursor for select  idProfesional,Cast(fechaInicio as time),cast(fechaFinal as time), diaInicio,diaFin from GESTIONAME_LAS_VACACIONES.Agendas
OPEN cursoram fetch next from 
cursoram into @idProfesional,@horaInicio,@horaFin, @diaInicio , @diaFin 
while (@@FETCH_STATUS =0 )
begin 
insert into GESTIONAME_LAS_VACACIONES.TablaTemporalListado values (@idProfesional,  DATEPART(HOUR, @horaFin)*100+DATEPART(MINUTE,@horaFin)-DATEPART(HOUR, @horaInicio)*100 +DATEPART(MINUTE,@horaInicio) * (@diaFin-@diaInicio+1))
fetch next from cursoram into @idProfesional,@horaInicio,@horaFin, @diaInicio , @diaFin 
end 
close cursoram
deallocate cursoram
END
GO

exec GESTIONAME_LAS_VACACIONES.profesionalesConMasHoras 
go

create function GESTIONAME_LAS_VACACIONES.topprofesionalesConMasHoras(@plan INT, @especialidad INT, @fechaInicio datetime,@fechafin datetime)
returns table as 
return (select top 5 sum(temp.cantidadDeHoras) cantidadDeHorasTotales, p.nombre, p.apellido from GESTIONAME_LAS_VACACIONES.TablaTemporalListado temp 
join GESTIONAME_LAS_VACACIONES.Profesionales p 
on p.id = temp.idProfesional
group by p.nombre , p.apellido)
go

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada(@id INTEGER)
RETURNS TABLE AS
RETURN (SELECT tipoEspecialidad FROM GESTIONAME_LAS_VACACIONES.Especialidades e JOIN 
GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional x ON e.id = x.idEspecialidad JOIN 
GESTIONAME_LAS_VACACIONES.Profesionales p ON x.idProfesional = p.id WHERE p.id = @id 
AND tipoEspecialidad NOT IN (SELECT idEspecialidad FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @id)) 

GO
