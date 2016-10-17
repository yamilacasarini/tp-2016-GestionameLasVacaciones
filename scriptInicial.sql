DROP TABLE Funcionalidad
DROP TABLE Rol
DROP TABLE Usuario
DROP TABLE RolxFuncionalidad
DROP TABLE RolxUsuario
DROP TABLE Paciente
DROP TABLE Profesional
DROP TABLE Agenda
DROP TABLE CompraBono
DROP TABLE Servicio
DROP TABLE Modificacion
DROP TABLE Bono
DROP TABLE ConsultaMedica
DROP TABLE Turno
DROP TABLE Cancelacion
DROP TABLE Especialidad
DROP TABLE EspecialidadxProfesional
DROP TABLE AgendaxEspxProf

CREATE TABLE Funcionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL ,
  )
CREATE TABLE Rol(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL,
  baja INT DEFAULT 0,
  )
CREATE TABLE Usuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  usuario NVARCHAR(255) NOT NULL,
  pass NVARCHAR(255) NULL ,
  baja INT default 0,
  fechaBaja DATE,
  )
CREATE TABLE RolxFuncionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idFuncionalidad INT REFERENCES Funcionalidad(id) ,
  )
CREATE TABLE RolxUsuario(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idUsuario INT REFERENCES Usuario(id) ,
  )
CREATE TABLE Paciente (
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
CREATE TABLE Profesional (
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
CREATE TABLE Agenda(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idProfesional INT REFERENCES Profesional(id),
  fechaInicio DATE NOT NULL,   -- ACA PARA FECHA DEL AÑO QUE TRABAJA Y HORARIO
  fechaFinal DATE NOT NULL,
  diaInicio VARCHAR(10),   -- ACA PARA LUNES Y MARTES
  )
CREATE TABLE CompraBono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idPaciente INT REFERENCES Paciente(id),
  cantidad INT NOT NULL DEFAULT 1,
  monto INT NOT NULL,
   )
CREATE TABLE Servicio(
  id INTEGER PRIMARY KEY,
  precioBono INT,
  precioCuota INT ,
  descripcion varchar(255),
  baja INT DEFAULT 0,
   )
CREATE TABLE Modificacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES Paciente(id),
  idPlan INT REFERENCES Servicio(id),
  fecha DATE DEFAULT NULL,
   )
CREATE TABLE Bono(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPaciente INT REFERENCES Paciente(id),
  idPlan INT REFERENCES Servicio(id),
  idCompraBono INT REFERENCES CompraBono(id),
   )
CREATE TABLE ConsultaMedica(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idBono INT REFERENCES Bono(id),
  fecha DATE NOT NULL,
  diagnostico VARCHAR(255) NOT NULL,
  sintomas VARCHAR(255),
   )
CREATE TABLE Turno(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idProfesional INT REFERENCES Profesional(id),
  idPaciente INT REFERENCES Paciente(id),
  idConsultaMedica INT REFERENCES ConsultaMedica(id),
  fecha DATE NOT NULL,
  baja INT default 0,
  )
CREATE TABLE Cancelacion(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idConsultaMedica INT REFERENCES ConsultaMedica(id),
  tipoCancelacion INT NOT NULL,
  motivo VARCHAR(255),
  )
CREATE TABLE Especialidad(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion VARCHAR(255),
  tipoEspecialidad VARCHAR(30),
  )
CREATE TABLE AgendaxEspxProf(
	idAgenda INT REFERENCES Agenda(id),
	idEspecialidad INT REFERENCES Especialidad(id),
	idProfesional INT REFERENCES Profesional(id),
)
CREATE TABLE EspecialidadxProfesional(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEspecialidad INT REFERENCES Especialidad(id) ,
  idProfesional INT REFERENCES Profesional(id) ,
  )

--- Tablas temporales

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
INSERT INTO Rol(descripcion) VALUES ('Administrativo')
INSERT INTO Rol(descripcion) VALUES ('Afiliado')
INSERT INTO Rol(descripcion) VALUES ('Profesional')

INSERT INTO Funcionalidad(descripcion) VALUES ('ABM ROL')
INSERT INTO Funcionalidad(descripcion) VALUES ('ABM AFILIADOS')
INSERT INTO Funcionalidad(descripcion) VALUES ('COMPRA BONOS')
INSERT INTO Funcionalidad(descripcion) VALUES ('PEDIDO DE TURNO')
INSERT INTO Funcionalidad(descripcion) VALUES ('REGISTRO DE LLEGADA')
INSERT INTO Funcionalidad(descripcion) VALUES ('CANCELAR TURNO')
INSERT INTO Funcionalidad(descripcion) VALUES ('LISTADO ESTADISTICO')

INSERT INTO Usuario (usuario, pass) VALUES ('admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')

INSERT INTO #PacienteTemporal(nombre,apellido,dni,direccion,telefono,email,fechaNacimiento,idPlan,descripcion,precioBono,precioCuota, Compra_Bono_Fecha)
SELECT DISTINCT Paciente_Nombre,Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,Paciente_Fecha_Nac,
				Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Farmacia,Plan_Med_Precio_Bono_Consulta, Compra_Bono_Fecha
					FROM gd_esquema.Maestra


INSERT INTO Paciente(nombre,apellido,documento, direccion, telefono, email, fechaNacimiento)
	SELECT distinct nombre,apellido,dni,direccion,telefono,email,fechaNacimiento
		FROM #PacienteTemporal

INSERT INTO Servicio(id,descripcion, precioCuota, precioBono)
	SELECT DISTINCT idPlan,descripcion, precioCuota, precioBono
		FROM #PacienteTemporal

INSERT INTO Modificacion(idPaciente,idPlan)
	SELECT DISTINCT id,idPlan
		FROM #PacienteTemporal

--Preguntar		
--INSERT INTO CompraBono(idPaciente,cantidad,monto)
--	SELECT id, COUNT(cantidad), suma
--	FROM gd_esquema.Maestra
--	GROUP BY Paciente_nombre, Paciente_Apellido, Paciente_Dni

INSERT INTO Profesional(nombre,apellido,documento,direccion,email,fechaNacimiento,telefono)
	SELECT DISTINCT Medico_Nombre,Medico_Apellido,Medico_Dni,Medico_Direccion,Medico_Mail,Medico_Fecha_Nac,Medico_Telefono
	FROM gd_esquema.Maestra
	WHERE Medico_Nombre IS NOT NULL
	
INSERT INTO RolxFuncionalidad(idFuncionalidad, idRol)
	SELECT DISTINCT Funcionalidad.id, Rol.id FROM Funcionalidad, Rol WHERE Rol.id = 1

INSERT INTO RolxUsuario(idRol, idUsuario) 
	SELECT   Rol.id, Usuario.id FROM Rol , Usuario  WHERE Rol.id = 1

--Probar, depende del inserser de CompraBono DE ACA PARA ABAJO
INSERT INTO Bono(idCompraBono, idPaciente, idPlan)
	SELECT c.id, p.id, s.id FROM CompraBono c, Paciente p, Servicio s


INSERT INTO Especialidad(id,descripcion,tipoEspecialidad)
	SELECT DISTINCT	Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Descripcion
	FROM gd_esquema.Maestra

--Meter Bono_Consulta_Numero en algun lugar del bono ACORDARSE
INSERT INTO ConsultaMedica(idBono, sintomas, fecha, diagnostico)
	SELECT b.id, Consulta_Sintomas, Turno_Fecha, Consulta_Enfermedades FROM Bono b, gd_esquema.Maestra

INSERT INTO Turno(idConsultaMedica, idPaciente, idProfesional, fecha)
	SELECT c.id, p.id, prof.id, Turno_Fecha FROM ConsultaMedica c, Paciente p, Profesional prof, gd_esquema.Maestra

INSERT INTO Especialidad(descripcion, tipoEspecialidad)
	SELECT DISTINCT Especialidad_Descripcion, Especialidad_Codigo 
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL AND Especialidad_Descripcion IS NOT NULL

INSERT INTO AgendaxEspxProf(idAgenda, idEspecialidad, idProfesional)
	SELECT a.id, e.id, p.id FROM Agenda a, Especialidad e, Profesional p

INSERT INTO EspecialidadxProfesional(idEspecialidad, idProfesional)
	SELECT e.id, p.id FROM Especialidad e, Profesional p

-- FUNCION PARA SACAR EL idUsuario del DNI
GO

CREATE FUNCTION funcObtenerIdDeDni(@dni INT)
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



