CREATE SCHEMA [GESTIONAME_LAS_VACACIONES]
GO

DROP TABLE GESTIONAME_LAS_VACACIONES.Funcionalidad
DROP TABLE GESTIONAME_LAS_VACACIONES.Rol
DROP TABLE GESTIONAME_LAS_VACACIONES.Usuario
DROP TABLE GESTIONAME_LAS_VACACIONES.RolxFuncionalidad
DROP TABLE GESTIONAME_LAS_VACACIONES.RolxUsuario
DROP TABLE GESTIONAME_LAS_VACACIONES.Paciente
DROP TABLE GESTIONAME_LAS_VACACIONES.Profesional
DROP TABLE GESTIONAME_LAS_VACACIONES.Agenda
DROP TABLE GESTIONAME_LAS_VACACIONES.CompraBono
DROP TABLE GESTIONAME_LAS_VACACIONES.Servicio
DROP TABLE GESTIONAME_LAS_VACACIONES.Modificacion
DROP TABLE GESTIONAME_LAS_VACACIONES.Bono
DROP TABLE GESTIONAME_LAS_VACACIONES.ConsultaMedica
DROP TABLE GESTIONAME_LAS_VACACIONES.Turno
DROP TABLE GESTIONAME_LAS_VACACIONES.Cancelacion
DROP TABLE GESTIONAME_LAS_VACACIONES.Especialidad
DROP TABLE GESTIONAME_LAS_VACACIONES.EspecialidadxProfesional
DROP TABLE GESTIONAME_LAS_VACACIONES.AgendaxEspxProf

CREATE TABLE GESTIONAME_LAS_VACACIONES.Funcionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Rol(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL,
  baja INT DEFAULT 0,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Usuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  usuario NVARCHAR(255) NOT NULL,
  pass NVARCHAR(255) NULL ,
  baja INT default 0,
  fechaBaja DATE,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolxFuncionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idFuncionalidad INT REFERENCES Funcionalidad(id) ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.RolxUsuario(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idUsuario INT REFERENCES Usuario(id) ,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Paciente (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
 -- tipoDocumento VARCHAR NOT NULL,
  documento INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATE NOT NULL,
  sexo CHAR,
  estadoCivil VARCHAR(10),
  cantFamiliares INT DEFAULT 0,
  cantConsultas INT DEFAULT 0,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Profesional (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido VARCHAR(50) NOT NULL,
  tipoDocumento VARCHAR,
  documento INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATE NOT NULL,
  sexo CHAR,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Agenda(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idProfesional INT REFERENCES Profesional(id),
  fechaInicio DATE NOT NULL,   -- ACA PARA FECHA DEL AÑO QUE TRABAJA Y HORARIO
  fechaFinal DATE NOT NULL,
  diaInicio VARCHAR(10),   -- ACA PARA LUNES Y MARTES
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.CompraBono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idPaciente INT REFERENCES Paciente(id),
  cantidad INT NOT NULL DEFAULT 1,
  monto INT NOT NULL,
  fecha DATE NOT NULL,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Servicio(
  id INTEGER PRIMARY KEY,
  precioBono INT,
  precioCuota INT ,
  descripcion varchar(255),
  baja INT DEFAULT 0,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Modificacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES Paciente(id),
  idPlan INT REFERENCES Servicio(id),
  fecha DATE DEFAULT NULL,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Bono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES Paciente(id),
  idPlan INT REFERENCES Servicio(id),
  idCompraBono INT REFERENCES CompraBono(id),
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.ConsultaMedica(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idBono INT REFERENCES Bono(id),
  fecha DATE NOT NULL,
  diagnostico VARCHAR(255) NOT NULL,
  sintomas VARCHAR(255),
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Turno(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idProfesional INT REFERENCES Profesional(id),
  idPaciente INT REFERENCES Paciente(id),
  idConsultaMedica INT REFERENCES ConsultaMedica(id),
  fecha DATE NOT NULL,
  baja INT default 0,
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Cancelacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idConsultaMedica INT REFERENCES ConsultaMedica(id),
  tipoCancelacion INT NOT NULL,
  motivo VARCHAR(255),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Especialidad(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion VARCHAR(255),
  tipoEspecialidad VARCHAR(30),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.AgendaxEspxProf(
	idAgenda INT REFERENCES Agenda(id),
	idEspecialidad INT REFERENCES Especialidad(id),
	idProfesional INT REFERENCES Profesional(id),
)
CREATE TABLE GESTIONAME_LAS_VACACIONES.EspecialidadxProfesional(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEspecialidad INT REFERENCES Especialidad(id) ,
  idProfesional INT REFERENCES Profesional(id) ,
  )
 

DROP TABLE #PacienteTemporal

CREATE TABLE #PacienteTemporal(
 id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(50) NOT NULL ,
  apellido NVARCHAR(50) NOT NULL ,
  dni INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATE NOT NULL,
  idPlan INT,
  precioBono INT NOT NULL,
  precioCuota INT NOT NULL,
  descripcion varchar(255),
  Compra_Bono_Fecha datetime,
  )

--- Creando los datos
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

INSERT INTO GESTIONAME_LAS_VACACIONES.Modificacion(idPaciente,idPlan)
	SELECT DISTINCT id,idPlan
		FROM #PacienteTemporal


INSERT INTO CompraBono(idPaciente,fecha,cantidad,monto)
select p.id,Bono_Consulta_Fecha_Impresion, COUNT(Bono_Consulta_Fecha_Impresion) as cantidad_bonos_por_dia,  COUNT(Bono_Consulta_Fecha_Impresion)* Plan_Med_Precio_Bono_Consulta as monto
from gd_esquema.Maestra m , Paciente p 
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


INSERT INTO GESTIONAME_LAS_VACACIONES.Especialidad(id,descripcion,tipoEspecialidad)
	SELECT DISTINCT	Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Descripcion
	FROM gd_esquema.Maestra

--Meter Bono_Consulta_Numero en algun lugar del bono ACORDARSE
INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultaMedica(idBono, sintomas, fecha, diagnostico)
	SELECT b.id, Consulta_Sintomas, Turno_Fecha, Consulta_Enfermedades FROM GESTIONAME_LAS_VACACIONES.Bono b, gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Turno(idConsultaMedica, idPaciente, idProfesional, fecha)
	SELECT c.id, p.id, prof.id, Turno_Fecha FROM GESTIONAME_LAS_VACACIONES.ConsultaMedica c, GESTIONAME_LAS_VACACIONES.Paciente p, GESTIONAME_LAS_VACACIONES.Profesional prof, gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Especialidad(descripcion, tipoEspecialidad)
	SELECT DISTINCT Especialidad_Descripcion, Especialidad_Codigo 
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL AND Especialidad_Descripcion IS NOT NULL

INSERT INTO GESTIONAME_LAS_VACACIONES.AgendaxEspxProf(idAgenda, idEspecialidad, idProfesional)
	SELECT a.id, e.id, p.id FROM GESTIONAME_LAS_VACACIONES.Agenda a, GESTIONAME_LAS_VACACIONES.Especialidad e, GESTIONAME_LAS_VACACIONES.Profesional p

INSERT INTO GESTIONAME_LAS_VACACIONES.EspecialidadxProfesional(idEspecialidad, idProfesional)
	SELECT e.id, p.id FROM GESTIONAME_LAS_VACACIONES.Especialidad e, GESTIONAME_LAS_VACACIONES.Profesional p

-- FUNCION PARA SACAR EL idUsuario del DNI
GO

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
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.logueo(@username VARCHAR(255), @pass VARCHAR(255))
AS BEGIN
	DECLARE @usuario NUMERIC(18,0)
	DECLARE @intentos INT
	SELECT @intentos = intentos FROM GESTIONAME_LAS_VACACIONES.Intentos i
								JOIN GESTIONAME_LAS_VACACIONES.Usuarios u ON i.usuario_id = u.id
								WHERE u.usuario = @username
	IF (@intentos >= 3)
		RAISERROR('El usuario se encuentra bloqueado por tener 3 intentos de logueo fallidos',16,217) WITH SETERROR
			
	SELECT @usuario = id FROM GESTIONAME_LAS_VACACIONES.Usuarios WHERE usuario = @username AND pass = HASHBYTES('SHA2_256', @pass)
	IF (@usuario IS NULL)
	BEGIN	
		UPDATE intentos SET intentos = @intentos + 1 
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
	UPDATE intentos SET intentos = 0 
	FROM GESTIONAME_LAS_VACACIONES.Usuarios usuarios
	JOIN GESTIONAME_LAS_VACACIONES.Intentos intentos ON intentos.usuario_id = usuarios.id
	WHERE usuarios.usuario = @username
END
GO
