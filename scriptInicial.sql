IF NOT EXISTS ( SELECT  *
				FROM    sys.schemas
				WHERE   name = N'GESTIONAME_LAS_VACACIONES' ) 
	EXEC('CREATE SCHEMA [GESTIONAME_LAS_VACACIONES]');
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

IF OBJECT_ID (N'tempdb..#PacientesTemporal', N'U') IS NOT NULL 
DROP TABLE #PacientesTemporal
GO


IF OBJECT_ID('PARCIAL.cargar_pais', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME
GO
IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.funcObtenerIdDeDni'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.funcObtenerIdDeDni;
GO
IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.getIdEspecialidad'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdEspecialidad;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.getIdFuncionalidad'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdFuncionalidad;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.getIdRol'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdRol;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.getPlanMedico'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getPlanMedico;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.getIdPlanMedico'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdPlanMedico;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.buscarAfiliados'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.buscarAfiliados;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado;
GO

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar'
             , N'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.LoguearUsuario', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.LoguearUsuario;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.crearRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.crearRol;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.borrarRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.borrarRol;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.modificarRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarRol;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.altaPaciente', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.altaPaciente;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.altaFamiliar', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.altaFamiliar;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.borrarPaciente', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.borrarPaciente;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.modificarPaciente', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.cambioPlan', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cambioPlan;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.altaAgendaProfesional', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.altaAgendaProfesional;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.compraDeBonos', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.compraDeBonos;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.verificarSiAtiende', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.verificarSiAtiende;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.reservarTurno', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.reservarTurno;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.registrarLlegada', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.registrarLlegada;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.cargarSintomasYDiagnostico', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cargarSintomasYDiagnostico;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional', 'P') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones', 'FN') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getTop5Profesionales', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTop5Profesionales;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida;
GO

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras;


IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas;


IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada;

IF OBJECT_ID('GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones', 'FN') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones;

IF OBJECT_ID ('GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades', 'FN') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades;


IF OBJECT_ID ('GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida','FN') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida;


IF OBJECT_ID ('GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas', 'FN') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas;

IF OBJECT_ID ('GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada', 'FN') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada;

IF OBJECT_ID ('GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones', 'FN') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones;
GO

IF OBJECT_ID ('GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado', 'FN') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado;
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
  fechaInicio DATETIME NOT NULL,   -- ACA PARA FECHA DEL AÑO QUE TRABAJA Y HORARIO
  fechaFinal DATETIME NOT NULL,
  diaInicio INT,   -- LUNES 1 MARTES 2 MIERCOLES 3 JUEVES 4 VIERNES 5
  diaFin INT,
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
  id INTEGER PRIMARY KEY,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesionales(id),
  especialidad VARCHAR(30),
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  fecha DATETIME NOT NULL,
  baja INT default 0,
  tipoCancelacion INT, -- 0 Paciente, 1 Profesional
  motivo VARCHAR(255),
  )
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
idPaciente INT,
sintomas varchar(50),
diagnostico varchar(50)
)

insert into #ConsultasTemporal(id,fecha,idBono,fechaBono,precioBono,sintomas,diagnostico)
SELECT	 Turno_Numero, Turno_Fecha,Bono_Consulta_Numero,Bono_Consulta_Fecha_Impresion,Plan_Med_Precio_Bono_Consulta, 
Consulta_Sintomas,Consulta_Enfermedades 
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
INSERT INTO GESTIONAME_LAS_VACACIONES.Usuarios (usuario, pass) VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
GO

INSERT INTO GESTIONAME_LAS_VACACIONES.Planes(id,descripcion, precioCuota, precioBono)
	SELECT DISTINCT idPlan,descripcionPlan, precioCuota, precioBono
		FROM #PacienteTemporal

INSERT INTO GESTIONAME_LAS_VACACIONES.ComprasBonos(idPaciente,fecha,cantidad,monto)
SELECT t.idPaciente,t.fechaBono, COUNT(t.fechaBono) ,  COUNT(t.fechaBono)* t.precioBono
FROM #ConsultasTemporal t
where t.fechaBono is not null
GROUP BY t.idPaciente, fechaBono,precioBono 

SELECT * FROM GESTIONAME_LAS_VACACIONES.PACIENTES 

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (1,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (2,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (3,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (4,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (5,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (6,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (7,1)

INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos(id,idPaciente, idProfesional, fecha)
	select c.id, c.idPaciente, p.id , c.fecha
	FROM #ConsultasTemporal c , #TemporalProfesional t , GESTIONAME_LAS_VACACIONES.Profesionales p
	WHERE c.id  = t.idTurno and t.medicoDni  =p.documento
	group by c.id, c.idPaciente, p.id , c.fecha

INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultasMedicas(idBono, fecha,  idTurno,diagnostico,sintomas)
	SELECT t.idBono, t.fecha,t.id, t.diagnostico,t.sintomas from  #ConsultasTemporal t where t.fecha is not null and t.id is not null

INSERT INTO GESTIONAME_LAS_VACACIONES.Especialidades(descripcion, tipoEspecialidad)
	SELECT DISTINCT especialidadDescripcion, idEspecialidad
	FROM #TemporalProfesional

INSERT INTO GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional(idEspecialidad, idProfesional)
	SELECT DISTINCT esp.id, e.id FROM #TemporalProfesional p 
	join  GESTIONAME_LAS_VACACIONES.Profesionales e 
	on (p.medicoDni = e.documento and p.medicoNombre like e.nombre and p.medicoApellido like e.apellido)
	join GESTIONAME_LAS_VACACIONES.Especialidades esp
	on esp.descripcion = p.especialidadDescripcion


INSERT INTO GESTIONAME_LAS_VACACIONES.Bonos(id, idPaciente, idPlan)
	SELECT p.idBono, p.idPaciente, m.idPlan from #ConsultasTemporal p join GESTIONAME_LAS_VACACIONES.Modificaciones m 
	on m.idPaciente	 = p.idPaciente 
	where p.idBono is not null
	group by  p.idBono, p.idPaciente, m.idPlan 
	



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


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@descEspecialidad VARCHAR(30))
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER
	SELECT
		@retorno = id
	FROM 
		GESTIONAME_LAS_VACACIONES.Planes
	WHERE
		descripcion = @descEspecialidad
	RETURN @retorno;
END
GO

DROP FUNCTION GESTIONAME_LAS_VACACIONES.getDescEspecialidad
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
 RETURN (SELECT id FROM GESTIONAME_LAS_VACACIONES.Planes s
			WHERE @descripcion = s.descripcion) 
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.buscarAfiliados(@nombre varchar(20),@apellido varchar(20), @numAfiliado int )
returns table 
as 
return select * from GESTIONAME_LAS_VACACIONES.Pacientes where (nombre like @nombre or id = @numAfiliado or apellido like @apellido) AND baja = 0
go

SELECT * FROM GESTIONAME_LAS_VACACIONES.PACIENTES
SELECT * FROM GESTIONAME_LAS_VACACIONES.buscarAfiliados('aaron', '',  -1)
GO

drop function  GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional
go
drop FUNCTION GESTIONAME_LAS_VACACIONES.buscarProfesionales
go

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional()
returns table 
as 
return select p.id as idProf, e.id as idEsp, p.nombre, p.apellido from GESTIONAME_LAS_VACACIONES.Profesionales p JOIN GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional e
ON e.idProfesional = p.id 
go


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.buscarProfesionales(@nombre varchar(20),@apellido varchar(20), @especialidad varchar(20), @matricula int )
returns table 
as 
return select idProf, GESTIONAME_LAS_VACACIONES.getDescEspecialidad(idEsp) as especialidad, nombre, apellido from GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional() a
WHERE a.nombre like @nombre or a.idProf = @matricula or a.apellido like @apellido or a.idEsp = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad)
go


SELECT * FROM GESTIONAME_LAS_VACACIONES.Profesionales
GO

SELECT * FROM GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional




SELECT * FROM GESTIONAME_LAS_VACACIONES.PACIENTES
SELECT * FROM GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional()
GO

SELECT * FROM GESTIONAME_LAS_VACACIONES.Profesionales
SELECT * FROM GESTIONAME_LAS_VACACIONES.buscarProfesionales ('', '', '', 3)

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
 
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.crearRol(@nombre VARCHAR(30))
AS 
BEGIN
IF  NOT EXISTS   (SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Roles WHERE  descripcion LIKE @nombre)
INSERT INTO GESTIONAME_LAS_VACACIONES.Roles(descripcion) VALUES(@nombre)
ELSE
PRINT 'El Rol ya existe'
END
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerBaja(@nombreRol VARCHAR(30))
RETURNS TABLE
AS
RETURN (SELECT baja FROM GESTIONAME_LAS_VACACIONES.Roles WHERE descripcion = @nombreRol)
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarRol(@nombre VARCHAR(30))
AS 
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Roles r WHERE r.descripcion = @nombre)
BEGIN
PRINT 'El Rol no existe'
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
PRINT 'El Rol ya esta habilitado'
END
END

select * from GESTIONAME_LAS_VACACIONES.roles
update GESTIONAME_LAS_VACACIONES.roles set baja = 1 where descripcion = 'Administrativo'

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
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE apellido LIKE @apellido AND documento = @doc) 
INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(id,nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares,planes) VALUES (GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado(),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@planes)
ELSE
PRINT 'El paciente ya existe'
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
PRINT 'El paciente ya existe'
END 
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarPaciente(@numAfiliado INT)
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Turnos SET baja = 1 WHERE idPaciente = @numAfiliado
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes SET baja = 1, fechaBaja = CURRENT_TIMESTAMP WHERE id = @numAfiliado
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente(@id INT,@nombre nvarchar(50), @apellido nvarchar(50), 
@doc INT, @direc VARCHAR(100), @tel INT, @mail VARCHAR(255), @sexo char, @civil VARCHAR(10),
@cantFami INT)
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes
SET nombre = @nombre, apellido  = @apellido , documento = @doc, direccion = @direc, telefono = @tel, email = @mail, sexo = @sexo, 
estadoCivil = @civil, cantFamiliares = @cantFami WHERE id = @id
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cambioPlan(@idPaciente INT,@descripcionPlan VARCHAR(30), @motivo VARCHAR(50))
AS
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Modificaciones(idPaciente,idPlan,motivo)
VALUES(@idPaciente,GESTIONAME_LAS_VACACIONES.getIdPlanMedico(@descripcionPlan),@motivo)
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
PRINT 'No existe la funcionalidad o el rol que desea modificar'
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
(@matriculaProfesional  INT, @descEspecialidad VARCHAR(30), 
@fechaInicio  DATETIME, @fechaFin DATETIME, @diaInicio VARCHAR(10), 
  @diaFin VARCHAR (10))
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
PRINT 'No existe el afiliado'
ELSE 
INSERT INTO GESTIONAME_LAS_VACACIONES.ComprasBonos(idPaciente, cantidad, monto) 
VALUES (@numAfiliado, @cantidad, GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan(@numAfiliado, @cantidad))
WHILE (@aux < @cantidad)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Bonos(id, idPaciente, idPlan) 
VALUES ((SELECT id FROM GESTIONAME_LAS_VACACIONES.ComprasBonos WHERE idPaciente = @numAfiliado AND fecha = CURRENT_TIMESTAMP) , @numAfiliado, (SELECT p.servicio FROM Paciente p WHERE id = @numAfiliado))
SET @aux = @aux + 1
END
END
GO

--////////////////////////////////////--
--NUMERO 10--
--RESERVA DE TURNOS--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.verificarSiAtiende(@matricula INT, @especialidad VARCHAR(30), @fecha DATETIME) 
RETURNS	INT
AS
BEGIN
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agendas 
WHERE idProfesional = @matricula 
	  AND idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) 
	  AND (@fecha BETWEEN fechaInicio AND fechaFinal)
	  AND datepart (dw, @fecha) BETWEEN diaInicio AND diaFin)
RETURN 0

RETURN 1
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.reservarTurno(@matricula INT, @numAfiliado INT, @especialidad VARCHAR(30), @fecha DATETIME)
AS
BEGIN
IF (NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idProfesional = @matricula AND fecha = @fecha AND (GESTIONAME_LAS_VACACIONES.verificarSiAtiende (@matricula, @especialidad, @fecha)) = 1))
	INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos (idPaciente, idProfesional, especialidad, fecha) 
	VALUES (@numAfiliado, @matricula, @especialidad, @fecha) 
END
GO


--////////////////////////////////////--
--NUMERO 11--
--REGISTRO DE LLEGADA--

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.registrarLlegada(@numAfiliado INT, @matricula INT, @especialidad VARCHAR(30))
AS
BEGIN

DECLARE @bonoID INT
DECLARE @turnoID INT

IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idPaciente = @numAfiliado	
						AND idProfesional = @matricula
						AND  CAST(fecha AS DATE) = CAST(CURRENT_TIMESTAMP AS DATE))
PRINT 'No existe el turno'
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
	
Print 'Como va a cancelar un turno que nunca agendo usted es hijo de primos'
ELSE 
UPDATE GESTIONAME_LAS_VACACIONES.Turnos 
SET baja = 1, tipoCancelacion = 0, motivo = @motivo
WHERE idPaciente = @numAfiliado AND (idProfesional = @matricula or especialidad LIKE @especialidad) AND fecha = @fecha
END
GO


--////////////////////////////////////--
--PROFESIONAL--
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional(@matricula INT, @especialidad VARCHAR(30), @diaACancelar DATETIME, @motivo VARCHAR(255))
AS
BEGIN 
DECLARE @inicioAux DATETIME
DECLARE @finalAux DATETIME
DECLARE @diaInicialAux INT
DECLARE @diaFinalAux INT


IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @matricula 
				AND @diaACancelar BETWEEN fechaInicio AND fechaFinal
				AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad )
PRINT 'El dia no se encuentra agendado'
ELSE

SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agendas 
WHERE idProfesional = @matricula 
	  AND @diaACancelar BETWEEN fechaInicio 
	  AND fechaFinal 
	  AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Agendas 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula AND @diaACancelar BETWEEN fechaInicio AND fechaFinal AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Turnos
SET baja = 1, tipoCancelacion = 1, motivo = @motivo
WHERE idProfesional = @matricula AND especialidad = @especialidad AND fecha = @diaACancelar

IF (@diaACancelar != @inicioAux AND @diaACancelar != @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1, @diaACancelar), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @diaACancelar), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaACancelar = @inicioAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(day,+1, @inicioAux), @finalAux, @diaInicialAux, @diaFinalAux)

IF (@diaACancelar = @finalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(day,-1, @finalAux), @diaInicialAux, @diaFinalAux)

END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional(@matricula INT, @especialidad VARCHAR(30), @diaInicialACancelar DATETIME, @diaFinalACancelar DATETIME, @motivo VARCHAR(255))
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
PRINT 'El rango de fechas no se encuentra agendado'
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
CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones()
RETURNS TABLE 
AS
RETURN (SELECT GESTIONAME_LAS_VACACIONES.getIdEspecialidad(t.especialidad) AS especialidades, a.idEspecialidad AS especialidades2 FROM GESTIONAME_LAS_VACACIONES.Turnos t JOIN GESTIONAME_LAS_VACACIONES.Agendas a ON t.baja = 1 AND a.baja = 1)
GO

CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones()
RETURNS TABLE 
AS
RETURN (SELECT especialidades FROM GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones()
UNION ALL
SELECT especialidades2 FROM GESTIONAME_LAS_VACACIONES.getTablaDeCancelaciones())
--ORDER BY especialidades, especialidades2)
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones()
RETURNS TABLE 
AS
RETURN (SELECT TOP 5 especialidades 
FROM GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones());
GO

--TOP 5 PROFESIONALES MAS CONSULTADOS POR PLAN ESPECIFICANDO ESPECIALIDAD--



CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas(@planes INT)
RETURNS TABLE AS
RETURN (SELECT p.id AS idProf, COUNT(p.id) AS cantConsultas
FROM GESTIONAME_LAS_VACACIONES.ConsultasMedicas c JOIN GESTIONAME_LAS_VACACIONES.Turnos t 
ON c.idTurno = t.id
JOIN GESTIONAME_LAS_VACACIONES.Profesionales p
ON t.idProfesional = p.id
JOIN GESTIONAME_LAS_VACACIONES.Pacientes pac
ON t.idPaciente = pac.id AND pac.planes = @planes
GROUP BY p.id)
GO



CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getTop5Profesionales(@planes INT)
RETURNS TABLE AS
RETURN SELECT TOP 5 cantConsultas, idProf
FROM GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas(@planes)
ORDER BY cantConsultas
GO



CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida(@planes INT)
RETURNS TABLE AS
RETURN (SELECT a.idProf AS profesional, COUNT(t.especialidad) AS vecesEspecialidad
FROM  GESTIONAME_LAS_VACACIONES.getTop5Profesionales(@planes) a
JOIN GESTIONAME_LAS_VACACIONES.Turnos t
ON a.idProf = t.idProfesional
GROUP BY a.idProf, t.especialidad)
GO

-- CHEQUEAR PORQUE NO SE SI ME ESTA TIRANDO VALORES BIEN--
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras()
RETURNS TABLE AS
RETURN (SELECT TOP 5 unPaciente.id , unPaciente.nombre, unPaciente.apellido , (SELECT sum(id) FROM GESTIONAME_LAS_VACACIONES.Pacientes familiar WHERE familiar.id/100  = unPaciente.id/100 AND familiar.id <> unPaciente.id) AS 'Cantidad de familiares'
FROM GESTIONAME_LAS_VACACIONES.Pacientes  unPaciente 
JOIN GESTIONAME_LAS_VACACIONES.ComprasBonos compra ON  unPaciente.id/100 = compra.idPaciente/100
GROUP BY unPaciente.id, unPaciente.nombre,unPaciente.apellido  
ORDER BY COUNT(compra.idPaciente))
GO

-- IDEM AL DE ARRIBA, SOY UN CAGON LO SE-- 
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas()
RETURNS TABLE AS 
RETURN (SELECT TOP 5 especialidad.id FROM GESTIONAME_LAS_VACACIONES.Especialidades especialidad
JOIN (GESTIONAME_LAS_VACACIONES.ConsultasMedicas consulta
JOIN GESTIONAME_LAS_VACACIONES.Turnos turno
ON turno.id = consulta.idTurno)
ON turno.especialidad = especialidad.id
GROUP BY especialidad.id
ORDER BY COUNT(consulta.id))
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada(@id INTEGER)
RETURNS TABLE AS
RETURN (SELECT tipoEspecialidad FROM GESTIONAME_LAS_VACACIONES.Especialidades e JOIN 
GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional x ON e.id = x.idEspecialidad JOIN 
GESTIONAME_LAS_VACACIONES.Profesionales p ON x.idProfesional = p.id WHERE p.id = @id 
AND tipoEspecialidad NOT IN (SELECT idEspecialidad FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @id)) 
GO

