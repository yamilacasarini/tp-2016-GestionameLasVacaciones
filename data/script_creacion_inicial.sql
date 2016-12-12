-- Saque los GO, ahora aprentando el menos de la linea siguiente, no ves mas drops :D
IF NOT EXISTS ( SELECT  *
				FROM    sys.schemas
				WHERE   name = N'GESTIONAME_LAS_VACACIONES' ) 
	EXEC('CREATE SCHEMA [GESTIONAME_LAS_VACACIONES]');

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.TablaTemporalListado', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.TablaTemporalListado;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.RolesxUsuario', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.RolesxUsuario;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Funcionalidades', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Funcionalidades;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Roles', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Roles;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.ConsultasMedicas', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.ConsultasMedicas;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Bonos', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Bonos;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.ComprasBonos', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.ComprasBonos;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Turnos', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Turnos;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Modificaciones', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Modificaciones;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Planes', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Planes;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Pacientes', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Pacientes;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Agendas', N'U') IS NOT NULL 
DROP TABLE  GESTIONAME_LAS_VACACIONES.Agendas;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Profesionales', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Profesionales;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Especialidades', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Especialidades;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.Usuarios', N'U') IS NOT NULL 
DROP TABLE GESTIONAME_LAS_VACACIONES.Usuarios;

IF OBJECT_ID(N'GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha', N'U') IS NOT NULL 
DROP FUNCTION GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha;

IF OBJECT_ID(N'tempdb..#PacienteTemporal', N'U') IS NOT NULL
drop table #PacienteTemporal;

IF OBJECT_ID(N'tempdb..#TemporalProfesional', N'U') IS NOT NULL
drop table #TemporalProfesional;

IF OBJECT_ID(N'tempdb..#ConsultasTemporal', N'U') IS NOT NULL
drop table #ConsultasTemporal;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getIdEspecialidad') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdEspecialidad;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.funcObtenerIdDeDni') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.funcObtenerIdDeDni;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getDescEspecialidad') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getDescEspecialidad;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getIdFuncionalidad') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdFuncionalidad;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getIdRol') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getPlanMedico') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getPlanMedico;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getIdPlanMedico') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdPlanMedico;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.buscarAfiliados') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.buscarAfiliados;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getDesDelPlan') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getDesDelPlan

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.joinearEspecialidadYProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.buscarProfesionales') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.buscarProfesionales;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getHorarioDeAtencionDelProfesional') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getHorarioDeAtencionDelProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getDiasDeAtencionDelProfesional') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getDiasDeAtencionDelProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getTurnosAgendadosProfesional') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTurnosAgendadosProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.LoguearUsuario') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.LoguearUsuario;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.crearRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.crearRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerBaja') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerBaja;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.existeRol') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.existeRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.borrarRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.borrarRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.habilitarRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.habilitarRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.modificarRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.altaPaciente') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.altaPaciente;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.altaFamiliar') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.altaFamiliar;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.borrarPaciente') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.borrarPaciente;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.modificarPaciente') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cambioPlan') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cambioPlan;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getDescripcionFuncionalidad') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getDescripcionFuncionalidad;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerFuncionesNoCargadasAUnRol') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerFuncionesNoCargadasAUnRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.modificarFuncionalidadAUnRol;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.altaAgendaProfesional') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.altaAgendaProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.compraDeBonos') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.compraDeBonos;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.reservarTurno') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.reservarTurno;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerIdProfesional') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerIdProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getIdAgenda') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getIdAgenda;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerTurnosDelprofesional') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosDelprofesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.registrarLlegada') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.registrarLlegada;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cargarSintomasYDiagnostico') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cargarSintomasYDiagnostico;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerIdPaciente') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerIdPaciente;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelAfiliadoSegunId') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelAfiliadoSegunId;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerTurnosDelAfiliado') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosDelAfiliado;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelProfesionalSegunId') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelProfesionalSegunId;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.obtenerRolDeUsuario') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.obtenerRolDeUsuario;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getTop5Profesionales') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getTop5Profesionales;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cargarTablaTemporalHorasProfesionale') IS NOT NULL
DROP PROCEDURE GESTIONAME_LAS_VACACIONES.cargarTablaTemporalHorasProfesionale;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.MergearAgendas') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.MergearAgendas;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.topProfesionalesConMenosHoras') IS NOT NULL
DROP function GESTIONAME_LAS_VACACIONES.topProfesionalesConMenosHoras;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas;

IF OBJECT_ID (N' GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.seModificoPlan') IS NOT NULL
DROP  TRIGGER GESTIONAME_LAS_VACACIONES.seModificoPlan;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.cargarTablaTemporalHorasProfesionales') IS NOT NULL
DROP  PROCEDURE GESTIONAME_LAS_VACACIONES.cargarTablaTemporalHorasProfesionales;

IF OBJECT_ID (N'GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada') IS NOT NULL
DROP FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada;
GO

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
pass VARCHAR(255) DEFAULT 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',
  baja INT default 0,
  fechaBaja DATETIME,
  intentos INT DEFAULT 0,
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
create TABLE GESTIONAME_LAS_VACACIONES.Pacientes (
  id INT PRIMARY KEY IDENTITY(100,100),
  usuario VARCHAR (255) REFERENCES GESTIONAME_LAS_VACACIONES.Usuarios(usuario),
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
  planes INTEGER,
  baja INT DEFAULT 0,
  fechaBaja DATE,
  CHECK (sexo IN('f','m'))
   )


CREATE TABLE GESTIONAME_LAS_VACACIONES.Profesionales (
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  usuario VARCHAR (255) REFERENCES GESTIONAME_LAS_VACACIONES.Usuarios(usuario),
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
  fechaInicio DATETIME NOT NULL DEFAULT '2015-01-03 09:00:00.000',   -- ACA PARA FECHA DEL AÑO QUE TRABAJA Y HORARIO
  fechaFinal DATETIME NOT NULL DEFAULT '2015-12-12 15:00:00.000',
  diaInicio INT DEFAULT 1,   -- LUNES 1 MARTES 2 MIERCOLES 3 JUEVES 4 VIERNES 5
  diaFin INT DEFAULT 5,
  baja INTEGER DEFAULT 0,
  motivo VARCHAR(255),
  )
CREATE TABLE GESTIONAME_LAS_VACACIONES.ComprasBonos(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  cantidad INT NOT NULL DEFAULT 1,
  monto INT NOT NULL,
  fecha DATETIME NOT NULL
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Modificaciones(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  idPlan INT,
  motivo VARCHAR(255),
  fecha DATETIME NOT NULL
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.Turnos(
  id INTEGER PRIMARY KEY IDENTITY (1,1),
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesionales(id),
  especialidad VARCHAR(255),
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  idAgenda INT REFERENCES GESTIONAME_LAS_VACACIONES.Agendas(id),
  fecha DATETIME,
  baja INT default 0,
  tipoCancelacion INT, -- 0 Paciente, 1 Profesional
  motivo VARCHAR(255),
  esConsulta INT DEFAULT 0, -- Usado para saber si se efectivizo el turno en una consulta medica (0 NO, 1 SI) 
  )

  CREATE INDEX ix1_turnos ON GESTIONAME_LAS_VACACIONES.Turnos (idPaciente)

  CREATE TABLE GESTIONAME_LAS_VACACIONES.Bonos(
  id INTEGER PRIMARY KEY IDENTITY(1,1),
  idPaciente INT REFERENCES GESTIONAME_LAS_VACACIONES.Pacientes(id),
  idPlan INT REFERENCES GESTIONAME_LAS_VACACIONES.Planes(id),
  usado INT DEFAULT 0, --0 Sin usar, 1 usado
  idCompraBono INT REFERENCES GESTIONAME_LAS_VACACIONES.ComprasBonos(id),
  idTurno INT REFERENCES GESTIONAME_LAS_VACACIONES.Turnos(id)
   )
 
CREATE TABLE GESTIONAME_LAS_VACACIONES.ConsultasMedicas(
  id INTEGER IDENTITY(1,1) PRIMARY KEY,
  idBono INT REFERENCES GESTIONAME_LAS_VACACIONES.Bonos(id),
  fecha DATETIME NOT NULL,
  diagnostico VARCHAR(255),
  sintomas VARCHAR(255),
  idTurno INT REFERENCES GESTIONAME_LAS_VACACIONES.Turnos(id) ,
   )
CREATE TABLE GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional(
  id INTEGER  IDENTITY(1,1) PRIMARY KEY,
  idEspecialidad INT REFERENCES GESTIONAME_LAS_VACACIONES.Especialidades(id) ,
  idProfesional INT REFERENCES GESTIONAME_LAS_VACACIONES.Profesionales(id) ,
  )
  GO
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
dni INT,
medicoDNI int,
especialidad varchar(255)
)
GO

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
INSERT INTO GESTIONAME_LAS_VACACIONES.Funcionalidades(descripcion) VALUES ('RESULTADO DE CONSULTA')

insert into #ConsultasTemporal(id,fecha,idBono,fechaBono,precioBono,sintomas,diagnostico,dni, medicoDNI, especialidad)
SELECT	Turno_Numero, Turno_Fecha,Bono_Consulta_Numero,Bono_Consulta_Fecha_Impresion,Plan_Med_Precio_Bono_Consulta, 
Consulta_Sintomas,Consulta_Enfermedades, Paciente_Dni, Medico_Dni, Especialidad_Descripcion
FROM gd_esquema.Maestra

INSERT INTO #PacienteTemporal (nombre,apellido,dni,direccion,telefono,email,fechaNacimiento,idPlan,descripcionPlan,precioBono,idTurno,fechaTurno,fechaBono,idBono)
SELECT Paciente_Nombre,Paciente_Apellido, Paciente_Dni, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,Paciente_Fecha_Nac,
				Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Consulta, Turno_Numero,Turno_Fecha ,Compra_Bono_Fecha,Bono_Consulta_Numero
					FROM GD2C2016.gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(nombre,apellido,direccion,documento,email,fechaNacimiento,telefono,planes)
SELECT  nombre,apellido,direccion,dni,email,fechaNacimiento,telefono ,idPlan
from #PacienteTemporal group by nombre,apellido,direccion,dni,email,fechaNacimiento,telefono,idPlan

INSERT INTO GESTIONAME_LAS_VACACIONES.Usuarios(usuario) 
SELECT 'Paciente_'+convert(VARCHAR(10),id) from GESTIONAME_LAS_VACACIONES.Pacientes

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxUsuario(idRol,idUsuario) 
SELECT 2,usuario from GESTIONAME_LAS_VACACIONES.Usuarios where usuario like 'Paciente_%'

INSERT INTO #TemporalProfesional (consultaEnfermedad,consultaSintoma,especialidadDescripcion,especialidadDescripcion2,fechaTurno,
						idEspecialidad,idEspecialidad2,idTurno,medicoApellido,medicoDni,medicoMail,medicoNacimiento,medicoNombre,medicoTelefono,medicoDir)
SELECT Consulta_Enfermedades,Consulta_Sintomas,Especialidad_Descripcion,Tipo_Especialidad_Descripcion,Turno_Fecha,
				Especialidad_Codigo,Tipo_Especialidad_Codigo,Turno_Numero,Medico_Apellido,Medico_Dni,Medico_Mail,Medico_Fecha_Nac,Medico_Nombre,Medico_Telefono,Medico_Direccion
					FROM GD2C2016.gd_esquema.Maestra

INSERT INTO GESTIONAME_LAS_VACACIONES.Profesionales(apellido,direccion,documento,email,fechaNacimiento,nombre,telefono)
SELECT medicoApellido,medicoDir,medicoDni,medicoMail,medicoNacimiento,medicoNombre,medicoTelefono 
FROM #TemporalProfesional where medicoApellido is not null 
group by medicoApellido,medicoDir,medicoDni,medicoMail,medicoNacimiento,medicoNombre,medicoTelefono 

INSERT INTO GESTIONAME_LAS_VACACIONES.Usuarios(usuario)
select 'Profesional_'+Convert(varchar(10),id) from GESTIONAME_LAS_VACACIONES.Profesionales 

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxUsuario(idRol,idUsuario)
select 3,usuario from GESTIONAME_LAS_VACACIONES.Usuarios where usuario like 'Profesional_%'

UPDATE GESTIONAME_LAS_VACACIONES.Pacientes SET usuario = 'Paciente_'+convert(varchar(10),id)
UPDATE GESTIONAME_LAS_VACACIONES.Profesionales SET usuario = 'Profesional_'+convert(varchar(10),id)

INSERT INTO GESTIONAME_LAS_VACACIONES.Usuarios (usuario, pass) VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxUsuario(idRol,idUsuario) values(1,'admin') 
	
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

--FUNCIONALIDADES PARA ADMIN--

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (1,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (2,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (3,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (4,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (5,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (6,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (7,1)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (8,1)

--FUNCIONALIDADES PARA AFILIADO--

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (3,2)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (4,2)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (6,2)

--FUNCIONALIDADES PARA PROFESIONAL--

INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (6,3)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (8,3)
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad(idFuncionalidad, idRol) VALUES (9,3)

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
	
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad) 
SELECT DISTINCT p.id, e.idEspecialidad FROM GESTIONAME_LAS_VACACIONES.Profesionales p 
JOIN GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional e
ON p.id = e.idProfesional
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

SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Turnos ON

INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos(id, idPaciente, idProfesional, fecha, especialidad, idAgenda)
SELECT DISTINCT c.id, pa.id, pr.id, c.fecha, c.especialidad, a.id FROM #ConsultasTemporal c
JOIN GESTIONAME_LAS_VACACIONES.Pacientes pa
ON c.dni = pa.documento
JOIN GESTIONAME_LAS_VACACIONES.Profesionales pr
ON pr.documento = c.medicoDNI
JOIN GESTIONAME_LAS_VACACIONES.Agendas a
ON a.idProfesional = pr.id 
	AND a.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(c.especialidad)
WHERE c.id is not null
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Turnos OFF; 
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Bonos ON; 
INSERT INTO GESTIONAME_LAS_VACACIONES.Bonos(id, idPaciente, idPlan, idCompraBono, idTurno)
	SELECT DISTINCT c.idBono, p.id, m.id, b.id, t.id from #ConsultasTemporal c
	join (GESTIONAME_LAS_VACACIONES.Planes m 
	join GESTIONAME_LAS_VACACIONES.Pacientes p
	on p.planes = m.id)
	on p.documento	 = c.dni 
	JOIN GESTIONAME_LAS_VACACIONES.ComprasBonos b
	ON b.idPaciente = p.id AND b.fecha = c.fechaBono
	JOIN GESTIONAME_LAS_VACACIONES.Turnos t
	ON t.id = c.id
	where c.idBono is not null
	group by c.idBono, p.id, m.id, b.id, t.id
GO
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Bonos OFF; 
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Turnos ON; 
INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultasMedicas(idBono, idTurno, fecha)
SELECT b.id, c.id, c.fecha FROM #ConsultasTemporal c
JOIN GESTIONAME_LAS_VACACIONES.Bonos b
ON c.idBono = b.id
WHERE c.fecha IS NOT NULL
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
return select p.id, GESTIONAME_LAS_VACACIONES.getDescEspecialidad(e.idEspecialidad) as especialidad, nombre, apellido 
from GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional e
JOIN GESTIONAME_LAS_VACACIONES.Profesionales p
ON p.id = e.idProfesional
WHERE p.nombre like @nombre or p.id = @matricula or p.apellido like @apellido or e.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad)
go

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getHorarioDeAtencionDelProfesional(@matricula int, @especialidad as varchar(100), @hora as datetime)
RETURNS TABLE
AS
RETURN select a.fechaInicio, a.fechaFinal FROM GESTIONAME_LAS_VACACIONES.Agendas a
WHERE a.idProfesional = @matricula and a.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) and baja = 0
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getDiasDeAtencionDelProfesional(@matricula int, @especialidad as varchar(100), @hora as datetime, @fechaInicio as datetime, @fechaFin as datetime)
RETURNS TABLE
AS
RETURN select a.diaInicio, a.diaFin FROM GESTIONAME_LAS_VACACIONES.Agendas a
WHERE a.idProfesional = @matricula and a.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) 
AND CAST(@fechaInicio AS DATE) = CAST(fechaInicio AS DATE)
AND CAST(@fechaFin AS DATE) = CAST(fechaFinal AS DATE)
GO	
CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getTurnosAgendadosProfesional(@matricula int, @especialidad as varchar(100))
RETURNS TABLE
AS
RETURN select fecha from GESTIONAME_LAS_VACACIONES.Turnos t
WHERE t.idProfesional = @matricula and t.especialidad like @especialidad and baja = 0 
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
	
	if(exists (select * From GESTIONAME_LAS_VACACIONES.Pacientes where usuario like @username and baja = 1))
	RAISERROR('El usuario fue dado de baja',16,217)
			
	SELECT @usuario = usuario FROM GESTIONAME_LAS_VACACIONES.Usuarios WHERE usuario LIKE @username AND pass LIKE @pass
	IF (@usuario IS NULL)
	BEGIN
		UPDATE GESTIONAME_LAS_VACACIONES.Usuarios
		SET intentos = @intentos +1 
		WHERE usuario = @username 
		RAISERROR('Contraseña y/o usuario incorrectas',16,217) WITH SETERROR
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
@cantFami INT, @planes INT, @tipoDocumento VARCHAR(30))
AS
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Pacientes ON
BEGIN 
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE documento = @doc AND tipoDocumento like @tipoDocumento) 
BEGIN
DECLARE @IdUltimo INT = GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado()
INSERT INTO GESTIONAME_LAS_VACACIONES.Usuarios(usuario) VALUES  ('Paciente_'+CONVERT(VARCHAR(10),@IdUltimo))
INSERT INTO GESTIONAME_LAS_VACACIONES.RolesxUsuario(idRol,idUsuario) VALUES(2,'Paciente_'+CONVERT(VARCHAR(10),@IdUltimo))
INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(id,nombre, apellido, documento, direccion, telefono, email, 
fechaNacimiento, sexo, estadoCivil, cantFamiliares,planes,usuario, tipoDocumento) VALUES (GESTIONAME_LAS_VACACIONES.idSiguienteAfiliado(),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@planes,'Paciente_'+CONVERT(VARCHAR(10),@IdUltimo), @tipoDocumento)

END
ELSE
RAISERROR( 'El paciente ya existe',16,217) WITH SETERROR
END 
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.altaFamiliar(@idFamiliar INT,@nombre nvarchar(50), @apellido nvarchar(50), 
@doc INT, @direc VARCHAR(100), @tel INT, @mail VARCHAR(100), @nacimiento DATETIME, @sexo char, @civil VARCHAR(10),
@cantFami INT,@planes INT, @tipoDocumento as VARCHAR(30))
AS
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Pacientes ON
	BEGIN 
	if(GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar(@idFamiliar)%100 >99)
		RAISERROR('Numero excedido de familiares',16,217);
	IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE  documento = @doc)
		begin 
		IF NOT EXISTS (SELECT * from GESTIONAME_LAS_VACACIONES.Pacientes where id = GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar(@idFamiliar))
			begin
			INSERT INTO GESTIONAME_LAS_VACACIONES.Pacientes(id,nombre, apellido, documento, direccion, telefono, email, 
			fechaNacimiento, sexo, estadoCivil, cantFamiliares,planes,usuario) VALUES (GESTIONAME_LAS_VACACIONES.obtenerNuevoIDFamiliar(@idFamiliar),@nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@planes,'Paciente_'+convert(varchar(10),@idFamiliar))
			end
		else
			begin
			EXEC GESTIONAME_LAS_VACACIONES.altaPaciente @nombre, @apellido, @doc, @direc, @tel, @mail, @nacimiento, @sexo, @civil, @cantFami,@planes, @tipoDocumento
			end
		END
	ELSE
		RAISERROR( 'El paciente ya existe',16,217)
END 
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.borrarPaciente(@numAfiliado INT, @hora as datetime)
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Turnos SET baja = 1 WHERE idPaciente = @numAfiliado
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes SET baja = 1, fechaBaja = @hora WHERE id = @numAfiliado
END
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente(@id INT,@direc VARCHAR(100),
 @tel INT, @mail VARCHAR(255), @sexo char, @civil VARCHAR(10),@cantFami INT)
AS
BEGIN
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes
SET direccion = @direc, telefono = @tel, email = @mail, sexo = @sexo, 
estadoCivil = @civil, cantFamiliares = @cantFami WHERE id = @id
END
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cambioPlan(@idPaciente INT,@plan INT, @motivo VARCHAR(50),@fecha as datetime)
AS
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Modificaciones(idPaciente,idPlan,motivo,fecha)
VALUES(@idPaciente,@plan,@motivo,@fecha)
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
RETURNS NVARCHAR(255)
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
 AND idRol = GESTIONAME_LAS_VACACIONES.getIdRol(@nombreRol)
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

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.compraDeBonos(@numAfiliado INT, @cantidad INT, @hora as datetime)
AS
BEGIN
DECLARE @aux INT = 0
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE id = @numAfiliado)
RAISERROR ('No existe el afiliado',16,217)
ELSE 
INSERT INTO GESTIONAME_LAS_VACACIONES.ComprasBonos(idPaciente, cantidad, monto,fecha) 
VALUES (@numAfiliado, @cantidad, GESTIONAME_LAS_VACACIONES.calcularMontoSegunPlan(@numAfiliado, @cantidad),@hora)
WHILE (@aux < @cantidad)
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Bonos(idCompraBono, idPaciente, idPlan) 
VALUES ((SELECT top 1 id FROM GESTIONAME_LAS_VACACIONES.ComprasBonos WHERE idPaciente = @numAfiliado AND fecha = @hora order by id desc) , @numAfiliado, (SELECT p.planes FROM GESTIONAME_LAS_VACACIONES.Pacientes p WHERE id = @numAfiliado))
SET @aux = @aux + 1
END
END
GO

--////////////////////////////////////--
--NUMERO 10--
--RESERVA DE TURNOS--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getIdAgenda(@especialidad varchar(255), @matricula int)
RETURNS INT
AS BEGIN
RETURN (SELECT a.id FROM GESTIONAME_LAS_VACACIONES.Agendas a 
WHERE a.idProfesional = @matricula 
AND a.idEspecialidad = GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad))
END
GO
SET IDENTITY_INSERT GESTIONAME_LAS_VACACIONES.Turnos ON
GO
CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.reservarTurno(@matricula INT, @numAfiliado INT, @especialidad VARCHAR(255), @fecha DATETIME)
AS
BEGIN
IF (NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos WHERE idProfesional = @matricula AND fecha = @fecha AND idPaciente = @numAfiliado))
	INSERT INTO GESTIONAME_LAS_VACACIONES.Turnos (idPaciente, idProfesional, especialidad, idAgenda, fecha) 
	VALUES (@numAfiliado, @matricula, @especialidad , GESTIONAME_LAS_VACACIONES.getIdAgenda(@especialidad, @matricula), @fecha) 
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

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.obtenerTurnosDelprofesional(@nombreProf  varchar(255),@apellidoProf  VARCHAR(255), @especialidadProf VARCHAR(255), @idTurno INT)
AS 
BEGIN
SELECT id , fecha, idPaciente, especialidad, idProfesional 
FROM GESTIONAME_LAS_VACACIONES.Turnos t 
where (t.idProfesional  in 
(select id from GESTIONAME_LAS_VACACIONES.obtenerIdProfesional( @nombreProf ,  @apellidoProf))
and t.especialidad like @especialidadProf) OR t.id = @idTurno
END
GO

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.registrarLlegada(@turnoID INT, @numAfiliado INT, @hora as datetime)
AS
BEGIN
DECLARE @bonoID INT;
SELECT @bonoID = min(b.id) 
FROM GESTIONAME_LAS_VACACIONES.Bonos b  where b.usado = 0 AND b.idPaciente/100 = @numAfiliado/100
IF(@bonoID is null )
RAISERROR('El paciente no  posee bonos actualmente',16,217)
ELSE 
BEGIN 
INSERT INTO GESTIONAME_LAS_VACACIONES.ConsultasMedicas(idBono, fecha, idTurno) 
VALUES (@bonoID, @hora, @turnoID)

UPDATE GESTIONAME_LAS_VACACIONES.Bonos
SET usado = 1
WHERE id = @bonoID

UPDATE GESTIONAME_LAS_VACACIONES.Turnos
set esConsulta = 1
WHERE id = @turnoID

END
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

CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado(@numAfiliado INT, @matricula INT, @especialidad VARCHAR(30), @fecha DATETIME, @motivo VARCHAR(255), @hora as datetime)
AS
BEGIN

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

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelAfiliadoSegunId(@idAfiliado INT, @hora as DATETIME)
RETURNS TABLE
AS
RETURN (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos turnos 
WHERE turnos.idPaciente = @idAfiliado AND turnos.tipoCancelacion IS NULL AND CAST(turnos.fecha AS DATE) > CAST(@hora AS DATE) )
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosDelAfiliado(@nombreAfiliado NVARCHAR(50), @apellido NVARCHAR(50), @dni INT)
RETURNS TABLE
AS
RETURN (SELECT * FROM GESTIONAME_LAS_VACACIONES.Turnos turnos 
WHERE turnos.idPaciente = (GESTIONAME_LAS_VACACIONES.obtenerIdPaciente(@nombreAfiliado, @apellido, @dni)))
GO




--////////////////////////////////////--
--PROFESIONAL--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelProfesionalSegunId(@matricula INT, @fechaSistem DATETIME)
RETURNS TABLE
AS
RETURN (SELECT a.id, idProfesional, e.descripcion, fechaInicio, fechaFinal, diaInicio, diaFin 
FROM GESTIONAME_LAS_VACACIONES.Agendas a JOIN GESTIONAME_LAS_VACACIONES.Especialidades e ON a.idEspecialidad = e.id
 WHERE idProfesional = @matricula AND baja=0 AND CONVERT(date,fechaFinal) >= CONVERT(date,@fechaSistem))
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.obtenerRolDeUsuario(@idUsuario VARCHAR(255))
RETURNS TABLE
AS
RETURN (SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Roles r JOIN
GESTIONAME_LAS_VACACIONES.RolesxUsuario rxu ON r.id = rxu.idRol 
WHERE rxu.idUsuario like @idUsuario)

GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@fecha DATETIME, @delta INT)
RETURNS DATETIME
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
DECLARE @horaAux DATETIME
IF NOT EXISTS (SELECT * FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @matricula 
				AND CAST(@diaACancelar AS DATE) BETWEEN CAST(fechaInicio AS DATE) AND CAST(fechaFinal AS DATE)
				AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad )
BEGIN
RAISERROR('El dia no se encuentra agendado',16,217)
END
ELSE
BEGIN
SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agendas 
WHERE idProfesional = @matricula 
	AND CAST(@diaACancelar AS DATE) BETWEEN CAST(fechaInicio AS DATE) AND CAST(fechaFinal AS DATE)
	  AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad
	  AND baja = 0
SET @horaAux = CAST(@inicioAux AS TIME)
UPDATE GESTIONAME_LAS_VACACIONES.Agendas 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula AND CAST(@diaACancelar AS DATE) BETWEEN CAST(fechaInicio AS DATE) AND CAST(fechaFinal AS DATE) AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad

UPDATE GESTIONAME_LAS_VACACIONES.Turnos
SET baja = 1, tipoCancelacion = 1, motivo = @motivo
WHERE idProfesional = @matricula AND especialidad = @especialidad AND fecha = @diaACancelar


IF (CAST(@diaACancelar AS DATE) != CAST(@inicioAux AS DATE) AND CAST(@diaACancelar AS DATE)!= CAST(@finalAux AS DATE))
BEGIN
SET @diaACancelar = DATEADD(hh,DATEPART(HH,@horaAux),DATEADD(MI,DATEPART(MI,@horaAux),@diaACancelar))
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@diaACancelar, -1), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad),  GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@diaACancelar, +1), @finalAux, @diaInicialAux, @diaFinalAux)
END
IF (CAST(@diaACancelar AS DATE)= CAST(@inicioAux AS DATE))
BEGIN
SET @diaACancelar = DATEADD(hh,DATEPART(HH,@horaAux),DATEADD(MI,DATEPART(MI,@horaAux),@diaACancelar))
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad),GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@inicioAux, +1), @finalAux, @diaInicialAux, @diaFinalAux)
END
IF (CAST(@diaACancelar AS DATE) = CAST(@finalAux AS DATE))
BEGIN
SET @horaAux = @finalAux
SET @diaACancelar = DATEADD(hh,DATEPART(HH,@horaAux),DATEADD(MI,DATEPART(MI,@horaAux),@diaACancelar))
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, GESTIONAME_LAS_VACACIONES.modificarDiaDeUnaFecha(@finalAux, -1), @diaInicialAux, @diaFinalAux)
END
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
				AND @diaFinalACancelar BETWEEN fechaInicio AND fechaFinal)
RAISERROR( 'El rango de fechas no se encuentra agendado',16,217)
ELSE

SELECT @inicioAux= fechaInicio,  @finalAux = fechaFinal, @diaInicialAux = diaInicio, @diaFinalAux = diaFin
FROM GESTIONAME_LAS_VACACIONES.Agendas 
WHERE idProfesional = @matricula 
	  AND CAST(@diaInicialACancelar AS DATE) BETWEEN fechaInicio AND fechaFinal
	  AND CAST(@diaFinalACancelar AS DATE) BETWEEN fechaInicio AND fechaFinal
	  AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad
	  AND baja = 0

UPDATE GESTIONAME_LAS_VACACIONES.Agendas 
SET baja = 1, motivo = @motivo
WHERE idProfesional = @matricula 
	AND CAST(@diaInicialACancelar AS DATE) BETWEEN fechaInicio AND fechaFinal
	AND CAST(@diaFinalACancelar AS DATE) BETWEEN fechaInicio AND fechaFinal 
	AND GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad) = idEspecialidad
	AND baja = 0

UPDATE GESTIONAME_LAS_VACACIONES.Turnos
SET baja = 1, tipoCancelacion = 1, motivo = @motivo
WHERE idProfesional = @matricula 
	AND especialidad = @especialidad 
	AND fecha BETWEEN  @diaInicialACancelar AND @diaFinalACancelar


IF (CAST(@diaInicialACancelar AS DATE) = CAST(@inicioAux AS DATE))
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(mi, DATEPART(mi, @inicioAux), DATEADD(hh, DATEPART(hh, @inicioAux), DATEADD(day,+1, @diaFinalACancelar))), @finalAux, @diaInicialAux, @diaFinalAux)

IF (CAST(@diaFinalACancelar AS DATE) = CAST(@finalAux AS DATE))
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(mi, DATEPART(mi, @finalAux), DATEADD(hh, DATEPART(hh, @finalAux), DATEADD(day,-1, @diaInicialACancelar))), @diaInicialAux, @diaFinalAux)

IF (CAST (@diaInicialACancelar AS DATE) != CAST(@inicioAux AS DATE) AND CAST(@diaFinalACancelar AS DATE) != CAST(@finalAux AS DATE))
BEGIN
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), @inicioAux, DATEADD(mi, DATEPART(mi, @finalAux), DATEADD(hh, DATEPART(hh, @finalAux), DATEADD(day,-1,  @diaInicialACancelar))), @diaInicialAux, @diaFinalAux)
INSERT INTO GESTIONAME_LAS_VACACIONES.Agendas(idProfesional, idEspecialidad, fechaInicio, fechaFinal, diaInicio, diaFin)
VALUES (@matricula, GESTIONAME_LAS_VACACIONES.getIdEspecialidad(@especialidad), DATEADD(mi, DATEPART(mi, @inicioAux), DATEADD(hh, DATEPART(hh, @inicioAux), DATEADD(day,+1, @diaFinalACancelar))), @finalAux, @diaInicialAux, @diaFinalAux)
END

END
GO

--////////////////////////////////////--
--NUMERO 14--
--LISTADO ESTRATEGICO--

CREATE FUNCTION  GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones(@fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE 
AS
RETURN (SELECT GESTIONAME_LAS_VACACIONES.getIdEspecialidad(t.especialidad) as especialidad
  FROM GESTIONAME_LAS_VACACIONES.Turnos t WHERE t.baja = 1 AND (cast(t.fecha AS DATE)) BETWEEN
  CAST(@fechaInicio AS DATE) AND CAST(@fechaFin AS DATE))
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones(@fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE 
AS
RETURN (SELECT DISTINCT TOP 5 GESTIONAME_LAS_VACACIONES.getDescEspecialidad(especialidad) as especialidades
FROM GESTIONAME_LAS_VACACIONES.unirDosColumnasDeTablaDeCancelaciones(@fechaInicio,@fechaFin) where especialidad is not null);
GO

-- LISTADO #2 --
--TOP 5 PROFESIONALES MAS CONSULTADOS POR PLAN ESPECIFICANDO ESPECIALIDAD--

create FUNCTION GESTIONAME_LAS_VACACIONES.getTablaProfesionalesDeConsultas(@planes INT,@fechaInicio as DATETIME,@fechaFin as DATETIME)
RETURNS TABLE AS
RETURN (SELECT p.id idProf, COUNT(p.id) cantConsultas
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
ORDER BY cantConsultas desc
GO


-- LISTADO #3 --
-- TOP 5 PROFESIONALES CON MENOS HORAS TRABAJADAS FILTRADAS POR PLAN Y ESPECIALIDAD--

create table GESTIONAME_LAS_VACACIONES.TablaTemporalListado(
idProfesional INT, 
cantidadDeHoras INT,
especialidad INT 
) 
go

Create procedure GESTIONAME_LAS_VACACIONES.cargarTablaTemporalHorasProfesionales(@fechaDesde DATETIME, @fechaHasta DATETIME)
as BEGIN

TRUNCATE TABLE GESTIONAME_LAS_VACACIONES.TablaTemporalListado;

declare @horaInicio  DATETIME , @horaFin DATETIME
declare @idProfesional int
declare @diaInicio int, @diaFin int
declare @especialidad int

DECLARE cursoram cursor for select  idProfesional,fechaInicio,fechaFinal, diaInicio,diaFin, idEspecialidad from GESTIONAME_LAS_VACACIONES.Agendas
OPEN cursoram fetch next from 
cursoram into @idProfesional,@horaInicio,@horaFin, @diaInicio , @diaFin, @especialidad
while (@@FETCH_STATUS =0 )
begin 
if (@fechaDesde BETWEEN @horaInicio and @horaFin)
insert into GESTIONAME_LAS_VACACIONES.TablaTemporalListado values (@idProfesional,  (DATEPART(HOUR, @horaFin)*100+DATEPART(MINUTE,@horaFin)-DATEPART(HOUR, @horaInicio)*100 +DATEPART(MINUTE,@horaInicio)) * (@diaFin-@diaInicio+1), @especialidad)
fetch next from cursoram into @idProfesional,@horaInicio,@horaFin, @diaInicio , @diaFin, @especialidad
end 
close cursoram
deallocate cursoram
END
GO

-- Mergea agendas de la misma especialidad de un mismo profesional de la TablaTemporalListado --

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.MergearAgendas()
returns table as
return (select idProfesional, sum(cantidadDeHoras) as cantidadDeHoras, especialidad 
					FROM GESTIONAME_LAS_VACACIONES.TablaTemporalListado 
					GROUP BY especialidad, idProfesional)
GO 

create function GESTIONAME_LAS_VACACIONES.topProfesionalesConMenosHoras(@especialidad INT)
returns table as 
return (select top 5 sum(temp.cantidadDeHoras) cantidadDeHorasTotales, p.nombre, p.apellido from GESTIONAME_LAS_VACACIONES.MergearAgendas() temp 
join GESTIONAME_LAS_VACACIONES.Profesionales p 
on p.id = temp.idProfesional
WHERE @especialidad = temp.especialidad
GROUP BY p.nombre , p.apellido
ORDER BY cantidadDeHorasTotales asc)
go

-- LISTADO #5--
--Top 5 de las especialidades de médicos con más bonos de consultas utilizados--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadMasAtendida(@planes INT, @fechaInicio DATETIME,@fechaFin DATETIME)
RETURNS TABLE AS
RETURN (SELECT a.idProf AS profesional, COUNT(t.especialidad) AS vecesEspecialidad
FROM  GESTIONAME_LAS_VACACIONES.getTop5Profesionales(@planes,@fechaInicio,@fechaFin) a
JOIN GESTIONAME_LAS_VACACIONES.Turnos t
ON a.idProf = t.idProfesional
GROUP BY a.idProf, t.especialidad)
GO

-- LISTADO #4--
-- Pacientes con mas compras--


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras(@fechaInicio DATETIME,@fechaFin  DATETIME)
RETURNS TABLE AS
RETURN (SELECT TOP 5 unPaciente.id , unPaciente.nombre, unPaciente.apellido , unPaciente.cantFamiliares, sum(compra.cantidad) as 'cantidad'
FROM GESTIONAME_LAS_VACACIONES.Pacientes  unPaciente 
JOIN GESTIONAME_LAS_VACACIONES.ComprasBonos compra ON  unPaciente.id/100 = compra.idPaciente/100 and compra.fecha between @fechaInicio and @fechaFin
GROUP BY unPaciente.id, unPaciente.nombre,unPaciente.apellido,unPaciente.cantFamiliares
ORDER BY COUNT(compra.idPaciente))
GO

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas(@fechaInicio DATETIME, @fechaFin DATETIME)
RETURNS TABLE AS 
RETURN (SELECT TOP 5 especialidad.id as id, GESTIONAME_LAS_VACACIONES.getDescEspecialidad(especialidad.id) as especialidad, COUNT(consulta.id) cantidadDeConsultas FROM GESTIONAME_LAS_VACACIONES.Especialidades especialidad
JOIN (GESTIONAME_LAS_VACACIONES.ConsultasMedicas consulta
JOIN GESTIONAME_LAS_VACACIONES.Turnos turno
ON turno.id = consulta.idTurno and consulta.fecha between @fechaInicio and @fechaFin)
ON turno.especialidad = especialidad.descripcion
GROUP BY especialidad.id
ORDER BY COUNT(consulta.id) DESC)
GO


CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getEspecialidadNoAgendada(@id INTEGER)
RETURNS TABLE AS
RETURN (SELECT tipoEspecialidad FROM GESTIONAME_LAS_VACACIONES.Especialidades e JOIN 
GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional x ON e.id = x.idEspecialidad JOIN 
GESTIONAME_LAS_VACACIONES.Profesionales p ON x.idProfesional = p.id WHERE p.id = @id 
AND tipoEspecialidad NOT IN (SELECT idEspecialidad FROM GESTIONAME_LAS_VACACIONES.Agendas WHERE idProfesional = @id)) 
go

CREATE TRIGGER GESTIONAME_LAS_VACACIONES.seModificoPlan ON GESTIONAME_LAS_VACACIONES.modificaciones
AFTER INSERT
AS
DECLARE @idPaciente INT
DECLARE @idPlan INT
select idPaciente,idPlan FROM inserted
UPDATE GESTIONAME_LAS_VACACIONES.Pacientes SET planes = @idPlan WHERE id = @idPaciente
GO

--COLGADO ACA DESPUES LO SUBIRE--

CREATE FUNCTION GESTIONAME_LAS_VACACIONES.getDesDelPlan(@codPlan as INT)
RETURNS VARCHAR(100)
AS
BEGIN
RETURN (SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Planes where id = @codPlan)
END 
GO
