
CREATE DATABASE SISTEMA_INCIDENCIAS

GO

USE SISTEMA_INCIDENCIAS

GO
CREATE TABLE MARCA (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL 
) 

CREATE TABLE PROVEEDOR (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(50) NOT NULL ,
	DOMICILIO VARCHAR(100) NOT NULL ,
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

CREATE TABLE DISPOSITIVO (
	NUMERO_SERIE VARCHAR(50) PRIMARY KEY,
	PROVEEDOR TINYINT NOT NULL FOREIGN KEY REFERENCES PROVEEDOR (ID),
	FECHA_EXPIRACION_GARANTIA DATE,
	MODELO VARCHAR(50) NOT NULL,
	DESCRIPCION VARCHAR(50) NOT NULL, 
	MARCA TINYINT NOT NULL FOREIGN KEY REFERENCES MARCA (ID),
	AULA INT FOREIGN KEY REFERENCES AULA (ID) 
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

CREATE TABLE ESTATUS(
	ID TINYINT PRIMARY KEY,
	DESCRIPCION VARCHAR(20)
)

CREATE TABLE INCIDENCIA (
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	DISPOSITIVO VARCHAR(50) FOREIGN KEY REFERENCES DISPOSITIVO (NUMERO_SERIE),
	DESCRIPCION VARCHAR(500),
	REPORTADO_POR VARCHAR(50) FOREIGN KEY REFERENCES JEFE_DEPARTAMENTO (USUARIO) NOT NULL,
	ESTATUS TINYINT FOREIGN KEY REFERENCES ESTATUS(ID) NOT NULL,
	FECHA_REPORTE DATE NOT NULL
)


CREATE TABLE INCIDENCIA_TECNICO(
	ID TINYINT IDENTITY(1,1) PRIMARY KEY,
	ID_INCIDENCIA TINYINT FOREIGN KEY REFERENCES INCIDENCIA(ID)NOT NULL,
	ADMINISTRADOR VARCHAR(50) FOREIGN KEY REFERENCES ADMINISTRADOR(USUARIO) NOT NULL,
	TECNICO VARCHAR(50) FOREIGN KEY REFERENCES TECNICO(USUARIO) NOT NULL,
	FECHA_ASIGNACION DATE NOT NULL,
)

CREATE TABLE INCIDENCIA_CONCLUIDA(
	ID SMALLINT IDENTITY (1,1) PRIMARY KEY,
	ID_INCIDENCIA TINYINT FOREIGN KEY REFERENCES INCIDENCIA(ID),
	FECHA_SOLUCION DATE,
	SOLUCIONADO_POR VARCHAR(50) FOREIGN KEY REFERENCES TECNICO (USUARIO) NOT NULL,
)

CREATE TABLE PERTENECE_ALMACEN(
	ID SMALLINT IDENTITY (1,1) PRIMARY KEY,
	DISPOSITIVO VARCHAR(50) FOREIGN KEY REFERENCES DISPOSITIVO (NUMERO_SERIE) UNIQUE,
	FECHA_INGRESO DATE	 
)
GO

INSERT INTO ESTATUS(ID, DESCRIPCION)
VALUES
(0,'PENDIENTE DE ASIGNAR'),
(1,'FINALIZADA'),
(2,'ASIGNADA'),
(3,'EN PAUSA')


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

INSERT INTO DEPARTAMENTO_TECNICO(NOMBRE) VALUES ('REDES')
INSERT INTO DEPARTAMENTO_TECNICO(NOMBRE) VALUES ('HARDWARE')
INSERT INTO DEPARTAMENTO_TECNICO(NOMBRE) VALUES ('SOFTWARE')

INSERT INTO TECNICO VALUES('FELIPE','ABCDEF',1)
INSERT INTO TECNICO VALUES('JUAN','ABCDEF',2)

GO

INSERT INTO PROVEEDOR (NOMBRE,DOMICILIO,RFC)
VALUES
('DELL','Av. Paseo de la Reforma 2620, Lomas Altas, Miguel Hidalgo, 11950 Ciudad de M�xico, CDMX, M�xico','DME9204099R6'),
('HEWLETT PACKARD',' Prolongacion Paseo de la Reforma Col 700 Del, �lvaro Obreg�n, 01210 Ciudad de M�xico','HME871101RG3'),
('ASUSTEK COMPUTER',' Av de los Insurgentes Sur 1647, San Jos� Insurgentes, Benito Ju�rez, 03900 Ciudad de M�xico, CDMX','ATP100120JL5'),
('CISCO SYSTEMS','P. de los Tamarindos 400A, Bosques de las Lomas, Cuajimalpa de Morelos, 05120 Ciudad de M�xico, CDMX','CSM9301219B4'),
('TP-LINK TECHNOLOGIES','Blvd. Miguel de Cervantes Saavedra 233, Amp Granada, Miguel Hidalgo, 11520 Ciudad de M�xico, CDMX','M110218S15'),
('TELMEX','Av. Parque V�a, No. 198, Col. Cuauht�moc, Alcald�a Cuauht�moc, Ciudad de M�xico, C.P. 06500','TME840315KT6 ')

INSERT INTO MARCA(NOMBRE)
VALUES
('DELL'),
('HP'),
('ASUS'),
('TP-LINK'),
('CISCO'),
('COMPAQ'),
('MICROSOFT'),
('APPLE'),
('SAMSUNG'),
('VORAGO'),
('HUAWEI'),
('BENQ')

INSERT INTO JEFE_DEPARTAMENTO(USUARIO,PASSWORD,DEPARTAMENTO)
VALUES
('MROSARIO','ABCDEF',1),
('RARTURO','ABCDEF',2),
('GMARIANA','ABCDEF',3),
('PJAZMIN','ABCDEF',4)

INSERT INTO AULA(DESCRIPCION,JEFE_DEPARTAMENTO)
VALUES
('EASA','MROSARIO'),
('EB01','MROSARIO'),
('EB02','MROSARIO'),
('EB03','MROSARIO'),
('EB04','MROSARIO'),
('EB05','MROSARIO'),
('EB06','MROSARIO'),
('EC01','MROSARIO'),
('EC02','MROSARIO'),
('EC03','MROSARIO'),
('EC04','MROSARIO'),
('EC05','MROSARIO'),
('EC06','MROSARIO'),
('ED01','PJAZMIN'),
('ED02','PJAZMIN'),
('ED03','PJAZMIN'),
('ED04','PJAZMIN'),
('ED05','PJAZMIN'),
('ED06','PJAZMIN')

INSERT INTO DISPOSITIVO
VALUES (385712095,2,GETDATE(),'COMPAQ','LAPTOP',1,1)

INSERT INTO DISPOSITIVO
VALUES (825723598,1,GETDATE(),'ASUS','PC',2,4)

INSERT INTO DISPOSITIVO
VALUES (385712565,2,GETDATE(),'LENOVO','LAPTOP',1,1)

INSERT INTO DISPOSITIVO
VALUES (825721258,1,GETDATE(),'ACER','PC',2,4)

INSERT INTO PERTENECE_ALMACEN
VALUES(825721258,GETDATE())

INSERT INTO PERTENECE_ALMACEN
VALUES(385712565,GETDATE())

INSERT INTO INCIDENCIA values('385712095','NO MUESTRA IMAGEN','GMARIANA',0,'2020-12-3')
INSERT INTO INCIDENCIA values('825723598','FALLA MEMORIA','GMARIANA',0,'2020-12-3')

GO


CREATE PROCEDURE SPAgregaDispositivo
@NOSERIE VARCHAR(50), @PROVEEDOR VARCHAR (50), @GARANTIA DATE, @MODELO VARCHAR(50), 
@DESCRIPCION VARCHAR(100), @MARCA VARCHAR(50), @AULA VARCHAR(50),@ALMACEN INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			SET NOCOUNT ON
			DECLARE @E TINYINT
			DECLARE @C INT
			if EXISTS (SELECT @NOSERIE FROM DISPOSITIVO WHERE NUMERO_SERIE=@NOSERIE)
			BEGIN
				SET @E = 1
				RAISERROR ('N�MERO DE SERIE YA EXISTENTE',16,1)
			END
			DECLARE @PROVEEDORKEY TINYINT = (SELECT ID FROM PROVEEDOR WHERE NOMBRE = @PROVEEDOR)
			DECLARE @MARCAKEY TINYINT = (SELECT ID FROM MARCA WHERE NOMBRE = @MARCA)
			DECLARE @AULAKEY INT = (SELECT ID FROM AULA WHERE DESCRIPCION = @AULA)

			INSERT INTO DISPOSITIVO(NUMERO_SERIE,PROVEEDOR,FECHA_EXPIRACION_GARANTIA,MODELO,DESCRIPCION,MARCA,AULA)
			VALUES (@NOSERIE,@PROVEEDORKEY,@GARANTIA,@MODELO,@DESCRIPCION,@MARCAKEY,@AULAKEY)

			IF @ALMACEN = 1
				INSERT INTO PERTENECE_ALMACEN VALUES(@NOSERIE, GETDATE())

		COMMIT TRANSACTION
		RETURN 0
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		IF (XACT_STATE()) = -1
		BEGIN
			PRINT 'ERROR INTERNO EN LA TRANSACCI�N, NO SE APLIC� NING�N CAMBIO'
			RETURN -1
		END
		DECLARE @ERROR_MESSAGE VARCHAR(1000) = (select ERROR_MESSAGE())
		DECLARE @ERROR_SEVERITY SMALLINT = (select ERROR_SEVERITY())
		DECLARE @ERROR_STATE SMALLINT = (select ERROR_STATE())
		RAISERROR(@ERROR_MESSAGE,@ERROR_SEVERITY,@ERROR_STATE)
		RETURN @E
	END CATCH
END

GO

CREATE PROCEDURE SPAgregaIncidencia
@NOSERIE VARCHAR(50), @JEFE_DEPTO VARCHAR (50), @DESCRIPCION VARCHAR(500)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			SET NOCOUNT ON
			INSERT INTO INCIDENCIA(DISPOSITIVO,DESCRIPCION,REPORTADO_POR,ESTATUS,FECHA_REPORTE)
			VALUES(@NOSERIE,@DESCRIPCION,@JEFE_DEPTO,0,GETDATE())
		COMMIT TRANSACTION
		RETURN 0
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		IF (XACT_STATE()) = -1
		BEGIN
			PRINT 'ERROR INTERNO EN LA TRANSACCI�N, NO SE APLIC� NING�N CAMBIO'
			RETURN -1
		END
		DECLARE @ERROR_MESSAGE VARCHAR(1000) = (select ERROR_MESSAGE())
		DECLARE @ERROR_SEVERITY SMALLINT = (select ERROR_SEVERITY())
		DECLARE @ERROR_STATE SMALLINT = (select ERROR_STATE())
		RAISERROR(@ERROR_MESSAGE,@ERROR_SEVERITY,@ERROR_STATE)
	END CATCH
END

GO

CREATE VIEW VW_Incidencias
WITH ENCRYPTION
AS
SELECT I.ID,I.DISPOSITIVO,M.NOMBRE AS MARCA,D.MODELO,A.DESCRIPCION AS UBICADO,I.DESCRIPCION AS INCIDENCIA,I.REPORTADO_POR,FORMAT(I.FECHA_REPORTE,'dd/MMM/yyy') as FECHA,E.DESCRIPCION AS ESTATUS FROM INCIDENCIA I
INNER JOIN ESTATUS E ON I.ESTATUS = E.ID
INNER JOIN DISPOSITIVO D ON I.DISPOSITIVO = D.NUMERO_SERIE
INNER JOIN MARCA M ON M.ID = D.MARCA
INNER JOIN AULA A ON D.AULA = A.ID

GO

CREATE VIEW VW_IncidenciasAsignadas
WITH ENCRYPTION
AS
SELECT IT.ID,ID_INCIDENCIA,D.NUMERO_SERIE,IT.ADMINISTRADOR,M.NOMBRE AS MARCA, D.MODELO,A.DESCRIPCION AS AULA, FORMAT(IT.FECHA_ASIGNACION,'dd/MMM/yyy') AS FECHA, E.DESCRIPCION AS ESTATUS,IT.TECNICO, I.DESCRIPCION AS DETALLE FROM INCIDENCIA_TECNICO IT
INNER JOIN INCIDENCIA I ON IT.ID_INCIDENCIA = I.ID
INNER JOIN DISPOSITIVO D ON D.NUMERO_SERIE = I.DISPOSITIVO
INNER JOIN MARCA M ON M.ID = D.MARCA
INNER JOIN AULA A ON D.AULA = A.ID
INNER JOIN ESTATUS E ON E.ID=I.ESTATUS

GO

CREATE VIEW VW_IncidenciasConcluidas
WITH ENCRYPTION
AS
SELECT IT.ID_INCIDENCIA,I.DISPOSITIVO,M.NOMBRE AS MARCA,D.MODELO,A.DESCRIPCION AS UBICADO,I.DESCRIPCION AS INCIDENCIA,I.REPORTADO_POR,
FORMAT(I.FECHA_REPORTE,'dd/MMM/yyy') as FECHA_REPORTE,FORMAT(IC.FECHA_SOLUCION,'dd/MMM/yyy') as FECHA_SOLUCION, E.DESCRIPCION AS ESTATUS,ic.SOLUCIONADO_POR
FROM INCIDENCIA I
INNER JOIN ESTATUS E ON I.ESTATUS = E.ID
INNER JOIN DISPOSITIVO D ON I.DISPOSITIVO = D.NUMERO_SERIE
INNER JOIN MARCA M ON M.ID = D.MARCA
INNER JOIN AULA A ON D.AULA = A.ID
INNER JOIN INCIDENCIA_CONCLUIDA IC ON I.ID=IC.ID_INCIDENCIA
INNER JOIN INCIDENCIA_TECNICO IT ON I.ID=IT.ID_INCIDENCIA


