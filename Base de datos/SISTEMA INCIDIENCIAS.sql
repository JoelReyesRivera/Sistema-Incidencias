
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

CREATE TABLE DISPOSTIVO (
	NUMERO_SERIE VARCHAR(50) PRIMARY KEY,
	PROVEEDOR TINYINT NOT NULL FOREIGN KEY REFERENCES PROVEEDOR (ID),
	FECHA_EXPIRACION_GARANTIA DATE,
	MODELO VARCHAR(50) NOT NULL,
	DESCRIPCION VARCHAR(50) NOT NULL, 
	MARCA TINYINT NOT NULL FOREIGN KEY REFERENCES MARCA (ID),
	AULA INT FOREIGN KEY REFERENCES AULA (ID) 
)

/*
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
*/

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

GO

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

GO

CREATE PROCEDURE SPAgregaDispositivo
@NOSERIE VARCHAR(50), @PROVEEDOR VARCHAR (50), @GARANTIA DATE, @MODELO VARCHAR(50), 
@DESCRIPCION VARCHAR(100), @MARCA VARCHAR(50), @AULA VARCHAR(50) 
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			SET NOCOUNT ON
			DECLARE @E TINYINT
			DECLARE @C INT
			if EXISTS (SELECT @NOSERIE FROM DISPOSTIVO WHERE NUMERO_SERIE=@NOSERIE)
			BEGIN
				SET @E = 1
				RAISERROR ('N�MERO DE SERIE YA EXISTENTE',16,1)
			END
			DECLARE @PROVEEDORKEY TINYINT = (SELECT ID FROM PROVEEDOR WHERE NOMBRE = @PROVEEDOR)
			DECLARE @MARCAKEY TINYINT = (SELECT ID FROM MARCA WHERE NOMBRE = @MARCA)
			DECLARE @AULAKEY INT = (SELECT ID FROM AULA WHERE DESCRIPCION = @AULA)

			INSERT INTO DISPOSTIVO(NUMERO_SERIE,PROVEEDOR,FECHA_EXPIRACION_GARANTIA,MODELO,DESCRIPCION,MARCA,AULA)
			VALUES (@NOSERIE,@PROVEEDORKEY,@GARANTIA,@MODELO,@DESCRIPCION,@MARCAKEY,@AULAKEY)
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
/*
SELECT USUARIO,PASSWORD,D.NOMBRE FROM JEFE_DEPARTAMENTO J 
INNER JOIN DEPARTAMENTO D ON J.DEPARTAMENTO = D.ID  WHERE J.USUARIO =  'MROSARIO'

UPDATE JEFE_DEPARTAMENTO SET DEPARTAMENTO = 2 WHERE USUARIO='RARTURO'

UPDATE JEFE_DEPARTAMENTO SET USUARIO = 'RARTURO'  WHERE DEPARTAMENTO=1
SELECT * FROM JEFE_DEPARTAMENTO
<<<<<<< HEAD
*/

select * from Jefe_departamento
SELECT  NOMBRE FROM DEPARTAMENTO
SELECT  id FROM DEPARTAMENTO WHERE Nombre = 'ELECTRONICA'
SELECT * FROM JEFE_DEPARTAMENTO
SELECT * from DEPARTAMENTO
=======
*/
>>>>>>> master
