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
DROP TABLE CancelacionProfesional
DROP TABLE Especialidad
DROP TABLE EspecialidadxProfesional


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
  tipoDocumento VARCHAR NOT NULL,
  documento INT NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono INT NOT NULL,
  email VARCHAR(255),
  fechaNacimiento DATE NOT NULL,
  sexo CHAR NOT NULL,
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
  fecha DATE,
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
CREATE TABLE CancelacionProfesional(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idProfesional INT REFERENCES Profesional(id),
  fecha DATE NOT NULL
  )
CREATE TABLE Especialidad(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion VARCHAR(255),
  tipoEspecialidad VARCHAR(30) NOT NULL,
  )
CREATE TABLE EspecialidadxProfesional(
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEspecialidad INT REFERENCES Especialidad(id) ,
  idProfesional INT REFERENCES Profesional(id) ,
  )

--- Tablas temporales

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
  )

--- Creando los datos
INSERT INTO Rol(descripcion) VALUES ('Administrativo')
INSERT INTO Rol(descripcion) VALUES ('Afiliado')
INSERT INTO Rol(descripcion) VALUES ('Profesional')

INSERT INTO #PacienteTemporal(nombre,apellido,dni,direccion,telefono,email,fechaNacimiento,idPlan,descripcion,precioBono,precioCuota)
SELECT DISTINCT Paciente_Nombre,Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,Paciente_Fecha_Nac,
				Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Farmacia,Plan_Med_Precio_Bono_Consulta
					FROM gd_esquema.Maestra

INSERT INTO Paciente(nombre,apellido,documento, direccion, telefono, email, fechaNacimiento)
	SELECT DISTINCT nombre,apellido,dni,direccion,telefono,email,fechaNacimiento
		FROM #PacienteTemporal

INSERT INTO Servicio(id,descripcion)
	SELECT DISTINCT idPlan,descripcion
		FROM #PacienteTemporal

INSERT INTO Modificacion(idPaciente,idPlan)
	SELECT DISTINCT id,idPlan
		FROM #PacienteTemporal
		
INSERT INTO CompraBono(idPaciente,cantidad,monto)
	SELECT DISTINCT id,COUNT(precioBono) + COUNT(precioCuota),SUM(precioBono) + SUM(precioCuota)
	FROM #PacienteTemporal
	GROUP BY id

INSERT INTO Profesional(Nombre,apellido,documento,direccion,email,fechaNacimiento,telefono)
	SELECT DISTINCT Medico_Nombre,Medico_Apellido,Medico_Dni,Medico_Direccion,Medico_Mail,Medico_Fecha_Nac,Medico_Telefono
	FROM gd_esquema.Maestra
	
	-- Que?
INSERT INTO Especialidad(id,descripcion,tipoEspecialidad)
	SELECT DISTINCT	Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Descripcion
	FROM gd_esquema.Maestra
	
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
SELECT * FROM gd_esquema.Maestra
