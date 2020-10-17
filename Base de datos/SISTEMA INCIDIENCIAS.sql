--CREATE DATABASE SISTEMA_INCIDENCIAS
CREATE DATABASE SISTEMA_INCIDENCIAS

GO

USE SISTEMA_INCIDENCIAS

GO
CREATE TABLE MARCA (
	ID TINYINT PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL 
) 

CREATE TABLE PROVEEDOR (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(50) NOT NULL ,
	DOMICILIO VARCHAR(50) NOT NULL ,
	RFC VARCHAR (15) NOT NULL 
)

CREATE TABLE DEPARTAMENTO (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL
)

CREATE TABLE JEFE_DEPARTAMENTO (
	USUARIO VARCHAR(50) PRIMARY KEY,
	PASSWORD VARCHAR(50),
	DEPARTAMENTO TINYINT FOREIGN KEY REFERENCES DEPARTAMENTO (ID),
)

CREATE TABLE ADMINISTRADOR (
	USUARIO VARCHAR(50) PRIMARY KEY,
	PASSWORD VARCHAR(50)
)

CREATE TABLE AULA (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(50),
	JEFE_DEPARTAMENTO VARCHAR(50) FOREIGN KEY REFERENCES JEFE_DEPARTAMENTO (USUARIO) 
)

CREATE TABLE DISPOSTIVO (
	NUMERO_SERIE VARCHAR(50) PRIMARY KEY,
	PROVEEDOR TINYINT NOT NULL FOREIGN KEY REFERENCES PROVEEDOR (ID),
	FECHA_EXPIRACION_GARANTIA DATE,
	MODELO VARCHAR(50) NOT NULL,
	DESCRIPCION VARCHAR(50) NOT NULL,
	MARCA TINYINT NOT NULL FOREIGN KEY REFERENCES MARCA (ID),
	AULA INT FOREIGN KEY REFERENCES AULA (ID) 
)

CREATE TABLE ORDENADOR (
	NUMERO_SERIE VARCHAR(50) FOREIGN KEY REFERENCES DISPOSTIVO (NUMERO_SERIE),
	SO VARCHAR(50),
	PROCESADOR VARCHAR(50),
	DISCO_DURO VARCHAR(50),
	RAM VARCHAR(50),
	PLACA_BASE VARCHAR(50)
)

CREATE TABLE MONITOR (
	NUMERO_SERIE VARCHAR(50) FOREIGN KEY REFERENCES DISPOSTIVO (NUMERO_SERIE),
	PULGADAS TINYINT NOT NULL
)

CREATE TABLE ROUTER (
	NUMERO_SERIE VARCHAR(50) FOREIGN KEY REFERENCES DISPOSTIVO (NUMERO_SERIE),
	CANTIDAD_PUERTOS TINYINT NOT NULL,
	FRECUENCIA VARCHAR(50),
	TIPO_CONEXION BIT NOT NULL
)

CREATE TABLE DEPARTAMENTO_TECNICO (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL 
)

CREATE TABLE TECNICO (
	USUARIO VARCHAR(50) PRIMARY KEY,
	PASSWORD VARCHAR(50),
	DEPARTAMENTO_TECNICO TINYINT NOT NULL FOREIGN KEY REFERENCES DEPARTAMENTO_TECNICO (ID) 
)

CREATE TABLE ESTATUS_INCIDENCIA (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL 
)

CREATE TABLE INCIDENCIA (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	REPORTADO_POR VARCHAR(50) FOREIGN KEY REFERENCES JEFE_DEPARTAMENTO (USUARIO) NOT NULL,
	ESTATUS TINYINT FOREIGN KEY REFERENCES ESTATUS_INCIDENCIA(ID) NOT NULL,
	FECHA_REPORTE DATE NOT NULL,
)

CREATE TABLE DETALLE_INCIDENCIA(
	INCIDENCIA TINYINT PRIMARY KEY FOREIGN KEY REFERENCES INCIDENCIA (ID) ,
	FECHA_SOLUCION DATE,
	DISPOSTIVO VARCHAR(50) FOREIGN KEY REFERENCES DISPOSTIVO (NUMERO_SERIE),
	SOLUCIONADO_POR VARCHAR(50) FOREIGN KEY REFERENCES TECNICO (USUARIO) NOT NULL,
	HORAS_TOTALES TINYINT
)

INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('SISTEMAS Y TIC') 
INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('ELECTRONICA') 
INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('MECATRONICA') 
INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('BIOQUIMICA') 
INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('INDUSTRIAL') 
INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('RENOVABLES') 
INSERT INTO DEPARTAMENTO (NOMBRE)
VALUES ('GESTION EMPRESARIAL')


INSERT INTO ADMINISTRADOR(USUARIO,PASSWORD)
VALUES ('FERNANDO','ABCDEF')